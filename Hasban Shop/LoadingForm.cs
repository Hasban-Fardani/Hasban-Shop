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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Step = 10;
            this.progressBar1.Value = 0;
            for (int i = 0; i <= 100; i++)
            {
                this.progressBar1.Value = i;
            }
            Form1 form = new Form1();
            form.Show();
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
