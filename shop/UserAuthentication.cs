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

namespace shop
{
    public partial class UserAuthentication : Form
    {
        public UserAuthentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt;
            dt = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT UserId  FROM [MeroPasal].[dbo].[UserLogin]");
            string authorToFind = textBox3.Text;
            bool exists = dt.AsEnumerable().Any(row => row.Field<string>("UserId") == authorToFind);

            if (exists)
            {
                DataTable dt1;
                dt1 = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT Password  FROM [MeroPasal].[dbo].[UserLogin]");
                string authorToFind1 = textBox2.Text;
                bool exists1 = dt1.AsEnumerable().Any(row => row.Field<string>("Password") == authorToFind1);
                if (exists1)
                {
                    DataTable dt2;
                    dt2 = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT Department  FROM [MeroPasal].[dbo].[UserLogin]");
                    string authorToFind2 = comboBox1.Text;
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

