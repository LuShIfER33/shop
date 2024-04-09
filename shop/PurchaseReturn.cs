using Microsoft.VisualBasic;
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
    public partial class PurchaseReturn : Form
    {
        public PurchaseReturn()
        {
            InitializeComponent();
            textBox3.Text = DateAndTime.DateString;
            textBox1.TabIndex = 0;
            button1.TabIndex = 1;
            dataGridView1.TabIndex = 2;
            textBox2.TabIndex = 3;
            returnsubmit.TabIndex = 4;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = new Form1();
            form1Instance.Show();
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            comboBox1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("  select Item_Name From dbo.purchase where Bill_No='" + textBox1.Text + "'");
            comboBox1.DisplayMember = "Item_Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT  [Item_Name] ,[Batch_No] ,[Exp_Date] ,[Unit] ,[Rate] ,[MRP] ,[Bill_No] ,[Bill_Date],[Entry_Date],[Supplier] ,[Pay_Type],[Return_qty],[Sell_qty] ,[Curr_Stock] FROM [MeroPasal].[dbo].[purchase] where Bill_No='" + textBox1.Text + "';");
            // comboBox1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("  select Item_Name From dbo.purchase where Bill_No='" + textBox1.Text + "'");
            // comboBox1.DisplayMember = "Item_Name";
            //textBox4.Text = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT [Quantity] FROM [dbo].[purchase] where Bill_No='" + textBox1.Text + "' and Item_Name ='" + comboBox1.Text + "' ").ToString();
            // int value = Convert.ToInt32(textBox4.Text);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //textBox4.Text = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("SELECT [Quantity] FROM [dbo].[purchase] where Bill_No='" + textBox1.Text + "' and Item_Name ='" + comboBox1.Text + "' ").ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox2.Text = row.Cells[13].Value.ToString();
            textBox4.Text = row.Cells[13].Value.ToString();
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void returnsubmit_Click(object sender, EventArgs e)
        {
            bool ex1 = false;
            try
            {
                int remstock= Convert.ToInt32(this.textBox4.Text);
                if (remstock >0)
                {
                    ex1 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries: "Update dbo.purchase Set Return_qty =" + textBox2.Text + " WHERE Item_Name='" + comboBox1.Text + "' and Bill_No=" + textBox1.Text + "");
                    CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries: "Update dbo.purchase Set Curr_Stock =" + textBox5.Text + " WHERE Item_Name='" + comboBox1.Text + "' and Bill_No=" + textBox1.Text + "");
                    MessageBox.Show("Return Success!!");
                }
                else
                {
                    MessageBox.Show("No avilable stock!!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(this.textBox2.Text);
            int b=Convert.ToInt32(this.textBox4.Text);
            textBox5.Text =Convert.ToString( b-a);
        }
    }
}
