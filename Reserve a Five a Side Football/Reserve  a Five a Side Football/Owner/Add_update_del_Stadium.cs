﻿using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class Add_update_del_Stadium : Form
    {
        PictureBox pic;
        DataTable data = new DataTable();
        int selectedrow;
        private Reserve_a_Five_a_SideEntities context_stadium;
        string filePath;
        //byte[] imageData;
        public Add_update_del_Stadium()
        {
            InitializeComponent();
            context_stadium = new Reserve_a_Five_a_SideEntities();
             //filePath = openFileDialog1.FileName;
          
        }

        private void getdata()
        {
            var query = from a in context_stadium.Stadium
                        select a;
            stadiumData.Rows.Clear();
            foreach (var item in query)
            {
                stadiumData.Rows.Add(
                    //item.StadiumID,
                    item.Stad_Name,
                    item.Stad_Status,
                    item.Area,
                    item.Hourly_Price
                    //item.Stadium_Image
                    );
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
                price.Text == "" ||
                state.SelectedIndex == -1 ||
                area.Text == ""|| openFileDialog1.FileName == "")
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                // data.Rows.Add(name.Text, int.Parse(price.Text), state.SelectedItem, area.Text);
                Stadium std1 = new Stadium()
                {
                    Stad_Name = name.Text,
                    Stad_Status = state.SelectedItem.ToString(),
                    Area = area.Text,
                    Hourly_Price = int.Parse(price.Text),
                   // Stadium_Image = filePath

                };
                context_stadium.Stadium.Add(std1);
                context_stadium.SaveChanges();

                
                string currentPath = System.IO.Directory.GetCurrentDirectory();

                string newpath = currentPath + "\\Photos\\" + std1.StadiumID + ".jpg";
                File.Copy(filePath, newpath);

                std1.Stadium_Image = std1.StadiumID + ".jpg";
                context_stadium.SaveChanges();
                getdata();

                name.Text = "";
                price.Text = "";
                state.Text = "";
                area.Text = "";
                filePath = "";

            }
        }

        private void Add_update_del_Stadium_Load(object sender, EventArgs e)
        {
            getdata();

        }

        private void stadiumData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = stadiumData.Rows[selectedrow];
            name.Text = row.Cells[0].Value.ToString();
            state.Text = row.Cells[1].Value.ToString();
            area.Text = row.Cells[2].Value.ToString();
            price.Text = row.Cells[3].Value.ToString();


        }

        private void updatbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
                price.Text == "" ||
                state.SelectedIndex == -1 ||
                area.Text == "" || openFileDialog1.FileName == ""
)
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataGridViewRow row = stadiumData.Rows[selectedrow];

                string _Name = row.Cells[0].FormattedValue.ToString();

                Stadium std1 = context_stadium.Stadium.Select(k => k).Where(k => k.Stad_Name == _Name).FirstOrDefault();

                std1.Stad_Name = name.Text;
                std1.Stad_Status = state.SelectedItem.ToString();
                std1.Area = area.Text;
                std1.Hourly_Price = int.Parse(price.Text);
                

                context_stadium.SaveChanges();

                getdata();

                name.Text = "";
                price.Text = "";
                state.Text = "";
                area.Text = "";
                filePath = "";
            }


        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" ||
                   price.Text == "" ||
                   state.SelectedIndex == -1 ||
                   area.Text == "" || openFileDialog1.FileName == "")
                {

                    MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var result = MessageBox.Show("Are you sure To Delete  ", "Delete Form",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                    // e.Cancel = (result == DialogResult.No);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = stadiumData.Rows[selectedrow];
                        string _Name = row.Cells[0].FormattedValue.ToString();
                        Stadium std1 = context_stadium.Stadium.Select(k => k).Where(k => k.Stad_Name == _Name).FirstOrDefault();

                        context_stadium.Stadium.Remove(std1);
                        context_stadium.SaveChanges();
                        getdata();

                        name.Text = "";
                        price.Text = "";
                        state.Text = "";
                        area.Text = "";
                        openFileDialog1.FileName = "";

                    }
                    else
                    {
                        name.Text = "";
                        price.Text = "";
                        state.Text = "";
                        area.Text = "";
                        openFileDialog1.FileName = "";

                    }


                }
            }
            catch
            {
                MessageBox.Show("Invalid Data");
            }
         }
    
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            price.Text = "";
            state.Text = "";
            area.Text = "";
            openFileDialog1.FileName = "";
        }

        private void Add_update_del_Stadium_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure To close  ", "Close Form",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void uploadimgbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            var result=openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
               filePath = openFileDialog1.FileName;
               //imageData = File.ReadAllBytes(filePath);
            }
           
        }
    }
}
