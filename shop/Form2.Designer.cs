namespace shop
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox3 = new TextBox();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox9 = new TextBox();
            textBox11 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new ComboBox();
            comboBox1 = new ComboBox();
            commonDBClassBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ItemName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            commonDBClassBindingSource1 = new BindingSource(components);
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            commonDBClassBindingSource2 = new BindingSource(components);
            commonDBClassBindingSource3 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(443, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(825, 520);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.ImeMode = ImeMode.NoControl;
            dateTimePicker2.Location = new Point(684, 7);
            dateTimePicker2.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(137, 30);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2024, 4, 7, 0, 0, 0, 0);
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Enabled = false;
            textBox4.Location = new Point(133, 9);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 27);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 13;
            label6.Text = "Today's Date :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(209, 45);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(91, 34);
            textBox5.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(360, 13);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 18;
            label8.Text = "Bill NO :";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(589, 9);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 19;
            label9.Text = "Bill Date :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(32, 43);
            label10.Name = "label10";
            label10.Size = new Size(95, 23);
            label10.TabIndex = 20;
            label10.Text = "Suppliers :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(348, 43);
            label11.Name = "label11";
            label11.Size = new Size(89, 23);
            label11.TabIndex = 23;
            label11.Text = "Pay type :";
            label11.Click += label11_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(0, 8);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.ShortcutsEnabled = false;
            textBox9.Size = new Size(997, 31);
            textBox9.TabIndex = 0;
            textBox9.Text = "      Item name                  Batch no.          Exp Date             Quantity         Unit              Rate              MRP.";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(456, 45);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(91, 34);
            textBox11.TabIndex = 26;
            textBox11.TextChanged += textBox11_TextChanged;
            textBox11.KeyPress += textBox11_KeyPress;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(668, 45);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(91, 34);
            textBox13.TabIndex = 28;
            textBox13.TextChanged += textBox13_TextChanged;
            textBox13.KeyPress += textBox13_KeyPress;
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(765, 45);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(91, 34);
            textBox14.TabIndex = 29;
            textBox14.TextChanged += textBox14_TextChanged;
            textBox14.KeyPress += textBox14_KeyPress;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(884, 46);
            button2.Name = "button2";
            button2.Size = new Size(69, 35);
            button2.TabIndex = 30;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(-4, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 90);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.FormattingEnabled = true;
            textBox1.Location = new Point(16, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 36);
            textBox1.TabIndex = 32;
            textBox1.SelectedIndexChanged += textBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DataSource = commonDBClassBindingSource;
            comboBox1.DisplayMember = "1";
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(560, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(102, 33);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // commonDBClassBindingSource
            // 
            commonDBClassBindingSource.DataSource = typeof(Meropasal.CommonDBClass);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(306, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 34);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.Value = new DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemName, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(32, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(926, 335);
            dataGridView1.TabIndex = 26;
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
            // Column3
            // 
            Column3.HeaderText = "Exp Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
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
            // Column6
            // 
            Column6.HeaderText = "Rate";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "MRP";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // commonDBClassBindingSource1
            // 
            commonDBClassBindingSource1.DataSource = typeof(Meropasal.CommonDBClass);
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cash", "Credit", "Online" });
            comboBox3.Location = new Point(443, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(141, 28);
            comboBox3.TabIndex = 27;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 33);
            comboBox2.TabIndex = 30;
            // 
            // commonDBClassBindingSource2
            // 
            commonDBClassBindingSource2.DataSource = typeof(Meropasal.CommonDBClass);
            // 
            // commonDBClassBindingSource3
            // 
            commonDBClassBindingSource3.DataSource = typeof(Meropasal.CommonDBClass);
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(995, 565);
            Controls.Add(comboBox2);
            Controls.Add(comboBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            Text = "Purchase Entry";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)commonDBClassBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox9;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox14;
        private Button button2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private BindingSource commonDBClassBindingSource;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox textBox1;
        private BindingSource commonDBClassBindingSource1;
        private BindingSource commonDBClassBindingSource2;
        private BindingSource commonDBClassBindingSource3;
    }
}