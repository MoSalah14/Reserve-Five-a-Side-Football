using System;
using System.Data;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class Add_update_del_Stadium : Form
    {

        public Add_update_del_Stadium()
        {
            InitializeComponent();


        }

        DataTable data = new DataTable();
        int selectedrow;

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
                price.Text == "" ||
                state.SelectedIndex == -1 ||
                area.Text == "")
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                data.Rows.Add(name.Text, int.Parse(price.Text), state.SelectedItem, area.Text);
                stadiumData.DataSource = data;
                name.Text = "";
                price.Text = "";
                state.Text = "";
                area.Text = "";

            }
        }

        private void Add_update_del_Stadium_Load(object sender, EventArgs e)
        {

            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("price", typeof(int));
            data.Columns.Add("State", typeof(string));
            data.Columns.Add("Area", typeof(string));

            data.Rows.Add("Stadium1", 200, "Open", "Assuit");
            data.Rows.Add("Stadium2", 100, "Open", "Assuit");
            data.Rows.Add("Stadium3", 150, "Open", "Assuit");

            stadiumData.DataSource = data;

        }

        private void stadiumData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = stadiumData.Rows[selectedrow];
            name.Text = row.Cells[0].Value.ToString();
            price.Text = row.Cells[1].Value.ToString();
            state.Text = row.Cells[2].Value.ToString();
            area.Text = row.Cells[3].Value.ToString();

        }

        private void updatbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
                price.Text == "" ||
                state.SelectedIndex == -1 ||
                area.Text == "")
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataGridViewRow row = stadiumData.Rows[selectedrow];
                row.Cells[0].Value = name.Text;
                row.Cells[1].Value = price.Text;
                row.Cells[2].Value = state.Text;
                row.Cells[3].Value = area.Text;

                name.Text = "";
                price.Text = "";
                state.Text = "";
                area.Text = "";
            }


        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
               price.Text == "" ||
               state.SelectedIndex == -1 ||
               area.Text == "")
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                stadiumData.Rows.RemoveAt(selectedrow);
                name.Text = "";
                price.Text = "";
                state.Text = "";
                area.Text = "";

            }

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            price.Text = "";
            state.Text = "";
            area.Text = "";
        }
    }
}
