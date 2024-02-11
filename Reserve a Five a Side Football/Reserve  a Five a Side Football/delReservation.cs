using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reserve__a_Five_a_Side_Football
{
    public partial class delReservation : Form
    {
      private readonly Reserve_a_Five_a_SideEntities context1;
        public delReservation()
        {
            InitializeComponent();
            context1 = new Reserve_a_Five_a_SideEntities();
        }




        

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void del_Reservation_Load(object sender, EventArgs e)
        {

            var query = (from r in context1.Reservations
                         join p in context1.Players on r.Player_ID equals p.Player_ID
                         join x in context1.Users on p.UserID equals x.UserID
                         select new
                         {
                             FullName = x.FName + " " + x.LName,
                             r.Reservation_Date,
                             r.Reservation_Time,
                             r.Payment
                         });

            foreach (var item in query)
            {
                dataGridView1.Rows.Add(item.FullName, item.Reservation_Date.Value.Date.ToString("yyyy-MM-dd"), item.Reservation_Time.ToString(), item.Payment);
            }
        }
    }

}