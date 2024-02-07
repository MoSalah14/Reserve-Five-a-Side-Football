using System.Linq;
using System.Windows.Forms;
using System;

namespace Login_
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string email = textBox1.Text;

            if (!email.Contains('@'))
            {
                label3.Visible = true;
                label3.Text = "Email must contain @";
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string passwordPattern = "^[A-Za-z\\d@$!%*?&].{7,19}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, passwordPattern))
            {
                label4.Visible = true;
                label4.Text = "Password must contain 8 letters";
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = textBox1.Text;
            string password = textBox2.Text;


            // Check if both email and password are not empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit the method, as login is not possible with empty fields
            }
            if ((label3.Visible || label4.Visible))
            {
                MessageBox.Show("Please enter a valid data.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            MessageBox.Show("Login Done Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
