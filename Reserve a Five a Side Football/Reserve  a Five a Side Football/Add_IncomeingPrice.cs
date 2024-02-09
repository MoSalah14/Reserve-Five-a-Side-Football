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
    public partial class Add_IncomeingPrice : Form
    {
        private readonly Reserve_a_Five_a_Side Context;

        public Add_IncomeingPrice()
        {
            InitializeComponent();
            Context = new Reserve_a_Five_a_Side();

        }

        private void Add_IncomeingPrice_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            ToDatePicker.MaxDate = DateTime.Today;
            
        }

        // GetStadiumNames
        private void GetStadiumsName()
        {
            var fromDate = FromDatePicker.Value;
            var ToDate = ToDatePicker.Value;
            var StadiumNames = Context.Stadium
                                .Where(s => Context.Reservations
                                            .Any(r => r.StadiumID == s.StadiumID && r.Reservation_Date >= fromDate && r.Reservation_Date <= ToDate))
                                .Select(s => s.Stad_Name)
                                .ToList();

            foreach (var stadiumName in StadiumNames)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = stadiumName;
            }

        }


        // Get StadiumsHorlyPrice
        private void GetStadiumsHorlyPrice()
        {
            var fromDate = FromDatePicker.Value;
            var ToDate = ToDatePicker.Value;
            var StadiumNames = Context.Stadium
                                .Where(s => Context.Reservations
                                            .Any(r => r.StadiumID == s.StadiumID && r.Reservation_Date >= fromDate && r.Reservation_Date <= ToDate))
                                .Select(s => s.Hourly_Price)
                                .ToList();

            int rowIndex = 0;
            foreach (var stadiumName in StadiumNames)
            {
                dataGridView1.Rows[rowIndex].Cells[1].Value = stadiumName;
                rowIndex++;
            }
        }



        private void ShowData_btn_Click(object sender, EventArgs e)
        {
            GetStadiumsName();
            GetStadiumsHorlyPrice();
        }
    }
}
