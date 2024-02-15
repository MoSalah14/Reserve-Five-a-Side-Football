using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class ShowTeamsToOwner : Form
    {
        Reserve_a_Five_a_SideEntities context;
        public ShowTeamsToOwner()
        {
            context = new Reserve_a_Five_a_SideEntities();
            InitializeComponent();
        }

        private void ShowTeamsBtn_Click(object sender, EventArgs e)
        {
            var query = from team in context.Teams
                        join player1 in context.Users on team.NationalID_Player1 equals player1.NationalID
                        join player2 in context.Users on team.NationalID_Player2 equals player2.NationalID
                        join player3 in context.Users on team.NationalID_Player3 equals player3.NationalID
                        join player4 in context.Users on team.NationalID_Player4 equals player4.NationalID
                        join captain in context.Users on team.CaptainID equals captain.UserID
                        join league in context.Legaues on team.LegueID equals league.LegueID
                        select new
                        {
                            Captain_Name = captain.FName,
                            Player1_Name = string.Concat(player1.FName, " ", player1.LName),
                            Player2_Name = string.Concat(player2.FName, " ", player2.LName),
                            Player3_Name = string.Concat(player3.FName, " ", player3.LName),
                            Player4_Name = string.Concat(player4.FName, " ", player4.LName),
                            League_Name = league.Legue_Name
                        };

            foreach (var item in query)
            {
                guna2DataGridView1.Rows.Add(item.Captain_Name, item.Player1_Name, item.Player2_Name, item.Player3_Name, item.Player4_Name, item.League_Name);
            }
        }
    }
}




