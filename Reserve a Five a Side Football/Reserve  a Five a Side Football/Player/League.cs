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
    public partial class LeagueForm : BaseForm
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

            dataGridView1.DataSource = specificColumnsData;
        }

        private void RegistBtn_Click(object sender, EventArgs e)
        {
            AddYourTeam add = new AddYourTeam();
            add.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RegistBtn.Visible = true;
        }
    }
}
