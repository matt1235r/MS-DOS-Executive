namespace MS_DOS_Executuve
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDirecotryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatDataDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSystemDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVolumeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MSDOSpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.folderView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MSDOSpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.specialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(853, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // specialToolStripMenuItem
            // 
            this.specialToolStripMenuItem.CheckOnClick = true;
            this.specialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endSessionToolStripMenuItem,
            this.createDirecotryToolStripMenuItem,
            this.changeDirectoryToolStripMenuItem,
            this.formatDataDiskToolStripMenuItem,
            this.makeSystemDiskToolStripMenuItem,
            this.setVolumeNameToolStripMenuItem});
            this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
            this.specialToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.specialToolStripMenuItem.Text = "Special";
            // 
            // endSessionToolStripMenuItem
            // 
            this.endSessionToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.endSessionToolStripMenuItem.Name = "endSessionToolStripMenuItem";
            this.endSessionToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.endSessionToolStripMenuItem.Text = "End Session";
            this.endSessionToolStripMenuItem.Click += new System.EventHandler(this.endSessionToolStripMenuItem_Click);
            // 
            // createDirecotryToolStripMenuItem
            // 
            this.createDirecotryToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.createDirecotryToolStripMenuItem.Name = "createDirecotryToolStripMenuItem";
            this.createDirecotryToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.createDirecotryToolStripMenuItem.Text = "Create Directory ...";
            this.createDirecotryToolStripMenuItem.Click += new System.EventHandler(this.createDirecotryToolStripMenuItem_Click);
            // 
            // changeDirectoryToolStripMenuItem
            // 
            this.changeDirectoryToolStripMenuItem.Name = "changeDirectoryToolStripMenuItem";
            this.changeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.changeDirectoryToolStripMenuItem.Text = "Change Directory ...";
            // 
            // formatDataDiskToolStripMenuItem
            // 
            this.formatDataDiskToolStripMenuItem.Name = "formatDataDiskToolStripMenuItem";
            this.formatDataDiskToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.formatDataDiskToolStripMenuItem.Text = "Format Data Disk ...";
            // 
            // makeSystemDiskToolStripMenuItem
            // 
            this.makeSystemDiskToolStripMenuItem.Name = "makeSystemDiskToolStripMenuItem";
            this.makeSystemDiskToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.makeSystemDiskToolStripMenuItem.Text = "Make System Disk ...";
            // 
            // setVolumeNameToolStripMenuItem
            // 
            this.setVolumeNameToolStripMenuItem.Name = "setVolumeNameToolStripMenuItem";
            this.setVolumeNameToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.setVolumeNameToolStripMenuItem.Text = "Set Volume Name ...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.MSDOSpanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 55);
            this.panel1.TabIndex = 2;
            // 
            // MSDOSpanel
            // 
            this.MSDOSpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MSDOSpanel.BackColor = System.Drawing.Color.Black;
            this.MSDOSpanel.Controls.Add(this.label1);
            this.MSDOSpanel.Location = new System.Drawing.Point(325, 0);
            this.MSDOSpanel.MinimumSize = new System.Drawing.Size(173, 30);
            this.MSDOSpanel.Name = "MSDOSpanel";
            this.MSDOSpanel.Size = new System.Drawing.Size(203, 30);
            this.MSDOSpanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "MS-DOS Executive ++";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(418, 58);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(202, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // folderView
            // 
            this.folderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderView.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderView.HideSelection = false;
            this.folderView.LabelWrap = false;
            this.folderView.Location = new System.Drawing.Point(12, 96);
            this.folderView.Name = "folderView";
            this.folderView.Size = new System.Drawing.Size(829, 238);
            this.folderView.TabIndex = 6;
            this.folderView.UseCompatibleStateImageBehavior = false;
            this.folderView.View = System.Windows.Forms.View.List;
            this.folderView.DoubleClick += new System.EventHandler(this.folderView_DoubleClick);
            this.folderView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.folderView_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 346);
            this.Controls.Add(this.folderView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MS-DOS Executive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MSDOSpanel.ResumeLayout(false);
            this.MSDOSpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MSDOSpanel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ListView folderView;
        private System.Windows.Forms.ToolStripMenuItem createDirecotryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatDataDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSystemDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setVolumeNameToolStripMenuItem;
    }
}

