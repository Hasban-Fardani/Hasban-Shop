namespace Hasban_Shop
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.akunSayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.blogToolStripMenuItem,
            this.kuisToolStripMenuItem,
            this.akunSayaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.blogToolStripMenuItem.Text = "Blog";
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
            // akunSayaToolStripMenuItem
            // 
            this.akunSayaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.akunSayaToolStripMenuItem.Name = "akunSayaToolStripMenuItem";
            this.akunSayaToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.akunSayaToolStripMenuItem.Text = "Akun Saya";
            this.akunSayaToolStripMenuItem.Click += new System.EventHandler(this.akunSayaToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Hasban | Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem kategoriToolStripMenuItem;
        private ToolStripMenuItem blogToolStripMenuItem;
        private ToolStripMenuItem kuisToolStripMenuItem;
        private ToolStripMenuItem akunSayaToolStripMenuItem;
        private ToolStripMenuItem kuisToolStripMenuItem1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}