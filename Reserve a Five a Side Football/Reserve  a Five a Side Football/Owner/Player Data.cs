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


            var query = (from r in context.Users


                         where r.NationalID == userIDStr
                         select new
                         {
                             Name = r.FName + " " + r.LName,
                             Status = r.AccountStatus
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}