using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Hasban_Shop
{
    public partial class Form1 : Form
    {
        //private System.ComponentModel.IContainer components = null;
        public Form1(bool isLogin = false)
        {

            InitializeComponent();
            
            if (isLogin)
            {
                this.loginRegisterToolStripMenuItem.Text = "Account";
                this.loginRegisterToolStripMenuItem.Click -= new System.EventHandler(this.loginRegisterToolStripMenuItem_Click);
                this.loginRegisterToolStripMenuItem.Click += new System.EventHandler(this.goToAccount);
            } else
            {
                this.loginRegisterToolStripMenuItem.Text = "Login / Register";
                this.loginRegisterToolStripMenuItem.Click -= new System.EventHandler(this.goToAccount);
                this.loginRegisterToolStripMenuItem.Click += new System.EventHandler(this.loginRegisterToolStripMenuItem_Click);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void loginRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Form1.ActiveForm.Hide();
            loginForm.Show();
        }
        private void goToAccount(object sender, EventArgs e)
        {
            AkunSaya form = new AkunSaya();
            form.Show();
            this.Close();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://hasban-blog.vercel.app/");
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}