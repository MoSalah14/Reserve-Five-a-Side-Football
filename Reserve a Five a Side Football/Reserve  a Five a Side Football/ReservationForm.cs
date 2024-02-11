using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ReservationPage
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            datealarm.Visible = false;
            stadalarm.Visible = false;
            payalarm.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTime = new DateTimePicker();

            if (datebx.Value < dateTime.Value ||
                stadbx.SelectedIndex == -1 ||
                paybx.SelectedIndex == -1)
            {
                if (datebx.Value < dateTime.Value)
                {
                    datealarm.Visible = true;
                    stadalarm.Visible = false;
                    payalarm.Visible = false;
                }

                if (stadbx.SelectedIndex < 0)
                {
                    datealarm.Visible = false;
                    stadalarm.Visible = true;
                    payalarm.Visible = false;


                }
                if (paybx.SelectedIndex < 0)
                {
                    datealarm.Visible = false;
                    stadalarm.Visible = false;
                    payalarm.Visible = true;
                }
                //datealarm.Visible = false;
                //stadalarm.Visible = false;
                //payalarm.Visible = false;


                MessageBox.Show("Invalid Data", "Confirm Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                datealarm.Visible = false;
                stadalarm.Visible = false;
                payalarm.Visible = false;
                datebx.Text = "";
                stadbx.Text = "";
                paybx.Text = "";
                timebx.Text = "";
                MessageBox.Show("Sucess Confirm ", "Confirm Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Reserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
