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
        private readonly Reserve_a_Five_a_Side context;

        public Player_Data()
        {
            InitializeComponent();

            context = new Reserve_a_Five_a_Side();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string userIDStr = textBox1.Text;

            if (userIDStr.Length != 14)
            {
                label3.Visible = true;
                label3.Text = "ID must contain 14 digits";
               
            }

            int userID;
            if (!int.TryParse(userIDStr, out userID))
            {
                MessageBox.Show("Invalid user ID format");
               
            }

            

            var query = (from r in context.Reservations
                         join p in context.Players on r.Player_ID equals p.Player_ID
                         join x in context.Users on p.UserID equals x.UserID
                         where x.UserID == userIDStr
                         select new
                         {
                             Name = x.FName + " " + x.LName,
                             Status = r.Reservation_Statues
                         }).FirstOrDefault();

            dataGridView1.Rows.Clear();

            if (query != null)
            {
                dataGridView1.Rows.Add(query.Name, query.Status);
            }
            else
            {
                MessageBox.Show("No data exists for the entered user ID.");
            }
        }
    }}