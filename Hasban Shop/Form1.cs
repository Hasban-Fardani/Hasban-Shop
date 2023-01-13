using MySql.Data.MySqlClient;

namespace Hasban_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}