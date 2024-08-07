using Meropasal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace shop
{
    public partial class createuser : Form
    {
        public createuser()
        {
            InitializeComponent();
            textBox1.Focus();
            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [userID], [name] from [dbo].[UserLogin] where isDeleted !='1'");
            dataGridView1.Columns[0].Visible = false;

            textBox2.TabIndex = 1;
            textBox3.TabIndex = 2;
            comboBox1.TabIndex = 3;
            textBox5.TabIndex = 4;
            textBox6.TabIndex = 5;
            button1.TabIndex = 6;
            button2.TabIndex = 7;
            button4.TabIndex = 8;
        }

        private void createuser_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT [userID],[name]" +
                "  FROM [MeroPasal].[dbo].[UserLogin] where isDeleted !='1'");
            string encuser = AesOperation.EncryptString(textBox1.Text);
            string authorToFind = encuser;
            bool exists = dt.AsEnumerable().Any(row => row.Field<string>("UserId") == authorToFind);

            if (!exists)
            {
                string username = AesOperation.EncryptString(textBox1.Text);
                string password = AesOperation.EncryptString(textBox2.Text);

                if (textBox3.Text == textBox2.Text)
                {
                    bool sl0 = false;
                    try
                    {
                        //save user data.
                        sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                       "INSERT INTO UserLogin ([UserId], [Password], [Department], [name], [otherDetails], [isDeleted]) " +
               "VALUES ('" + username + "','" + password + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','0')");


                        if (sl0 == false) 
                        { 
                            MessageBox.Show("Error!");
                        }
                        else { 
                            MessageBox.Show("Successful ");
                        }
                        dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [userID], [name] from [dbo].[UserLogin] where isDeleted !='1'");
                        dataGridView1.Columns[0].Visible = false;
                        // Log
                        string user = AesOperation.DecryptString(authorToFind);
                        CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("insert into [LogDetails] ([FormName],[UserName],[ComputerName],[Datetime],[Action]) values ('create account :  ','" + user + "','" + Environment.MachineName + "','" + DateTime.Now.ToString("yyyyMMddHHmmss") + "','Create user" + textBox1.Text + " ')");
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
            else
            {
                MessageBox.Show("User-Name already taken !!");
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            button2.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool sl0 = false;
            try
            {
                sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                "   update [UserLogin] set isDeleted='1' where name = ('" + textBox5.Text + "') ");
                MessageBox.Show("Successful ");
                // dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin] ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin] where isDeleted !='1' ");
                dataGridView1.Columns[0].Visible = false;
                textBox5.Text = null;
                // log filling 
                string authorToFind = AesOperation.EncryptString(textBox1.Text);
                string user = AesOperation.DecryptString(authorToFind);
                CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("insert into [LogDetails] ([FormName],[UserName],[ComputerName],[Datetime],[Action]) values ('Deleted a account','" + user + "','" + Environment.MachineName + "','" + DateTime.Now.ToString("yyyyMMddHHmmss") + "','Delete user" + textBox1.Text + " ')");
                // clear all fields 
                clearall();
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

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox5.Text = row.Cells[1].Value.ToString();
            String User = row.Cells[0].Value.ToString();
            textBox1.Text = AesOperation.DecryptString(User);
            textBox2.Text = textBox3.Text = "********";
            textBox6.Text = "--- Hidden!!! ---";
            button2.Visible = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void createuser_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
