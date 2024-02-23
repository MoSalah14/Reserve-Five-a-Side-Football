namespace Reserve__a_Five_a_Side_Football
{
    partial class LeagueForm
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
            this.RegistBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LegueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePlay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistBtn
            // 
            this.RegistBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.RegistBtn.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic);
            this.RegistBtn.ForeColor = System.Drawing.Color.White;
            this.RegistBtn.Location = new System.Drawing.Point(302, 366);
            this.RegistBtn.Name = "RegistBtn";
            this.RegistBtn.Size = new System.Drawing.Size(399, 83);
            this.RegistBtn.TabIndex = 2;
            this.RegistBtn.Text = "RegisterationForThisLegaue";
            this.RegistBtn.UseVisualStyleBackColor = false;
            this.RegistBtn.Visible = false;
            this.RegistBtn.Click += new System.EventHandler(this.RegistBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LegueID,
            this.LegueName,
            this.BeginDate,
            this.EndDate,
            this.StadiumName,
            this.EndReg,
            this.Reward,
            this.City,
            this.TimePlay});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(39, 68);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(902, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // LegueID
            // 
            this.LegueID.HeaderText = "LegueID";
            this.LegueID.Name = "LegueID";
            this.LegueID.ReadOnly = true;
            // 
            // LegueName
            // 
            this.LegueName.HeaderText = "LegueName";
            this.LegueName.Name = "LegueName";
            this.LegueName.ReadOnly = true;
            // 
            // BeginDate
            // 
            this.BeginDate.HeaderText = "BeginDate";
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // StadiumName
            // 
            this.StadiumName.HeaderText = "StadiumName";
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.ReadOnly = true;
            // 
            // EndReg
            // 
            this.EndReg.HeaderText = "EndReg";
            this.EndReg.Name = "EndReg";
            this.EndReg.ReadOnly = true;
            // 
            // Reward
            // 
            this.Reward.HeaderText = "Reward";
            this.Reward.Name = "Reward";
            this.Reward.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // TimePlay
            // 
            this.TimePlay.HeaderText = "TimePlay";
            this.TimePlay.Name = "TimePlay";
            this.TimePlay.ReadOnly = true;
            // 
            // LeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RegistBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LeagueForm";
            this.Text = "League";
            this.Load += new System.EventHandler(this.LeagueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegistBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reward;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePlay;
    }
}