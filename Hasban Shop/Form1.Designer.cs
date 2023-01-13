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
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.loginRegisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.mentoringToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.kategoriToolStripMenuItem.Text = "kategori";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webToolStripMenuItem,
            this.mobileToolStripMenuItem,
            this.desktopToolStripMenuItem});
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.softwareToolStripMenuItem.Text = "software";
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
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courseToolStripMenuItem.Text = "course";
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pythonToolStripMenuItem.Text = "Python";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // cSSToolStripMenuItem
            // 
            this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            this.cSSToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cSSToolStripMenuItem.Text = "CSS";
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.javaScriptToolStripMenuItem.Text = "JavaScript";
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pHPToolStripMenuItem.Text = "PHP";
            // 
            // mysqlToolStripMenuItem
            // 
            this.mysqlToolStripMenuItem.Name = "mysqlToolStripMenuItem";
            this.mysqlToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mysqlToolStripMenuItem.Text = "Mysql";
            // 
            // mongoDbToolStripMenuItem
            // 
            this.mongoDbToolStripMenuItem.Name = "mongoDbToolStripMenuItem";
            this.mongoDbToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mongoDbToolStripMenuItem.Text = "MongoDb";
            // 
            // mentoringToolStripMenuItem
            // 
            this.mentoringToolStripMenuItem.Name = "mentoringToolStripMenuItem";
            this.mentoringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentoringToolStripMenuItem.Text = "mentoring";
            // 
            // loginRegisterToolStripMenuItem
            // 
            this.loginRegisterToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginRegisterToolStripMenuItem.Name = "loginRegisterToolStripMenuItem";
            this.loginRegisterToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.loginRegisterToolStripMenuItem.Text = "Login / Register";
            this.loginRegisterToolStripMenuItem.Click += new System.EventHandler(this.loginRegisterToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.webToolStripMenuItem.Text = "Web";
            // 
            // mobileToolStripMenuItem
            // 
            this.mobileToolStripMenuItem.Name = "mobileToolStripMenuItem";
            this.mobileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mobileToolStripMenuItem.Text = "Mobile";
            // 
            // desktopToolStripMenuItem
            // 
            this.desktopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.linuxToolStripMenuItem,
            this.macOSToolStripMenuItem});
            this.desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            this.desktopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desktopToolStripMenuItem.Text = "Desktop";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // linuxToolStripMenuItem
            // 
            this.linuxToolStripMenuItem.Name = "linuxToolStripMenuItem";
            this.linuxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linuxToolStripMenuItem.Text = "Linux";
            // 
            // macOSToolStripMenuItem
            // 
            this.macOSToolStripMenuItem.Name = "macOSToolStripMenuItem";
            this.macOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.macOSToolStripMenuItem.Text = "Mac OS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hasban Shop | Dashboard";
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
    }
}