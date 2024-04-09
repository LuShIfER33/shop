namespace shop
{
    partial class Salesitem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            ItemName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox1 = new ComboBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            textBox13 = new TextBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cash", "Credit", "Online" });
            comboBox3.Location = new Point(816, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(141, 28);
            comboBox3.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemName, Column2, Column4, Column5, Column7 });
            dataGridView1.Location = new Point(22, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(957, 277);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ItemName
            // 
            ItemName.Frozen = true;
            ItemName.HeaderText = "ItemName";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Batch no.";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Unit";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "MRP";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(4, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 90);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.FormattingEnabled = true;
            textBox1.Location = new Point(14, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 36);
            textBox1.TabIndex = 32;
            textBox1.DisplayMemberChanged += textBox1_DisplayMemberChanged;
            textBox1.FontChanged += textBox1_FontChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "1";
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(506, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(102, 33);
            comboBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(884, 46);
            button2.Name = "button2";
            button2.Size = new Size(69, 35);
            button2.TabIndex = 30;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(655, 43);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(91, 34);
            textBox13.TabIndex = 28;
            textBox13.TextChanged += textBox13_TextChanged;
            textBox13.KeyPress += textBox13_KeyPress;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(359, 42);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(91, 34);
            textBox11.TabIndex = 26;
            textBox11.KeyPress += textBox11_KeyPress;
            textBox11.Leave += textBox11_Leave;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(0, 8);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.ShortcutsEnabled = false;
            textBox9.Size = new Size(997, 31);
            textBox9.TabIndex = 0;
            textBox9.Text = "      Item name                                      Batch no.                      Quantity                        Unit                       MRP. ";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(227, 45);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(91, 34);
            textBox5.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(721, 7);
            label11.Name = "label11";
            label11.Size = new Size(89, 23);
            label11.TabIndex = 40;
            label11.Text = "Pay type :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(377, 11);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 37;
            label8.Text = "Bill NO :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(14, 6);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 36;
            label6.Text = "Today's Date :";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Enabled = false;
            textBox4.Location = new Point(141, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 27);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(833, 517);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 33;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(460, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 27);
            textBox3.TabIndex = 32;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 36;
            label1.Text = "Avilable quentity :";
            label1.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Enabled = false;
            textBox2.Location = new Point(171, 42);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(119, 27);
            textBox2.TabIndex = 35;
            textBox2.TextChanged += textBox4_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(73, 452);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(593, 108);
            dataGridView2.TabIndex = 43;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            dataGridView2.Click += dataGridView2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(306, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 44;
            label2.Text = "Buyer Name:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(436, 42);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(208, 27);
            textBox6.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 46;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(667, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 47;
            label4.Text = "Contact :";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(758, 42);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(208, 27);
            textBox7.TabIndex = 48;
            // 
            // Salesitem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1003, 575);
            Controls.Add(textBox7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(comboBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            ForeColor = SystemColors.Desktop;
            Name = "Salesitem";
            Text = "Salesitem";
            Load += Salesitem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private GroupBox groupBox1;
        private ComboBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox5;
        private Label label11;
        private Label label8;
        private Label label6;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Label label2;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private TextBox textBox7;
    }
}