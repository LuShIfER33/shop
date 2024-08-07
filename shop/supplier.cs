using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select SName,SContact,SPan from [dbo].[Supplier] where isDeleted !='1'");
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            button1.TabIndex = 4;
            textBox4.TabIndex = 5;
            button2.TabIndex = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "INSERT INTO [MeroPasal].[dbo].[Supplier]  (SName,SContact,SPan,isDeleted) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','0') ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select SName,SContact,SPan from [dbo].[Supplier] where isDeleted !='1'");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select SName,SContact,SPan from [dbo].[Supplier] where isDeleted !='1'");

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
            textBox1.Text = null; textBox2.Text = null; textBox3.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "UPDATE [dbo].[Supplier] set isDeleted='1' where (SPan) = ('" + textBox4.Text + "') ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select SName,SContact,SPan from [dbo].[Supplier] where isDeleted !='1'");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select SName,SContact,SPan from [dbo].[Supplier] where isDeleted !='1'");

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
            textBox4.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox4.Text = row.Cells[2].Value.ToString();
        }
    }
}
