using Meropasal;
using System;
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

            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [userID], [name] from [dbo].[UserLogin]");
            dataGridView1.Columns[0].Visible = false;


            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            comboBox1.TabIndex = 4;
            textBox5.TabIndex = 5;
            textBox6.TabIndex = 6;
            button1.TabIndex = 7;
            button2.TabIndex = 8;
            button4.TabIndex = 9;
        }

        private void createuser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT [userID]" +
                "  FROM [MeroPasal].[dbo].[UserLogin]");
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
                        sl0 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                        "  insert into UserLogin ([UserId] ,[Password] ,[Department],[name],[otherDetails]) " +
                        "Values('" + username + "','" + password + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "');--('" + textBox1.Text + "') ");
                        MessageBox.Show("Successful ");
                        dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [userID], [name] from [dbo].[UserLogin]");
                        dataGridView1.Columns[0].Visible = false;
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
                MessageBox.Show("User already taken !!");
            }

        }
        private void button4_Click(object sender, EventArgs e)
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
                "  delete from dbo.UserLogin where name = ('" + textBox5.Text + "') ");
                MessageBox.Show("Successful ");
                // dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin] ");
                dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select [UserId],[name] from [dbo].[UserLogin] ");
                dataGridView1.Columns[0].Visible = false;
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
    }
}
