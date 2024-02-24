using Login_;
using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegertrationPage
{
    public partial class Regest : Form
    {

        private Reserve_a_Five_a_SideEntities _a_Five_a_Side;
        public Regest()
        {
            InitializeComponent();
            _a_Five_a_Side = new Reserve_a_Five_a_SideEntities();
            namealarm.Visible = false;
            emailalarm.Visible = false;
            Passalarm.Visible = false;
            idalarm.Visible = false;
        }
        /*
         * -- Password Pattern 
         1- At least one Upper case letter
         2- At least Lower case
         3- At least one Numbers
         4- Disallow the consecutive digits like 1234, 4567, etc.
         5- Disallow the consecutive alphabets like abcd, ijkl, etc.
          */

        string passwordpattern = @"^(?:(?=.*[a-z])(?:(?=.*[A-Z])(?=.*[\d\W])|(?=.*\W)(?=.*\d))|(?=.*\W)(?=.*[A-Z])(?=.*\d)).{8,}$";
        string emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                Pass.PasswordChar = '\0';
                confpass.PasswordChar = '\0';
            }
            else
            {
                Pass.PasswordChar = '*';
                confpass.PasswordChar = '*';
            }
        }



        private void Regest_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void Regsterbtn_Click(object sender, EventArgs e)
        {

            if (Fname.Text == "" ||
                Lname.Text == "" ||
                !Regex.IsMatch(email.Text, emailpattern) ||
                !Regex.IsMatch(Pass.Text, passwordpattern) ||
            idnum.TextLength != 14)
            {

                if (Fname.Text == "" || Lname.Text == "")
                {
                    Fname.Text = "";
                    Lname.Text = "";
                    Fname.Focus();
                    namealarm.Visible = true;
                    emailalarm.Visible = false;
                    Passalarm.Visible = false;
                    idalarm.Visible = false;
                }
                if (!Regex.IsMatch(email.Text, emailpattern))
                {
                    email.Text = "";
                    namealarm.Visible = false;
                    emailalarm.Visible = true;
                    Passalarm.Visible = false;
                    idalarm.Visible = false;

                }
                if (!Regex.IsMatch(Pass.Text, passwordpattern) &&
                      Pass.Text != confpass.Text)
                {
                    Pass.Text = "";
                    confpass.Text = "";
                    Pass.Focus();
                    namealarm.Visible = false;
                    emailalarm.Visible = false;
                    Passalarm.Visible = true;
                    idalarm.Visible = false;
                }
                if (idnum.TextLength != 14)
                {
                    idnum.Text = "";
                    idnum.Focus();
                    namealarm.Visible = false;
                    emailalarm.Visible = false;
                    Passalarm.Visible = false;
                    idalarm.Visible = true;
                }



                RegFaildLbl.Visible = true;

            }
            else
            {

                User newUser = new User
                {
                    FName = Fname.Text,
                    LName = Lname.Text,
                    Email = email.Text,
                    Password = Pass.Text,
                    NationalID = idnum.Text,
                    AccountStatus = true

                };

                _a_Five_a_Side.Users.Add(newUser);
                _a_Five_a_Side.SaveChanges();



                namealarm.Visible = false;
                emailalarm.Visible = false;
                Passalarm.Visible = false;
                idalarm.Visible = false;
                Fname.Text = "";
                Lname.Text = "";
                email.Text = "";
                Pass.Text = "";
                confpass.Text = "";
                idnum.Text = "";

                MessageBox.Show("sucess Data", "Regestration Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login_Form login_ = new Login_Form();
                login_.ShowDialog();
                this.Close();
            }
        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.ShowDialog();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Fname.Text = "";
            Lname.Text = "";
            email.Text = "";
            Pass.Text = "";
            confpass.Text = "";
            idnum.Text = "";
            namealarm.Visible = false;
            emailalarm.Visible = false;
            Passalarm.Visible = false;
            idalarm.Visible = false;
        }
    }
}
