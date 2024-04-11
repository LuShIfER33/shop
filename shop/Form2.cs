namespace shop
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            textBox4.Text = DateTime.Today.ToString("yyyy-MM-dd");

            textBox1.TabIndex = 1;
            textBox5.TabIndex = 2;
            dateTimePicker1.TabIndex = 3;
            textBox11.TabIndex = 4;
            comboBox1.TabIndex = 5;
            textBox13.TabIndex = 6;
            textBox14.TabIndex = 7;
            button2.TabIndex = 8;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add();

            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = textBox5.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = dateTimePicker1.Value;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = textBox11.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value = comboBox1.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[5].Value = textBox13.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value = textBox14.Text;

            textBox1.Text = "";
            textBox5.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            comboBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sls = false;
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    sls = CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries:
                                "INSERT INTO [dbo].[purchase]( Item_Name,Batch_No,Exp_Date,Quantity,Unit,Rate,MRP,Curr_Stock,Return_qty,Bill_No,Bill_Date,Entry_Date,Supplier,Pay_Type) VALUES ('"
                                + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','"
                                + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','"
                                + Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + "',"
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + ",'"
                                + dataGridView1.Rows[i].Cells[4].Value.ToString() + "',"
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) + ","
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) + ","
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + ","
                                + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + ","
                                
                                + textBox3.Text + "," + dateTimePicker2.Text + "," + textBox4.Text + ",'" + comboBox2.Text + "','" + comboBox3.Text + "')");
                    MessageBox.Show("Transaction Complete");

                    //totalcp =+ Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    //textBox6.Text=totalcp.ToString();

                    //totalsp =+ Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    //textBox2.Text=totalsp.ToString();
                }
            }
            catch (Exception ex)
            {
                if (true)
                {
                    MessageBox.Show("Successful ");
                }
                else
                {
                    MessageBox.Show(ex.Message);

                }
            }





        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries: "select Unit from dbo.Units");

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select Unit From dbo.Units");
            comboBox1.DisplayMember = "Unit";

            textBox1.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("  select Items From dbo.Items");
            textBox1.DisplayMember = "Items";

            comboBox2.DataSource = CommonHealthPostConfigClass.MainHealthPostDatabase.LoadSqlData("select SName FROM dbo.Supplier");
            comboBox2.DisplayMember = "SName";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CommonHealthPostConfigClass.MainHealthPostDatabase.ExecuteQuery(Queries: "  select Items From dbo.Items");

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
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
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
