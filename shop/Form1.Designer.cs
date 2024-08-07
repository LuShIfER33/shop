namespace shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            initialSetupToolStripMenuItem = new ToolStripMenuItem();
            crToolStripMenuItem = new ToolStripMenuItem();
            unitToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            entryToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            damageToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem1 = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            specificToolStripMenuItem = new ToolStripMenuItem();
            entireToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            wallpaperToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            oLDToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutSofToolStripMenuItem = new ToolStripMenuItem();
            aboutDevloperToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem2 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { initialSetupToolStripMenuItem, crToolStripMenuItem, entryToolStripMenuItem, salesToolStripMenuItem, reportToolStripMenuItem, settingsToolStripMenuItem, aboutToolStripMenuItem, logoutToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(975, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // initialSetupToolStripMenuItem
            // 
            initialSetupToolStripMenuItem.Name = "initialSetupToolStripMenuItem";
            initialSetupToolStripMenuItem.Size = new Size(104, 25);
            initialSetupToolStripMenuItem.Text = "Initial Setup";
            initialSetupToolStripMenuItem.Click += initialSetupToolStripMenuItem_Click;
            // 
            // crToolStripMenuItem
            // 
            crToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            crToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unitToolStripMenuItem, itemsToolStripMenuItem, supplierToolStripMenuItem });
            crToolStripMenuItem.Name = "crToolStripMenuItem";
            crToolStripMenuItem.Size = new Size(67, 25);
            crToolStripMenuItem.Text = "Create";
            crToolStripMenuItem.Click += crToolStripMenuItem_Click;
            // 
            // unitToolStripMenuItem
            // 
            unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            unitToolStripMenuItem.Size = new Size(145, 26);
            unitToolStripMenuItem.Text = "Unit";
            unitToolStripMenuItem.Click += unitToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(145, 26);
            itemsToolStripMenuItem.Text = "Items";
            itemsToolStripMenuItem.Click += itemsToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(145, 26);
            supplierToolStripMenuItem.Text = "Suppliers";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // entryToolStripMenuItem
            // 
            entryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, returnToolStripMenuItem, damageToolStripMenuItem });
            entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            entryToolStripMenuItem.Size = new Size(99, 25);
            entryToolStripMenuItem.Text = "Stock entry";
            entryToolStripMenuItem.Click += entryToolStripMenuItem_Click;
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(143, 26);
            purchaseToolStripMenuItem.Text = "Purchase";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(143, 26);
            returnToolStripMenuItem.Text = "Return";
            returnToolStripMenuItem.Click += returnToolStripMenuItem_Click;
            // 
            // damageToolStripMenuItem
            // 
            damageToolStripMenuItem.Name = "damageToolStripMenuItem";
            damageToolStripMenuItem.Size = new Size(143, 26);
            damageToolStripMenuItem.Text = "Damage";
            damageToolStripMenuItem.Click += damageToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemToolStripMenuItem, itemToolStripMenuItem1 });
            salesToolStripMenuItem.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            salesToolStripMenuItem.ImageTransparentColor = Color.Yellow;
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(67, 25);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(170, 26);
            itemToolStripMenuItem.Text = "Item sells";
            itemToolStripMenuItem.Click += itemToolStripMenuItem_Click;
            // 
            // itemToolStripMenuItem1
            // 
            itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            itemToolStripMenuItem1.Size = new Size(170, 26);
            itemToolStripMenuItem1.Text = "Return";
            itemToolStripMenuItem1.Click += itemToolStripMenuItem1_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { specificToolStripMenuItem, entireToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(69, 25);
            reportToolStripMenuItem.Text = "Report";
            // 
            // specificToolStripMenuItem
            // 
            specificToolStripMenuItem.Name = "specificToolStripMenuItem";
            specificToolStripMenuItem.Size = new Size(133, 26);
            specificToolStripMenuItem.Text = "Specific";
            specificToolStripMenuItem.Click += specificToolStripMenuItem_Click;
            // 
            // entireToolStripMenuItem
            // 
            entireToolStripMenuItem.Name = "entireToolStripMenuItem";
            entireToolStripMenuItem.Size = new Size(133, 26);
            entireToolStripMenuItem.Text = "Overall";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, wallpaperToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(78, 25);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(150, 26);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // wallpaperToolStripMenuItem
            // 
            wallpaperToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem, oLDToolStripMenuItem });
            wallpaperToolStripMenuItem.Name = "wallpaperToolStripMenuItem";
            wallpaperToolStripMenuItem.Size = new Size(150, 26);
            wallpaperToolStripMenuItem.Text = "Wallpaper";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(179, 26);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(179, 26);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // oLDToolStripMenuItem
            // 
            oLDToolStripMenuItem.Name = "oLDToolStripMenuItem";
            oLDToolStripMenuItem.Size = new Size(179, 26);
            oLDToolStripMenuItem.Text = "V1 wallapaper";
            oLDToolStripMenuItem.Click += oLDToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutSofToolStripMenuItem, aboutDevloperToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 25);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // aboutSofToolStripMenuItem
            // 
            aboutSofToolStripMenuItem.Name = "aboutSofToolStripMenuItem";
            aboutSofToolStripMenuItem.Size = new Size(187, 26);
            aboutSofToolStripMenuItem.Text = "About software";
            aboutSofToolStripMenuItem.Click += aboutSofToolStripMenuItem_Click;
            // 
            // aboutDevloperToolStripMenuItem
            // 
            aboutDevloperToolStripMenuItem.Name = "aboutDevloperToolStripMenuItem";
            aboutDevloperToolStripMenuItem.Size = new Size(187, 26);
            aboutDevloperToolStripMenuItem.Text = "About devloper";
            aboutDevloperToolStripMenuItem.Click += aboutDevloperToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem2
            // 
            logoutToolStripMenuItem2.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem2.Name = "logoutToolStripMenuItem2";
            logoutToolStripMenuItem2.Size = new Size(71, 25);
            logoutToolStripMenuItem2.Text = "Logout";
            logoutToolStripMenuItem2.Click += logoutToolStripMenuItem2_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 476);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(975, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "User : ";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(39, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(975, 498);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Mero Pasal";
            TransparencyKey = Color.Transparent;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutDevloperToolStripMenuItem;
        private ToolStripMenuItem aboutSofToolStripMenuItem;
        private ToolStripMenuItem initialSetupToolStripMenuItem;
        private ToolStripMenuItem crToolStripMenuItem;
        private ToolStripMenuItem unitToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem entryToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem damageToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem1;
        private ToolStripMenuItem specificToolStripMenuItem;
        private ToolStripMenuItem entireToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem2;
        private ToolStripMenuItem wallpaperToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        public ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem oLDToolStripMenuItem;
    }
}