using System;
using System.Windows.Forms;

namespace ReservationPage
{
    public partial class addReservationByOwner : Form
    {
        public addReservationByOwner()
        {
            InitializeComponent();
            datealarm.Visible = false;
            stadalarm.Visible = false;
            payalarm.Visible = false;
            idplayeralarm.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTime = new DateTimePicker();

            if (datebx.Value < dateTime.Value ||
                stadbx.SelectedIndex == -1 ||
                paybx.SelectedIndex == -1 ||
                playerid.Text=="")
            {
                if (datebx.Value < dateTime.Value)
                {
                    datealarm.Visible = true;
                    stadalarm.Visible = false;
                    payalarm.Visible = false;
                    idplayeralarm.Visible = false;
                }

                if (stadbx.SelectedIndex < 0)
                {
                    datealarm.Visible = false;
                    stadalarm.Visible = true;
                    payalarm.Visible = false;
                    idplayeralarm.Visible = false;

                }
                if (paybx.SelectedIndex < 0)
                {
                    datealarm.Visible = false;
                    stadalarm.Visible = false;
                    idplayeralarm.Visible = true;
                    payalarm.Visible = false;

                }
                if (playerid.Text == "")
                {
                    datealarm.Visible = false;
                    stadalarm.Visible = false;
                    payalarm.Visible = false;
                    idplayeralarm.Visible = true;

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
                idplayeralarm.Visible = false;

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
