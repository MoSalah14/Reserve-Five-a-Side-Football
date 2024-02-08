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
        public Add_IncomeingPrice()
        {
            InitializeComponent();
        }

        private void Add_IncomeingPrice_Load(object sender, EventArgs e)
        {
            ToDatePicker.MaxDate = DateTime.Today;

            for (int i = 0; i < 10; i++)
            {
                // Create an array to hold the data for each row
                object[] rowData = new object[]
                        {
                "Name" + (i + 1),         // Name column
                i + 1 * 10,               // Price column (assuming some pattern for demonstration)
                DateTime.Now.AddDays(i), // Date column (assuming incrementing dates for demonstration)
                "Daily" + (i + 1),        // Daily column
                "Hour" + (i + 1),         // Hour column
                (i + 1) * 100             // TotalPerDay column (assuming some calculation for demonstration)
                        };

                // Add the row to the DataGridView
                dataGridView1.Rows.Add(rowData);
            }
        }
    }
}
