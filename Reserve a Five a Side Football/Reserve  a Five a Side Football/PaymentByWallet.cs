using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class PaymentByWallet : Form
    {
        private Reserve_a_Five_a_SideEntities context;
        int getid;
        public PaymentByWallet(int _id)
        {
            InitializeComponent();
            getid = _id;
            context = new Reserve_a_Five_a_SideEntities();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (phonenum.TextLength != 11 || name.TextLength < 20)
            {
                MessageBox.Show("Invalid Data", "Confirm Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                convertreservation(getid);
                MessageBox.Show("sucess Data", "Payment Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                phonenum.Text = "";
                name.Text = "";
               
            }


        }
        public void convertreservation(int id)
        {
            var reserv = context.Reservations.Find(id);
            reserv.Reservation_Statues = "Confirmed";
            context.SaveChanges();

        }
        private void PaymentByWallet_FormClosing(object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
