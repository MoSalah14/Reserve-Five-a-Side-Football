using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class delLegue : Form
    {
        private readonly Reserve_a_Five_a_SideEntities context1;
        public delLegue()
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

        private void delLegue_Load(object sender, EventArgs e)
        {

            var query = (from r in context1.Reservations
                         join p in context1.Players on r.Player_ID equals p.Player_ID
                         join x in context1.Users on p.UserID equals x.UserID
                         join z in context1.Legaues on r.StadiumID equals z.StadiumID

                         select new
                         {
                             FullName = x.FName + " " + x.LName,
                             z.Legue_Name,
                             z.StadiumName,
                             z.Reward,
                             z.BeginDate, 
                             z.EndDate,
                             z.TimePlay


                         });

            foreach (var item in query)
            {
                dataGridView1.Rows.Add(item.FullName,item.Legue_Name,item.StadiumName,item.BeginDate.Date.ToString("yyyy-MM-dd"), item.EndDate.Date.ToString("yyyy-MM-dd"), item.TimePlay, item.Reward);
            }
        }
    }
}
