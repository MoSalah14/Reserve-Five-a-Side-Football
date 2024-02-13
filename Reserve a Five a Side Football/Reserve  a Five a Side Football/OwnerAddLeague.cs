using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;


namespace Reserve__a_Five_a_Side_Football
{
    public partial class OwnerAddLeague : Form
    {
        Reserve_a_Five_a_SideEntities DB = new Reserve_a_Five_a_SideEntities();
        int id;





        public OwnerAddLeague()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            //dataGridView1.ClearSelection();

            /*dataGridView1.AutoGenerateColumns = false;
         

            // Define DataGridView columns
            dataGridView1.Columns.Add("LegueID", "Legue ID");
            dataGridView1.Columns.Add("Legue_Name", "Legue Name");
            dataGridView1.Columns.Add("BeginDate", "Begin Date");
            dataGridView1.Columns.Add("EndDate", "End Date");
            dataGridView1.Columns.Add("StadiumName", "Stadium Name");
            dataGridView1.Columns.Add("EndReg", "End Registration");
            dataGridView1.Columns.Add("Reward", "Reward");
            dataGridView1.Columns.Add("City", "City");
            dataGridView1.Columns.Add("TimePlay", "Time to Play");


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
        */
        }

        private void OwnerAddLeague_Load(object sender, EventArgs e)
        {
            // Clear the selection of the DataGridView
           

            // Call the method to populate controls when the form loads
          //  PopulateControlsFromSelectedRow();

            // TODO: This line of code loads data into the 'reserve_a_Five_a_SideDataSet.Legaue' table. You can move, or remove it, as needed.
            this.legaueTableAdapter.Fill(this.reserve_a_Five_a_SideDataSet.Legaue);
            //Clear();
            //PopulateDataGridview();
            var StadiumName = DB.Stadium.Select(et => et.Stad_Name).ToList();
            foreach (var item in StadiumName)
                StadiumNameCmb.Items.Add(item);

            var City = DB.Stadium.Select(et => et.Area).ToList();
            foreach (var item in City)
                CityCmb.Items.Add(item);

            TimePlayDate.Format = DateTimePickerFormat.Custom;
            TimePlayDate.CustomFormat = "hh:00:00";
            TimePlayDate.ShowUpDown = true;
        }
        private bool CheckForConflicts(DateTime BeginDate,DateTime EndDate, string selectedStadium, string selectedCity)
        {
            var existingLeagues = DB.Legaues
                .Where(l => l.StadiumName == selectedStadium && l.City == selectedCity &&
                            (BeginDate >= l.BeginDate && EndDate <= l.EndDate ))
                .ToList();
            return existingLeagues.Any();
        }
        private bool ValidateInput()
        {
            
            DateTime currentDate = DateTime.Today;

            if (string.IsNullOrWhiteSpace(legaueNametxt.Text) ||
                string.IsNullOrWhiteSpace(Rewardtxt.Text) ||
                StadiumNameCmb.SelectedItem == null ||
                CityCmb.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }

            // 2. Date Validation
            DateTime beginDate = BeginDate.Value.Date;
            DateTime endDate = EndDate.Value.Date;
            DateTime endRegistration = EndRegistration.Value.Date;

            if (beginDate >= endDate)
            {
                MessageBox.Show("Begin Date must be before End Date.");
                return false;
            }

            if (beginDate <= currentDate)
            {
                MessageBox.Show("Begin Date must be in the future.");
                return false;
            }
            if (endDate <= beginDate || endDate <= currentDate)
            {
                MessageBox.Show("End Date must be greater than Begin Date and in the future.");
                return false;
            }
            if (endRegistration <= beginDate || endRegistration <= currentDate|| endRegistration <= endDate )
            {
                MessageBox.Show("Registration Date must be greater than Begin Date and EndDate and the current date.");
                return false;
            }
           // DateTime selectedTime = TimePlayDate.Value.Date;
            string selectedStadium = StadiumNameCmb.SelectedItem.ToString();
            string selectedCity = CityCmb.SelectedItem.ToString();

            if (CheckForConflicts(beginDate,endDate, selectedStadium, selectedCity))
            {
                MessageBox.Show("There is a league or event scheduled at the chosen stadium and city during the selected time.");
                return false;
            }



            return true;
        }

       

