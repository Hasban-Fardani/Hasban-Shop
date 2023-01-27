using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hasban_Shop
{
    public partial class LoginForm : Form
    {
        private bool is_login = false;
        private Payload payload = new Payload();
        public LoginForm()
        {
            InitializeComponent();
            this.payload.Status = false;
        }
        private async Task Login()
        {
            var url = $"https://hasban-shop-api.vercel.app/login?username={this.textBox1.Text}&pwd={this.textBox2.Text}";
            if (this.textBox1.Text.Contains("@"))
            {
                url = $"https://hasban-shop-api.vercel.app/login?email={this.textBox1.Text}&pwd={this.textBox2.Text}";
            }
            var client = new HttpClient();

            var response = await client.PostAsync(url, null);
            var resStr = await response.Content.ReadAsStringAsync();
            this.payload = JsonConvert.DeserializeObject<Payload>(resStr);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            await Login();
            loadingForm.Close();
            if (this.payload.Status)
            {
                MessageBox.Show("login success", "status", MessageBoxButtons.OK);
                Dashboard form = new Dashboard();
                form.Show();
                this.Close();
            } else
            {
                MessageBox.Show("login failed | " + payload.Message + " please retry", "status", MessageBoxButtons.OK);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            } else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
