using Reserve__a_Five_a_Side_Football;
using Reserve__a_Five_a_Side_Football.Database;
using Reserve__a_Five_a_Side_Football.Player;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ReservationPage
{
    public partial class ReservationForm : Form
    {
        private Reserve_a_Five_a_SideEntities GetContext;
        public event EventHandler<ConfirmReservationEventargs> ConfirmReservation;
        public int id;
        public ReservationForm()
        {
            InitializeComponent();
            datealarm.Visible = false;
            stadalarm.Visible = false;
            payalarm.Visible = false;
            GetContext = new Reserve_a_Five_a_SideEntities();
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            var StadiumName = GetContext.Stadium.Select(et => et.Stad_Name).ToList();
            foreach (var item in StadiumName)
                stadbx.Items.Add(item);
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
                //datebx.Text = "";
                stadbx.Text = "";
                paybx.Text = "";
                timeComboBox.Text = "";

                var stadiumId = GetContext.Reservations
                .Where(r => r.Stadium.Stad_Name == stadbx.SelectedItem.ToString())
                .Select(r => r.StadiumID)
                .FirstOrDefault();

                var x = datebx.Value.Date.ToString();

                Reservation newReservation = new Reservation
                {
                    
                    Reservation_Date = DateTime.Parse(datebx.Value.Date.ToString()),
                    Reservation_Time = TimeSpan.Parse(timeComboBox.SelectedItem.ToString()),
                    Payment = paybx.SelectedItem.ToString(),
                    StadiumID = stadiumId,
                    Reservation_Statues="Pending"
                };


                GetContext.Reservations.Add(newReservation);
                GetContext.SaveChanges();

                 id = newReservation.ReservationID;

                MessageBox.Show("Success Confirm ", "Confirm Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              if(newReservation.Payment== "Credit Card")
                {
                    PaymentWayByCreditCard paymentWayByCreditCard = new PaymentWayByCreditCard(id);
                    paymentWayByCreditCard.ShowDialog();
                }

                PaymentByWallet paymentByWallet = new PaymentByWallet(id);
                paymentByWallet.ShowDialog();

            }
        }

        private void Reserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }


        private void PopulateTimeSlots(List<TimeSpan> availableTimeslots)
        {
            timeComboBox.Items.Clear();

            // Show Data in Compo Box
            foreach (var timeSlot in availableTimeslots)
                timeComboBox.Items.Add(timeSlot.ToString("hh\\:mm"));
        }


        private void stadbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stadbx.SelectedIndex != -1 && datebx.Value != null)
            {
                // Get stadium's ID
                var stadiumId = GetContext.Stadium
                    .Where(s => s.Stad_Name == stadbx.SelectedItem.ToString())
                    .Select(s => s.StadiumID)
                    .FirstOrDefault();

                // Get  Reservations by selected Stadium and date
                var reservations = GetContext.Reservations
                    .Where(r => r.StadiumID == stadiumId && r.Reservation_Date == datebx.Value.Date).ToList();

                // Get  reserved timeslots for the selected date
                var reservedTimeslots = reservations.Select(r => r.Reservation_Time).ToList();

                // Get all available timeslots (24 hours)
                var allTimeslots = Enumerable.Range(0, 24)
                    .Select(hour => new TimeSpan(hour, 0, 0)).ToList();

                // Remove reserved timeslots from the list of all timeslots
                foreach (var reservedTime in reservedTimeslots)
                    allTimeslots.RemoveAll(time => time == reservedTime);
                
                PopulateTimeSlots(allTimeslots);
            }

        }


        //protected virtual void  OnConfirmReservation(ConfirmReservationEventargs e)
        //{
        //    ConfirmReservation?.Invoke(this, e);
        //}
    }
}
