using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasban_Shop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool canLogin = Auth.Login(this.textBox1.Text, this.textBox2.Text);
            //MessageBox.Show("can login", canLogin.ToString(), MessageBoxButtons.OK);
        }
    }
}
