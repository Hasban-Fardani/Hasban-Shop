using MySql.Data.MySqlClient;

namespace Hasban_Shop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mongoDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.dashboardToolStripMenuItem1,
            this.kategoriToolStripMenuItem,
            this.loginRegisterToolStripMenuItem,
            this.blogToolStripMenuItem,
            this.kuisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dashboardToolStripMenuItem.Text = "Home";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(76, 29);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.mentoringToolStripMenuItem});
            this.kategoriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.kategoriToolStripMenuItem.Text = "kategori";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webToolStripMenuItem,
            this.mobileToolStripMenuItem,
            this.desktopToolStripMenuItem});
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.softwareToolStripMenuItem.Text = "software";
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.webToolStripMenuItem.Text = "Web";
            // 
            // mobileToolStripMenuItem
            // 
            this.mobileToolStripMenuItem.Name = "mobileToolStripMenuItem";
            this.mobileToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.mobileToolStripMenuItem.Text = "Mobile";
            // 
            // desktopToolStripMenuItem
            // 
            this.desktopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.linuxToolStripMenuItem,
            this.macOSToolStripMenuItem});
            this.desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            this.desktopToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.desktopToolStripMenuItem.Text = "Desktop";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // linuxToolStripMenuItem
            // 
            this.linuxToolStripMenuItem.Name = "linuxToolStripMenuItem";
            this.linuxToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.linuxToolStripMenuItem.Text = "Linux";
            // 
            // macOSToolStripMenuItem
            // 
            this.macOSToolStripMenuItem.Name = "macOSToolStripMenuItem";
            this.macOSToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.macOSToolStripMenuItem.Text = "Mac OS";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pythonToolStripMenuItem,
            this.hTMLToolStripMenuItem,
            this.cSSToolStripMenuItem,
            this.javaScriptToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.mysqlToolStripMenuItem,
            this.mongoDbToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.courseToolStripMenuItem.Text = "course";
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.pythonToolStripMenuItem.Text = "Python";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // cSSToolStripMenuItem
            // 
            this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            this.cSSToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.cSSToolStripMenuItem.Text = "CSS";
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.javaScriptToolStripMenuItem.Text = "JavaScript";
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.pHPToolStripMenuItem.Text = "PHP";
            // 
            // mysqlToolStripMenuItem
            // 
            this.mysqlToolStripMenuItem.Name = "mysqlToolStripMenuItem";
            this.mysqlToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.mysqlToolStripMenuItem.Text = "Mysql";
            // 
            // mongoDbToolStripMenuItem
            // 
            this.mongoDbToolStripMenuItem.Name = "mongoDbToolStripMenuItem";
            this.mongoDbToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.mongoDbToolStripMenuItem.Text = "MongoDb";
            // 
            // mentoringToolStripMenuItem
            // 
            this.mentoringToolStripMenuItem.Name = "mentoringToolStripMenuItem";
            this.mentoringToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.mentoringToolStripMenuItem.Text = "mentoring";
            // 
            // loginRegisterToolStripMenuItem
            // 
            this.loginRegisterToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginRegisterToolStripMenuItem.Name = "loginRegisterToolStripMenuItem";
            this.loginRegisterToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.loginRegisterToolStripMenuItem.Text = "Login / Register";
            this.loginRegisterToolStripMenuItem.Click += new System.EventHandler(this.loginRegisterToolStripMenuItem_Click);
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(48, 29);
            this.blogToolStripMenuItem.Text = "blog";
            this.blogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // kuisToolStripMenuItem
            // 
            this.kuisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kuisToolStripMenuItem1});
            this.kuisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kuisToolStripMenuItem.Name = "kuisToolStripMenuItem";
            this.kuisToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.kuisToolStripMenuItem.Text = "Game";
            // 
            // kuisToolStripMenuItem1
            // 
            this.kuisToolStripMenuItem1.Name = "kuisToolStripMenuItem1";
            this.kuisToolStripMenuItem1.Size = new System.Drawing.Size(103, 24);
            this.kuisToolStripMenuItem1.Text = "Kuis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasban Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem kategoriToolStripMenuItem;
        private ToolStripMenuItem softwareToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem mentoringToolStripMenuItem;
        private ToolStripMenuItem pythonToolStripMenuItem;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private ToolStripMenuItem cSSToolStripMenuItem;
        private ToolStripMenuItem javaScriptToolStripMenuItem;
        private ToolStripMenuItem pHPToolStripMenuItem;
        private ToolStripMenuItem mysqlToolStripMenuItem;
        private ToolStripMenuItem mongoDbToolStripMenuItem;
        private ToolStripMenuItem loginRegisterToolStripMenuItem;
        private ToolStripMenuItem webToolStripMenuItem;
        private ToolStripMenuItem mobileToolStripMenuItem;
        private ToolStripMenuItem desktopToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem linuxToolStripMenuItem;
        private ToolStripMenuItem macOSToolStripMenuItem;
        private ToolStripMenuItem blogToolStripMenuItem;
        private ToolStripMenuItem kuisToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem kuisToolStripMenuItem1;
        private RichTextBox richTextBox1;
    }
}