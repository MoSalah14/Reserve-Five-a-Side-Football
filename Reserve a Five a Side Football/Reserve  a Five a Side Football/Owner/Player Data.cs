using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reserve__a_Five_a_Side_Football
{
    public partial class Player_Data : Form
    {
        private readonly Reserve_a_Five_a_SideEntities context;

        public Player_Data()
        {
            InitializeComponent();

            context = new Reserve_a_Five_a_SideEntities();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string userIDStr = textBox1.Text;

            if (userIDStr.Length != 14)
            {
                label3.Visible = true;
                label3.Text = "ID must contain 14 digits";

            }

            //var query = context.Users
            //.Join(context.Reservations, r => r.UserID, s => s.Player_ID, (r, s) => new { r, s })
            //.Join(context.Stadium, rs => rs.s.StadiumID, t => t.StadiumID, (rs, t) => new { rs.r, rs.s, t })
            //.Where(result => result.r.NationalID == userIDStr)
            //.Select(result => new
            //{
            //    Name = result.r.FName + " " + result.r.LName,
            //    Status = result.r.AccountStatus,
            //    mail = result.r.Email,
            //    Reserv_Date = result.s.Reservation_Date,
            //    stad_name = result.t.Stad_Name
            //}).FirstOrDefault();


            //var query = (from r in context.Users


            //             where r.NationalID == userIDStr
            //             select new
            //             {
            //                 Name = r.FName + " " + r.LName,
            //                 Status = r.AccountStatus,
            //                 email=r.Email

            //             }).FirstOrDefault();




            var query = (from r in context.Users /*where(r.NationalID == userIDStr)*/
                         join s in context.Reservations on r.UserID equals s.Player_ID
                         join t in context.Stadium on s.StadiumID equals t.StadiumID
                         where (r.NationalID == userIDStr)
                         select new
                         {
                             Name = r.FName + " " + r.LName,
                             Status = r.AccountStatus,
                             mail = r.Email,
                             Reserv_Date = s.Reservation_Date,
                             time =s.Reservation_Time,
                             stadname = t.Stad_Name

                         }).FirstOrDefault();

            dataGridView1.Rows.Clear();

            if (query != null)
            {
                dataGridView1.Rows.Add(query.Name, query.mail,query.Status,query.Reserv_Date,query.time,query.stadname);
            }
            else
            {
                MessageBox.Show("No data exists for the entered user ID.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}