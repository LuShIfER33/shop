namespace shop
{
    partial class supplier
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
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(203, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 38);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(421, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(375, 416);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 398);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Suppliers Setup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(65, 288);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 9;
            label4.Text = "Supplier's Pan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 9;
            label3.Text = "Supplier's Pan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 9;
            label2.Text = "Supplier's Contact :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 9;
            label1.Text = "Supplier's Name :";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveBorder;
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(48, 319);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 38);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveBorder;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(203, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 38);
            textBox3.TabIndex = 8;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.InactiveCaptionText;
            button2.Location = new Point(277, 323);
            button2.Name = "button2";
            button2.Size = new Size(102, 34);
            button2.TabIndex = 5;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.InactiveCaptionText;
            button1.Location = new Point(308, 218);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 4;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(203, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 38);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "supplier";
            Text = "supplier";
            Load += supplier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private Label label4;
    }
}