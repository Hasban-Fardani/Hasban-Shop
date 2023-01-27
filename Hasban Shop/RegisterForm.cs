using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Hasban_Shop
{
    public partial class RegisterForm : Form
    {
        private Payload payload = new Payload();
        public RegisterForm()
        {
            InitializeComponent();

            // default payload
            payload.Status = false;
        }
        private async Task Register()
        {
            string firstName = textBox1.Text;
            string lastName = textBox5.Text;
            string username = textBox2.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;

            var url = $"https://hasban-shop-api.vercel.app/register?f_name={firstName}&l_name={lastName}&username={username}&email={email}&pwd={password}";
            var client = new HttpClient();
            if (firstName == "" || lastName == "" || username == "" || email == "" || password == "")
            {
                MessageBox.Show("data tidak boleh kosong!");
            } else
            {
                var response = await client.PostAsync(url, null);
                var resStr = await response.Content.ReadAsStringAsync();
                this.payload = JsonConvert.DeserializeObject<Payload>(resStr);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            await Register();
            loadingForm.Close();
            if (this.payload.Status)
            {
                MessageBox.Show("register success success, please login", "Register success", MessageBoxButtons.OK);
                LoginForm form = new LoginForm();
                form.Show();
            } else
            {
                MessageBox.Show("your data is not valid / already exists, please retry with new data", "Resgister Failed", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
            } else
            {  
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            RegisterForm.ActiveForm.Hide();
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            RegisterForm.ActiveForm.Hide();
            form.Show();
        }
    }
}
