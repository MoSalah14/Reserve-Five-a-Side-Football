﻿namespace Reserve__a_Five_a_Side_Football
{
    partial class Add_update_del_Stadium
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
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.area = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.stadiumData = new System.Windows.Forms.DataGridView();
            this.stadname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricehour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.uploadimgbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumData)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(12, 72);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(68, 25);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(96, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(145, 31);
            this.name.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(96, 144);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(145, 31);
            this.price.TabIndex = 6;
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.state.Location = new System.Drawing.Point(96, 199);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(145, 33);
            this.state.TabIndex = 7;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(116, 477);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(145, 31);
            this.area.TabIndex = 8;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(616, 488);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(115, 49);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // stadiumData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.stadiumData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stadiumData.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stadiumData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stadiumData.ColumnHeadersHeight = 32;
            this.stadiumData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stadname,
            this.Stadstate,
            this.stadarea,
            this.pricehour});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stadiumData.DefaultCellStyle = dataGridViewCellStyle3;
            this.stadiumData.EnableHeadersVisualStyles = false;
            this.stadiumData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.stadiumData.Location = new System.Drawing.Point(330, 68);
            this.stadiumData.Name = "stadiumData";
            this.stadiumData.RowHeadersVisible = false;
            this.stadiumData.RowHeadersWidth = 51;
            this.stadiumData.Size = new System.Drawing.Size(603, 251);
            this.stadiumData.TabIndex = 10;
            this.stadiumData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stadiumData_CellClick);
            // 
            // stadname
            // 
            this.stadname.HeaderText = "Stad Name";
            this.stadname.MinimumWidth = 6;
            this.stadname.Name = "stadname";
            this.stadname.Width = 150;
            // 
            // Stadstate
            // 
            this.Stadstate.HeaderText = "Stad Status";
            this.Stadstate.MinimumWidth = 6;
            this.Stadstate.Name = "Stadstate";
            this.Stadstate.Width = 150;
            // 
            // stadarea
            // 
            this.stadarea.HeaderText = "Area";
            this.stadarea.MinimumWidth = 6;
            this.stadarea.Name = "stadarea";
            this.stadarea.Width = 150;
            // 
            // pricehour
            // 
            this.pricehour.HeaderText = "Hourly Price";
            this.pricehour.MinimumWidth = 6;
            this.pricehour.Name = "pricehour";
            this.pricehour.Width = 150;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(471, 488);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(116, 49);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatbtn
            // 
            this.updatbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.updatbtn.ForeColor = System.Drawing.Color.White;
            this.updatbtn.Location = new System.Drawing.Point(314, 392);
            this.updatbtn.Name = "updatbtn";
            this.updatbtn.Size = new System.Drawing.Size(116, 49);
            this.updatbtn.TabIndex = 12;
            this.updatbtn.Text = "Update";
            this.updatbtn.UseVisualStyleBackColor = false;
            this.updatbtn.Click += new System.EventHandler(this.updatbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(456, 392);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(115, 49);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // uploadimgbtn
            // 
            this.uploadimgbtn.BackColor = System.Drawing.Color.LightGray;
            this.uploadimgbtn.Location = new System.Drawing.Point(105, 269);
            this.uploadimgbtn.Name = "uploadimgbtn";
            this.uploadimgbtn.Size = new System.Drawing.Size(109, 39);
            this.uploadimgbtn.TabIndex = 14;
            this.uploadimgbtn.Text = "Choose Image";
            this.uploadimgbtn.UseVisualStyleBackColor = false;
            this.uploadimgbtn.Click += new System.EventHandler(this.uploadimgbtn_Click);
            // 
            // Add_update_del_Stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(975, 620);
            this.Controls.Add(this.uploadimgbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.updatbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.stadiumData);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.area);
            this.Controls.Add(this.state);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Add_update_del_Stadium";
            this.Text = "Add_update_del_Stadium";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_update_del_Stadium_FormClosing);
            this.Load += new System.EventHandler(this.Add_update_del_Stadium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stadiumData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView stadiumData;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricehour;
        private System.Windows.Forms.Button uploadimgbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}