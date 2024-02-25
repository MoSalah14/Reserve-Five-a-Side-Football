namespace Reserve__a_Five_a_Side_Football
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumData)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.namelabel.Location = new System.Drawing.Point(22, 415);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(77, 30);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(886, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(12, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(891, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 413);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(383, 37);
            this.name.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(986, 415);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(304, 37);
            this.price.TabIndex = 6;
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.state.Location = new System.Drawing.Point(989, 491);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(301, 38);
            this.state.TabIndex = 7;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(118, 496);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(383, 37);
            this.area.TabIndex = 8;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.addbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(547, 584);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(212, 49);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // stadiumData
            // 
            this.stadiumData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.stadiumData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stadiumData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stadiumData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stadiumData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.stadiumData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stadiumData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stadiumData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stadiumData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stadiumData.ColumnHeadersHeight = 30;
            this.stadiumData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stadname,
            this.Stadstate,
            this.stadarea,
            this.pricehour});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stadiumData.DefaultCellStyle = dataGridViewCellStyle3;
            this.stadiumData.EnableHeadersVisualStyles = false;
            this.stadiumData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.stadiumData.Location = new System.Drawing.Point(12, 12);
            this.stadiumData.Name = "stadiumData";
            this.stadiumData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stadiumData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stadiumData.RowHeadersVisible = false;
            this.stadiumData.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.stadiumData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.stadiumData.RowTemplate.Height = 39;
            this.stadiumData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stadiumData.Size = new System.Drawing.Size(1369, 316);
            this.stadiumData.TabIndex = 10;
            this.stadiumData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stadiumData_CellClick);
            // 
            // stadname
            // 
            this.stadname.HeaderText = "Stad Name";
            this.stadname.MinimumWidth = 6;
            this.stadname.Name = "stadname";
            // 
            // Stadstate
            // 
            this.Stadstate.HeaderText = "Stad Status";
            this.Stadstate.MinimumWidth = 6;
            this.Stadstate.Name = "Stadstate";
            // 
            // stadarea
            // 
            this.stadarea.HeaderText = "Area";
            this.stadarea.MinimumWidth = 6;
            this.stadarea.Name = "stadarea";
            // 
            // pricehour
            // 
            this.pricehour.HeaderText = "Hourly Price";
            this.pricehour.MinimumWidth = 6;
            this.pricehour.Name = "pricehour";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.deletebtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(1021, 578);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(224, 49);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatbtn
            // 
            this.updatbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.updatbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.updatbtn.ForeColor = System.Drawing.Color.White;
            this.updatbtn.Location = new System.Drawing.Point(547, 652);
            this.updatbtn.Name = "updatbtn";
            this.updatbtn.Size = new System.Drawing.Size(212, 49);
            this.updatbtn.TabIndex = 12;
            this.updatbtn.Text = "Update";
            this.updatbtn.UseVisualStyleBackColor = false;
            this.updatbtn.Click += new System.EventHandler(this.updatbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.Clearbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(1021, 652);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(224, 49);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // uploadimgbtn
            // 
            this.uploadimgbtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.uploadimgbtn.Location = new System.Drawing.Point(118, 609);
            this.uploadimgbtn.Name = "uploadimgbtn";
            this.uploadimgbtn.Size = new System.Drawing.Size(203, 42);
            this.uploadimgbtn.TabIndex = 14;
            this.uploadimgbtn.Text = "Choose Image";
            this.uploadimgbtn.UseVisualStyleBackColor = false;
            this.uploadimgbtn.Click += new System.EventHandler(this.uploadimgbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Photo";
            // 
            // Add_update_del_Stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
    }
}