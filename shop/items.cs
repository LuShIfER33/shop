using Microsoft.VisualBasic.ApplicationServices;
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
                if (sl0)
                {
                    MessageBox.Show("Successful ");

                    dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");
                    //Log

                    string user = AesOperation.DecryptString( publicvariable.loginuser);
                    CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                        "insert into [LogDetails] ([FormName],[UserName],[ComputerName],[Datetime],[Action]) values ('Item Created by ','" + user + "','" + Environment.MachineName + "','" + DateTime.Now.ToString("yyyyMMddHHmmss") + "','created item called : " + textBox1.Text + "')");
                }
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
                " update [dbo].[Items] set isDeleted='1' where Items='"+textBox1.Text+"' ");
                if (sl0)
                {
                    MessageBox.Show("Successful ");
                    dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Items from [dbo].[Items] ");
                }
                else
                {
                    MessageBox.Show("Error !");
                }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void items_Load(object sender, EventArgs e)
        {

        }

        private void items_Activated(object sender, EventArgs e)
        {

        }
    }
}
