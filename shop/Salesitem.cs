using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shop
{
    public partial class Salesitem : Form
    {
        public Salesitem()
        {
            InitializeComponent();


            textBox3.Text = DateTime.Now.ToString("M-d-h-m-s");
            textBox4.Text = DateTime.Today.ToString("yyyy-MM-dd");

            comboBox3.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox6.TabIndex = 3;
            textBox7.TabIndex = 4;
            textBox1.TabIndex = 5;
            textBox5.TabIndex = 6;

            textBox11.TabIndex = 7;
            comboBox1.TabIndex = 8;
            textBox13.TabIndex = 9;

            button2.TabIndex = 10;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString("M-d-h-m-s");
            bool ss1 = false;
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    ss1 = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                                "INSERT INTO [dbo].[salesItem] (item,batch,qty,unit,rate,todaydate,billno,paytype,BuyerName,BuyerContact) VALUES ('"
                                + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','"
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + "','"
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + "','"
                                + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','"
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) + "','"
                                + textBox4.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')");

                    CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                        "Update[dbo].[purchase] SET Sell_qty='"+ Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + "' where Item_Name='"+ dataGridView1.Rows[i].Cells[0].Value.ToString() + "'");
                }
            }
            catch (Exception ex)
            {
                if (ss1 = true)
                {
                    MessageBox.Show("Successful ");
                }
                else
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add();

            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = textBox5.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = textBox11.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = comboBox1.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value = textBox13.Text;

            textBox1.Text = "";
            textBox5.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            comboBox1.Text = "";
            textBox1.TabIndex = 0;
        }

        private void textBox1_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_FontChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Item_Name,Quantity,Batch_No,Exp_Date,Rate,Unit From dbo.Purchase where Item_Name = '" + textBox1.Text + "'");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            dataGridView2.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Item_Name,Quantity,Batch_No,Exp_Date,Rate,Unit From dbo.Purchase where Item_Name = '" + textBox1.Text + "'");

        }

        private void Salesitem_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit From dbo.Units");
            comboBox1.DisplayMember = "Unit";

            textBox1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("  select Items From dbo.Items");
            textBox1.DisplayMember = "Items";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2
               .Rows[e.RowIndex];
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox13.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[5].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            dataGridView2.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Item_Name,Quantity,Batch_No,Exp_Date,Rate,Unit From dbo.Purchase where Item_Name = '" + textBox1.Text + "' ");

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2
              .Rows[e.RowIndex];
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox13.Text = row.Cells[4].Value.ToString();
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox11.Text) > Convert.ToInt16(textBox2.Text))
            {
                MessageBox.Show("Invalid QTY");
                textBox11.Focus();
            }
            if (Convert.ToInt16(textBox2.Text) == 0)
            {
                MessageBox.Show("Check QTY");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
