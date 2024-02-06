using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace RegertrationPage
{
    public partial class Regest : Form
    {
        public Regest()
        {
            InitializeComponent();
            namealarm.Visible = true;
            emailalarm.Visible = true;
            Passalarm.Visible = true;
            idalarm.Visible = true;
        }
        /*
         1- At least one Upper case letter
         2- At least Lower case
         3- At least one Numbers
         4- Disallow the consecutive digits like 1234, 4567, etc.
         5- Disallow the consecutive alphabets like abcd, ijkl, etc.
          */

        string passwordpattern = @"^(?:(?=.*[a-z])(?:(?=.*[A-Z])(?=.*[\d\W])|(?=.*\W)(?=.*\d))|(?=.*\W)(?=.*[A-Z])(?=.*\d)).{8,}$";
        // Regex match = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        //bool isEmail = Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        string emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Uname.TextLength >= 6)
            {
                namealarm.Visible = false;
                if(Regex.IsMatch(email.Text,emailpattern))
                     emailalarm.Visible = false;
                if (Regex.IsMatch(Pass.Text,passwordpattern)&& 
                    Pass.Text == confpass.Text)
                    Passalarm.Visible = false;
                if (idnum.TextLength == 14)
                    idalarm.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void Regest_Load(object sender, EventArgs e)
        {
            //namealarm.Visible = false;
            //Passalarm.Visible = false;
            //namealarm.Hide();
            //Passalarm.Hide();
            //emailalarm.Hide();
            //idalarm.Hide();
            //acountalarm.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            email.Text = "";
            Pass.Text = "";
            confpass.Text = "";
            idnum.Text = "";
        }

        private void Passalarm_Click(object sender, EventArgs e)
        {

        }
    }
}
