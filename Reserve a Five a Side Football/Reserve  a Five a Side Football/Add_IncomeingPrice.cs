using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class Add_IncomeingPrice : Form
    {
        private readonly Reserve_a_Five_a_SideEntities Context;

        public Add_IncomeingPrice()
        {
            InitializeComponent();
            Context = new Reserve_a_Five_a_SideEntities();

        }

        private void Add_IncomeingPrice_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            ToDatePicker.MaxDate = DateTime.Today;

        }

        // GetStadiumNames
        private void GetReports()
        {
            var fromDate = FromDatePicker.Value;
            var ToDate = ToDatePicker.Value;
            var query = from s in Context.Stadiaum
                        join r in Context.Reservations on s.StadiumID equals r.StadiumID
                        where r.Reservation_Date >= fromDate && r.Reservation_Date <= ToDate
                        group new { s, r } by new { s.Stad_Name, r.Reservation_Date, s.Hourly_Price } into grp
                        select new
                        {
                            grp.Key.Stad_Name,
                            grp.Key.Reservation_Date,
                            grp.Key.Hourly_Price,
                            TotalHourlyPrice = grp.Sum(x => x.s.Hourly_Price),
                            Reservation_Count = grp.Count()
                        };

            dataGridView1.Rows.Clear();
            foreach (var item in query)
            {
                dataGridView1.Rows.Add(
                    item.Stad_Name,
                    item.Hourly_Price.ToString(),
                    item.Reservation_Date.Value.Date.ToString("yyyy-MM-dd"),
                    item.Reservation_Count,
                    item.TotalHourlyPrice.ToString()
                );
            }

        }

        private void ShowData_btn_Click(object sender, EventArgs e)
        {
            GetReports();
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalPricePerDay"].Value != null && decimal.TryParse(row.Cells["TotalPricePerDay"].Value.ToString(), out decimal price))
                    totalAmount += price;
            }
            TotalAmountTxtBox.Text = totalAmount.ToString() + " EGP";
        }

        private void TotalAmountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
