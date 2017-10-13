namespace youtube_dl_gui
{
    partial class mainwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.Tb_URL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Download = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Main = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Location = new System.Windows.Forms.Label();
            this.ytdl_link = new System.Windows.Forms.LinkLabel();
            this.github_link = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_URL
            // 
            this.Tb_URL.Location = new System.Drawing.Point(42, 29);
            this.Tb_URL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tb_URL.Name = "Tb_URL";
            this.Tb_URL.Size = new System.Drawing.Size(218, 20);
            this.Tb_URL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL:";
            // 
            // Btn_Download
            // 
            this.Btn_Download.Location = new System.Drawing.Point(263, 29);
            this.Btn_Download.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(67, 19);
            this.Btn_Download.TabIndex = 5;
            this.Btn_Download.Text = "Download";
            this.Btn_Download.UseVisualStyleBackColor = true;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Main});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Main
            // 
            this.Menu_Main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Open});
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(50, 22);
            this.Menu_Main.Text = "Menu";
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(165, 22);
            this.Menu_Open.Text = "Open youtube-dl";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Location = new System.Drawing.Point(8, 55);
            this.Label_Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(102, 13);
            this.Label_Location.TabIndex = 7;
            this.Label_Location.Text = "youtube-dl location: ";
            // 
            // ytdl_link
            // 
            this.ytdl_link.AutoSize = true;
            this.ytdl_link.Location = new System.Drawing.Point(383, 77);
            this.ytdl_link.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytdl_link.Name = "ytdl_link";
            this.ytdl_link.Size = new System.Drawing.Size(56, 13);
            this.ytdl_link.TabIndex = 8;
            this.ytdl_link.TabStop = true;
            this.ytdl_link.Text = "youtube-dl";
            this.ytdl_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ytdl_link_LinkClicked);
            // 
            // github_link
            // 
            this.github_link.AutoSize = true;
            this.github_link.Location = new System.Drawing.Point(443, 77);
            this.github_link.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.github_link.Name = "github_link";
            this.github_link.Size = new System.Drawing.Size(36, 13);
            this.github_link.TabIndex = 9;
            this.github_link.TabStop = true;
            this.github_link.Text = "github";
            this.github_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_link_LinkClicked);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 96);
            this.Controls.Add(this.github_link);
            this.Controls.Add(this.ytdl_link);
            this.Controls.Add(this.Label_Location);
            this.Controls.Add(this.Btn_Download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_URL);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainwindow";
            this.Text = "youtube-dl-gui";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainwindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_URL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Download;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Main;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.Label Label_Location;
        private System.Windows.Forms.LinkLabel ytdl_link;
        private System.Windows.Forms.LinkLabel github_link;
    }
}

