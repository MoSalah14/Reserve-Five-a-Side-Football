﻿namespace Reserve__a_Five_a_Side_Football.Owner
{
    partial class ShowAllRevToOwner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StadiunComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CityComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FromDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ToDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SelectCitylbl = new System.Windows.Forms.Label();
            this.SelectStadiumlbl = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowSelectedbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StadiunComboBox1
            // 
            this.StadiunComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.StadiunComboBox1.BorderRadius = 15;
            this.StadiunComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StadiunComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StadiunComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StadiunComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StadiunComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StadiunComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StadiunComboBox1.ItemHeight = 30;
            this.StadiunComboBox1.Location = new System.Drawing.Point(544, 46);
            this.StadiunComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.StadiunComboBox1.Name = "StadiunComboBox1";
            this.StadiunComboBox1.Size = new System.Drawing.Size(215, 36);
            this.StadiunComboBox1.TabIndex = 2;
            // 
            // CityComboBox1
            // 
            this.CityComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.CityComboBox1.BorderRadius = 10;
            this.CityComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CityComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CityComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CityComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CityComboBox1.ItemHeight = 30;
            this.CityComboBox1.Location = new System.Drawing.Point(111, 46);
            this.CityComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.CityComboBox1.Name = "CityComboBox1";
            this.CityComboBox1.Size = new System.Drawing.Size(196, 36);
            this.CityComboBox1.TabIndex = 3;
            this.CityComboBox1.SelectedIndexChanged += new System.EventHandler(this.CityComboBox1_SelectedIndexChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.BorderColor = System.Drawing.Color.White;
            this.FromDateTimePicker.Checked = true;
            this.FromDateTimePicker.FillColor = System.Drawing.Color.WhiteSmoke;
            this.FromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateTimePicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDateTimePicker.Location = new System.Drawing.Point(112, 110);
            this.FromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FromDateTimePicker.MaxDate = new System.DateTime(2024, 2, 18, 0, 0, 0, 0);
            this.FromDateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(195, 38);
            this.FromDateTimePicker.TabIndex = 4;
            this.FromDateTimePicker.Value = new System.DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.ToDateTimePicker.BorderColor = System.Drawing.Color.Transparent;
            this.ToDateTimePicker.Checked = true;
            this.ToDateTimePicker.FillColor = System.Drawing.Color.White;
            this.ToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDateTimePicker.Location = new System.Drawing.Point(544, 110);
            this.ToDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ToDateTimePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.ToDateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(215, 38);
            this.ToDateTimePicker.TabIndex = 5;
            this.ToDateTimePicker.Value = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            // 
            // SelectCitylbl
            // 
            this.SelectCitylbl.AutoSize = true;
            this.SelectCitylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCitylbl.Location = new System.Drawing.Point(11, 55);
            this.SelectCitylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectCitylbl.Name = "SelectCitylbl";
            this.SelectCitylbl.Size = new System.Drawing.Size(85, 17);
            this.SelectCitylbl.TabIndex = 6;
            this.SelectCitylbl.Text = "Select City";
            // 
            // SelectStadiumlbl
            // 
            this.SelectStadiumlbl.AutoSize = true;
            this.SelectStadiumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectStadiumlbl.Location = new System.Drawing.Point(404, 55);
            this.SelectStadiumlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectStadiumlbl.Name = "SelectStadiumlbl";
            this.SelectStadiumlbl.Size = new System.Drawing.Size(116, 17);
            this.SelectStadiumlbl.TabIndex = 7;
            this.SelectStadiumlbl.Text = "Select Stadium";
            this.SelectStadiumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.AutoSize = true;
            this.fromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Location = new System.Drawing.Point(29, 123);
            this.fromDatePicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(44, 17);
            this.fromDatePicker.TabIndex = 8;
            this.fromDatePicker.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "To";
            // 
            // ShowSelectedbtn
            // 
            this.ShowSelectedbtn.BorderRadius = 15;
            this.ShowSelectedbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowSelectedbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowSelectedbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowSelectedbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowSelectedbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.ShowSelectedbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowSelectedbtn.ForeColor = System.Drawing.Color.White;
            this.ShowSelectedbtn.Location = new System.Drawing.Point(826, 78);
            this.ShowSelectedbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowSelectedbtn.Name = "ShowSelectedbtn";
            this.ShowSelectedbtn.Size = new System.Drawing.Size(118, 45);
            this.ShowSelectedbtn.TabIndex = 10;
            this.ShowSelectedbtn.Text = "Show Result";
            this.ShowSelectedbtn.Click += new System.EventHandler(this.ShowSelectedbtn_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 36;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NationalID,
            this.FullName,
            this.City,
            this.StadiumName,
            this.ReservationDate,
            this.ReservationTime,
            this.Payment,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(101, 187);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(744, 325);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // ReservationTime
            // 
            this.ReservationTime.HeaderText = "Reservation Time";
            this.ReservationTime.MinimumWidth = 6;
            this.ReservationTime.Name = "ReservationTime";
            this.ReservationTime.ReadOnly = true;
            // 
            // ReservationDate
            // 
            this.ReservationDate.HeaderText = "Reservation Date";
            this.ReservationDate.MinimumWidth = 6;
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.ReadOnly = true;
            // 
            // StadiumName
            // 
            this.StadiumName.HeaderText = "Stadium Name";
            this.StadiumName.MinimumWidth = 6;
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // NationalID
            // 
            this.NationalID.HeaderText = "National ID";
            this.NationalID.MinimumWidth = 6;
            this.NationalID.Name = "NationalID";
            this.NationalID.ReadOnly = true;
            // 
            // ShowAllRevToOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(965, 533);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.ShowSelectedbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.SelectStadiumlbl);
            this.Controls.Add(this.SelectCitylbl);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.CityComboBox1);
            this.Controls.Add(this.StadiunComboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowAllRevToOwner";
            this.Text = "Show All Reservation To Owner";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox StadiunComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CityComboBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Label SelectCitylbl;
        private System.Windows.Forms.Label SelectStadiumlbl;
        private System.Windows.Forms.Label fromDatePicker;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ShowSelectedbtn;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}