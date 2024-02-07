﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;


namespace RegertrationPage
{
    public partial class Regest : Form
    {
        public Regest()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {

            if (Uname.TextLength <= 6 ||
                !Regex.IsMatch(email.Text, emailpattern) ||
                !Regex.IsMatch(Pass.Text, passwordpattern) ||
                idnum.TextLength != 14)
            {

                if (Uname.TextLength <= 6)
                {
                    Uname.Text = "";
                    Uname.Focus();
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

                MessageBox.Show("Invalid Data", "Registration Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                namealarm.Visible = false;
                emailalarm.Visible = false;
                Passalarm.Visible = false;
                idalarm.Visible = false;
                Uname.Text = "";
                email.Text = "";
                Pass.Text = "";
                confpass.Text = "";
                idnum.Text = "";
                MessageBox.Show("sucess Data", "Regestration Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            email.Text = "";
            Pass.Text = "";
            confpass.Text = "";
            idnum.Text = "";
            namealarm.Visible = false;
            emailalarm.Visible = false;
            Passalarm.Visible = false;
            idalarm.Visible = false;
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regest_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
