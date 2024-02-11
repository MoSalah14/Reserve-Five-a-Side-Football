using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ReservationPage
{
    public partial class ReservationForm : Form
    {
        private Reserve_a_Five_a_SideEntities GetContext;
        public ReservationForm()
        {
            InitializeComponent();
            datealarm.Visible = false;
            stadalarm.Visible = false;
            payalarm.Visible = false;
            GetContext = new Reserve_a_Five_a_SideEntities();
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

                if (stadbx.SelectedIndex == 0)
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

                var stadiumId = GetContext.Reservations
                .Where(r => r.Stadium.Stad_Name == stadbx.SelectedItem.ToString())
                .Select(r => r.StadiumID)
                .FirstOrDefault();

                Reservation newReservation = new Reservation
                {
                    Reservation_Date = DateTime.Parse(datebx.Text),
                    Reservation_Time = TimeSpan.Parse(timebx.Text),
                    Payment = paybx.Text,
                    StadiumID = stadiumId,
                };

                GetContext.Reservations.Add(newReservation);
                GetContext.SaveChanges();


                MessageBox.Show("Success Confirm ", "Confirm Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Reserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            // Get Stadium Names
            var StadiumName = GetContext.Stadiaum.Select(et => et.Stad_Name).ToList();
            foreach (var item in StadiumName)
                stadbx.Items.Add(item);

            timebx.Format = DateTimePickerFormat.Custom;
            timebx.CustomFormat = "hh:00:00";
            timebx.ShowUpDown = true;
        }
    }
}
