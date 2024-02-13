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
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace Reserve__a_Five_a_Side_Football
{
    public partial class delReservation : Form
    {
        private readonly Reserve_a_Five_a_SideEntities context1 = new Reserve_a_Five_a_SideEntities();
        public delReservation()
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
                         join p in context1.Players on r.Player_ID equals p.Player_ID
                         join x in context1.Users on p.UserID equals x.UserID
                         select new
                         {
                             r.ReservationID,
                             FullName = x.FName + " " + x.LName,
                             r.Reservation_Date,
                             r.Reservation_Time,
                             r.Payment,
                             r.Reservation_Statues
                         }).ToList();
                dataGridView1.DataSource = y;
            }
        }

    }  
