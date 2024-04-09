using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shop
{
    public partial class unit : Form
    {
        public unit()
        {
            InitializeComponent();
            textBox1.TabIndex = 0;
            button2.TabIndex = 1;
            button1.TabIndex = 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "insert into [dbo].[Units] (Unit) values('" + textBox1.Text + "') ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit from [dbo].[Units] ");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit from [dbo].[Units] ");

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
            textBox1.Text = null;
        }

        private void unit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit from [dbo].[Units] ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "delete from [dbo].[Units] where unit=('" + textBox1.Text + "') ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit from [dbo].[Units] ");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit from [dbo].[Units] ");

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
            textBox1.Text = null;           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
        }
    }
}
