using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace shop
{
    public partial class UserAuthentication : Form
    {
        public UserAuthentication()
        {
            InitializeComponent();
            textBox3.TabIndex = 0;
            textBox2.TabIndex = 1;
            comboBox1.TabIndex = 2;
            button2.TabIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            string username = AesOperation.EncryptString(textBox3.Text);
            string password = AesOperation.EncryptString(textBox2.Text);
            login(username, password, comboBox1.Text);
        }
        public void login(string username, string password, string depart)
        {
            DataTable dt;
            dt = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT UserId  FROM [MeroPasal].[dbo].[UserLogin]");
            string authorToFind = username;
            bool exists = dt.AsEnumerable().Any(row => row.Field<string>("UserId") == authorToFind);

            if (exists)
            {
                DataTable dt1;
                dt1 = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT Password  FROM [MeroPasal].[dbo].[UserLogin]");
                string authorToFind1 = password;
                bool exists1 = dt1.AsEnumerable().Any(row => row.Field<string>("Password") == authorToFind1);
                if (exists1)
                {
                    DataTable dt2;
                    dt2 = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT Department  FROM [MeroPasal].[dbo].[UserLogin]");
                    string authorToFind2 = depart;
                    bool exists2 = dt2.AsEnumerable().Any(row => row.Field<string>("Department") == authorToFind2);
                    if (exists2)
                    {
                        var Form1 = new Form1();
                        this.Hide();
                        Form1.toolStripStatusLabel2.Text = textBox3.Text;
                        Form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error while trying to login !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Error while trying to login !!!");
                }
            }
            else
            {
                MessageBox.Show("Error while trying to login !!!");
            }
        }

        private void UserAuthentication_Load(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserAuthentication_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                textBox1.Visible = true;
                textBox1.Enabled = true;
                label5.Visible = true;
                label5.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Enabled = true;
            label5.Visible = true;
            label5.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
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
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = AesOperation.EncryptString(textBox3.Text);
                string password = AesOperation.EncryptString(textBox2.Text);
                login(textBox3.Text, textBox2.Text, comboBox1.Text);
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //}
    }
}

