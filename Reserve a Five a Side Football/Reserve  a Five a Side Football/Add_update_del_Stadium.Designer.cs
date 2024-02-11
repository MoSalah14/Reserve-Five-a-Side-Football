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
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricehour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumData)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(12, 33);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(68, 25);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
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
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Photo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(88, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 31);
            this.name.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(88, 96);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(205, 31);
            this.price.TabIndex = 6;
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.state.Location = new System.Drawing.Point(375, 30);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(121, 33);
            this.state.TabIndex = 7;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(375, 93);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(205, 31);
            this.area.TabIndex = 8;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(17, 147);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(157, 49);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // stadiumData
            // 
            this.stadiumData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stadiumData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.stadname,
            this.Stadstate,
            this.stadarea,
            this.pricehour});
            this.stadiumData.Location = new System.Drawing.Point(0, 215);
            this.stadiumData.Name = "stadiumData";
            this.stadiumData.Size = new System.Drawing.Size(755, 382);
            this.stadiumData.TabIndex = 10;
            this.stadiumData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stadiumData_CellClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(375, 147);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(157, 49);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatbtn
            // 
            this.updatbtn.Location = new System.Drawing.Point(199, 147);
            this.updatbtn.Name = "updatbtn";
            this.updatbtn.Size = new System.Drawing.Size(157, 49);
            this.updatbtn.TabIndex = 12;
            this.updatbtn.Text = "Update";
            this.updatbtn.UseVisualStyleBackColor = true;
            this.updatbtn.Click += new System.EventHandler(this.updatbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(560, 147);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(157, 49);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "StadiumID";
            this.ID.Name = "ID";
            // 
            // stadname
            // 
            this.stadname.HeaderText = "Stad Name";
            this.stadname.Name = "stadname";
            // 
            // Stadstate
            // 
            this.Stadstate.HeaderText = "Stad Status";
            this.Stadstate.Name = "Stadstate";
            // 
            // stadarea
            // 
            this.stadarea.HeaderText = "Area";
            this.stadarea.Name = "stadarea";
            // 
            // pricehour
            // 
            this.pricehour.HeaderText = "Hourly Price";
            this.pricehour.Name = "pricehour";
            // 
            // Add_update_del_Stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 609);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricehour;
    }
}