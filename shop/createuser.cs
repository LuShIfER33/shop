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
    public partial class createuser : Form
    {
        public createuser()
        {
            InitializeComponent();

            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin]");


            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            comboBox1.TabIndex = 4;
            textBox5.TabIndex = 5;
            textBox6.TabIndex = 6;
            button1.TabIndex = 7;
            button2.TabIndex = 8;
            button3.TabIndex = 9;
        }

        private void createuser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                bool sl0 = false;
                try
                {
                    sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                    "  insert into UserLogin ([UserId] ,[Password] ,[Department],[name],[otherDetails]) " +
                    "Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "');--('" + textBox1.Text + "') ");
                    MessageBox.Show("Successful ");
                    dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin]");

                }
                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);


                }

            }
            else
            {
                MessageBox.Show("password Mismatch !!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "  delete from dbo.UserLogin where name = ('" + textBox5.Text + "') ");
                MessageBox.Show("Successful ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin] ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin] ");
                textBox5.Text = null;

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox5.Text = row.Cells[1].Value.ToString();
        }
    }
}
