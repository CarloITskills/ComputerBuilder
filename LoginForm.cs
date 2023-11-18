using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_website
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = "Username";
            string password = "Password";

            if(username == usernameTextBox.Text && password == passwordTextBox.Text)
            {
                this.Hide();
                Form InvoiceForm = new InvoiceForm();
                InvoiceForm.Show();
            } else
            {
                MessageBox.Show("Your username or/and password do not match with our records");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void greetingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}