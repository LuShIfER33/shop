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
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "insert into [dbo].[Items] (Items) values('" + textBox1.Text + "') ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
            textBox1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "delete from [dbo].[Items] where Items=('" + textBox1.Text + "') ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
            textBox1 = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
        }
    }
}
