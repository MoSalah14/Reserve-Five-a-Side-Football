using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class delLegue : Form
    {
        private readonly Reserve_a_Five_a_SideEntities context1 = new Reserve_a_Five_a_SideEntities();
        Reservation reservation = new Reservation();
        public delLegue()
        {
            InitializeComponent();
            show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    int reservationId = int.Parse(dataGridView1.Rows[0].Cells["ReservationID"].Value.ToString());


                    var q = context1.Reservations.FirstOrDefault(r => r.ReservationID == reservationId);


                    context1.Reservations.Remove(q);
                    context1.SaveChanges();
                    show();

                }

            }
        }
        private void show()
        {
            var y = (from r in context1.Reservations
                     select new
                     {
                         r.ReservationID,
                         r.Reservation_Date,
                         r.Reservation_Time,
                         r.Payment,
                         r.Reservation_Statues
                     }).ToList();
            dataGridView1.DataSource = y;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int reservationId = int.Parse(row.Cells["ReservationID"].Value.ToString());

                    var reservation = context1.Reservations.FirstOrDefault(r => r.ReservationID == reservationId);
                    if (reservation != null)
                    {
                        DateTime reservationDate;
                        if (DateTime.TryParse(date.Text, out reservationDate))
                        {
                            reservation.Reservation_Date = reservationDate;
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format");
                            return;
                        }

                        DateTime reservationTime;
                        if (DateTime.TryParse(time.Text, out reservationTime))
                        {
                            reservation.Reservation_Time = reservationTime.TimeOfDay;
                        }
                        else
                        {
                            MessageBox.Show("Invalid time format");
                            return;
                        }    
                            reservation.Payment = payment.Text;
                            reservation.Reservation_Statues = status.Text;
                        
                    }
                    context1.SaveChanges();
                    show();
                    date.Text = "";
                    time.Text = "";
                    payment.Text = "";
                    status.Text = "";
                }
            }
        }
    }
}










        
    