        private void AddNewLegauebtn_Click(object sender, EventArgs e)
        {
          if (ValidateInput())
                {
                    Legaue legaue = new Legaue();
                var stadiumIds = DB.Stadium
                .Where(r => r.Stad_Name == StadiumNameCmb.SelectedItem.ToString())
                 .Select(r => r.StadiumID).FirstOrDefault();
            legaue.Legue_Name = legaueNametxt.Text;
            legaue.BeginDate = BeginDate.Value;
            legaue.EndDate = EndDate.Value;
            legaue.EndReg=EndRegistration.Value;
            legaue.StadiumName = StadiumNameCmb.Text;
            legaue.StadiumID = stadiumIds;
            legaue.City = CityCmb.SelectedItem.ToString();
            legaue.Reward=Rewardtxt.Text;
            legaue.TimePlay = TimeSpan.Parse(TimePlayDate.Text);



                DB.Legaues.Add(legaue);
                DB.SaveChanges();
                MessageBox.Show("DONE");
                PopulateDataGridview();
            }
           

            }


            private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var result = DB.Legaues.SingleOrDefault(x => x.LegueID == id);
                result.Legue_Name = legaueNametxt.Text;
                result.BeginDate = BeginDate.Value;
                result.EndDate = EndDate.Value;
                result.EndReg = EndRegistration.Value;
                result.StadiumName = StadiumNameCmb.Text;
                result.City = CityCmb.SelectedItem.ToString();
                result.Reward = Rewardtxt.Text;
                result.TimePlay = TimeSpan.Parse(TimePlayDate.Text);

                DB.SaveChanges();
                MessageBox.Show("Updated successfully");
                PopulateDataGridview();
            }



        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         // dataGridView1.DataSource=  DB.Legaues.Where(l => l.Legue_Name == SearchLegaueNametxt.Text).ToList();
        }

        private void SearchLegaueNametxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchLegaueNametxt.Text;
            dataGridView1.DataSource = DB.Legaues
                .Where(l => l.Legue_Name.Contains(searchText))
                .ToList();
        }

        private void SearchstadiumNametxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchstadiumNametxt.Text;
            dataGridView1.DataSource = DB.Legaues
                .Where(l => l.StadiumName.Contains(searchText))
                .ToList();

        }
        private void PopulateControlsFromSelectedRow()
        {
            if (dataGridView1.CurrentRow != null)
            {
                 id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var result = DB.Legaues.SingleOrDefault(x => x.LegueID == id);
                if (result != null)
                {
                    legaueNametxt.Text = result.Legue_Name;
                    BeginDate.Value = result.BeginDate;
                    EndDate.Value = result.EndDate;
                    EndRegistration.Value = result.EndReg;
                    StadiumNameCmb.Text = result.StadiumName;
                    //legaue.StadiumID = stadiumIds;
                    CityCmb.SelectedItem = result.City;
                    Rewardtxt.Text = result.Reward;
                    TimePlayDate.Text = result.TimePlay.ToString("hh\\:mm");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = DB.Legaues.Find(id);

                if (result != null)
                {
                    DB.Legaues.Remove(result);
                    DB.SaveChanges();
                    MessageBox.Show("Delete Done");
                    PopulateDataGridview();
                }
                else
                {
                    MessageBox.Show("No such entity exists to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PopulateControlsFromSelectedRow();

        }
        private void PopulateDataGridview()
        {
            dataGridView1.DataSource = null; // Clear the current data source
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
    }
}
