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
    public partial class LeagueForm : Form
    {
        Reserve_a_Five_a_SideEntities DB = new Reserve_a_Five_a_SideEntities();
        public LeagueForm()
        {
            InitializeComponent();


            var specificColumnsData = DB.Legaues
        .Select(l => new
        {
            l.LegueID,
            l.Legue_Name,
            l.BeginDate,
            l.EndDate,
            l.StadiumName,
            l.EndReg,
            l.Reward,
            l.City,
            l.TimePlay
        })
        .ToList();

            LeagueGridView.DataSource = specificColumnsData;
        }

       

        private void LeagueGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // We Will Handle Open Form To Register His Team
            
        }

        private void LeagueForm_Load(object sender, EventArgs e)
        {

        }

        private void LeagueGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LeagueGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Button RegistBtn = new Button();

            // Set the Validated property to true
            RegistBtn.Visible = true;
        }

        private void LeagueGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void RegistBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
