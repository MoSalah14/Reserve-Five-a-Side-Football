using ReservationPage;
using Reserve__a_Five_a_Side_Football.Database;
using Reserve__a_Five_a_Side_Football.Player;
using System;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class PaymentWayByCreditCard : Form
    {
        private Reserve_a_Five_a_SideEntities context;
        int getid;
        public PaymentWayByCreditCard(int _id)
        {
            getid=_id;
            InitializeComponent();
            context = new Reserve_a_Five_a_SideEntities();
        }
        private void confirmbtn_Click(object sender, EventArgs e)
        {        
            if(cardnum.TextLength!=16 ||name.TextLength<20
                ||date.TextLength!=5 || cvc.TextLength != 3)
            {
                MessageBox.Show("Invalid Data", "Confirm Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                convertreservation(getid);
                MessageBox.Show("sucess Data", "Payment Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cardnum.Text = "";
                name.Text = "";
                date.Text = "";
                cvc.Text = "";
            }

        }
        public void convertreservation(int id)
        {
            var reserv = context.Reservations.Find(id);
            reserv.Reservation_Statues = "Confirmed";
            context.SaveChanges();
           
        }

        private void PaymentWayByCreditCard_FormClosing(object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
