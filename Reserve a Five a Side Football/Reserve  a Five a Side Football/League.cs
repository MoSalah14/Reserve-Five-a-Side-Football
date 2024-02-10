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
        public LeagueForm()
        {
            InitializeComponent();
            AddData();
        }

        public void AddData()
        {
            LeagueGridView.Rows.Add("League 1", "City A", DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"), DateTime.Now.AddDays(30).ToString("yyyy-MM-dd"), "9:00 AM", 100 + "EGP");
            LeagueGridView.Rows.Add("League 2", "City B", DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"), DateTime.Now.AddDays(45).ToString("yyyy-MM-dd"), "3:00 PM", 200 + " EGP");
            LeagueGridView.Rows.Add("League 3", "City C", DateTime.Now.AddDays(21).ToString("yyyy-MM-dd"), DateTime.Now.AddDays(60).ToString("yyyy-MM-dd"), "6:00 PM", 300 + " EGP");

        }

        private void LeagueGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // We Will Handle Open Form To Register His Team
            MessageBox.Show("Hello");
        }

        private void LeagueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
