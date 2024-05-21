
namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string imagePath = @"E:\project\shop\Resources\dbg.png";
            this.BackgroundImage = Image.FromFile(imagePath);
            // toolStripStatusLabel1.Text = textFromHere;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void puToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutDevloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Sulav Sapkota , Sonu Acharya & Suikrit Thapa");
        }

        private void initialSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.MdiParent = this;
            Form2.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PurchaseReturn = new PurchaseReturn();
            PurchaseReturn.MdiParent = this;
            PurchaseReturn.Show();
        }

        private void damageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var damageNR = new DamageNR();
            damageNR.MdiParent = this;
            damageNR.Show();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unit = new unit();
            unit.MdiParent = this;
            unit.Show();

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var items = new items();
            items.MdiParent = this;
            items.Show();




        }

        private void crToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salesitem = new Salesitem();
            salesitem.MdiParent = this;
            salesitem.Show();


        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Return = new Return();
            Return.MdiParent = this;
            Return.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var supplier = new supplier();
            supplier.MdiParent = this;
            supplier.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createuser = new createuser();
            createuser.MdiParent = this;
            createuser.Show();
        }

        private void logoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Sure you want to logout ? ", " Bye Bye See you ! ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var UserAuthentication = new UserAuthentication();
                this.Hide();

                UserAuthentication.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();

            }


        }

        private void aboutSofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mero Pasal online billing system revolutionizes retail operations by offering a comprehensive platform for managing invoices, inventory, and transactions seamlessly. Tailored for small businesses, it streamlines billing processes, reduces errors, and enhances efficiency. With user-friendly interfaces and customizable features, it empowers users to create, send, and track invoices effortlessly. Integrated inventory management ensures optimal stock levels, preventing shortages and improving customer satisfaction. The system's secure payment processing and real-time reporting capabilities provide valuable insights for informed decision-making. \"Mero Pasal\" sets a new standard in online billing systems, driving growth and success for small retailers in today's competitive market landscape.");
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string imagePath = @"E:\project\shop\Resources\dbg.png";
            this.BackgroundImage = Image.FromFile(imagePath);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string imagePath = @"E:\project\shop\Resources\lbg.png";
            this.BackgroundImage = Image.FromFile(imagePath);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void oLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string imagePath = @"E:\project\shop\Resources\bg.jpg";
            this.BackgroundImage = Image.FromFile(imagePath);
        }

        private void specificToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}