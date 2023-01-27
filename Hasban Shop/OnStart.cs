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
    public partial class onStart : Form
    {
        public onStart()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Step = 5;
            this.progressBar1.Value = 0;
            timer1.Interval = 200;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.PerformStep();
            if (this.progressBar1.Value >= this.progressBar1.Maximum)
            {
                this.timer1.Stop();
                Form1 next = new Form1();
                next.Show();
                this.Close();
            }
        }
    }
}
