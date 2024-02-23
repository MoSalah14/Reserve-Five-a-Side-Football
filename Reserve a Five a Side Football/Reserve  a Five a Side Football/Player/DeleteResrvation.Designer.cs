namespace Reserve__a_Five_a_Side_Football
{
    partial class DeleteResrvation
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rev_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserv_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserv_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserv_Statue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservasionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation For Player";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RevID,
            this.ReservationDate,
            this.ReservationTime,
            this.StadiumName,
            this.Payment1,
            this.ReservasionStatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(817, 181);
            this.dataGridView1.TabIndex = 3;
            // 
            // Rev_ID
            // 
            this.Rev_ID.HeaderText = "Rev_ID";
            this.Rev_ID.MinimumWidth = 6;
            this.Rev_ID.Name = "Rev_ID";
            this.Rev_ID.ReadOnly = true;
            this.Rev_ID.Visible = false;
            this.Rev_ID.Width = 125;
            // 
            // Reserv_Date
            // 
            this.Reserv_Date.HeaderText = "Reservation Date";
            this.Reserv_Date.MinimumWidth = 6;
            this.Reserv_Date.Name = "Reserv_Date";
            this.Reserv_Date.ReadOnly = true;
            this.Reserv_Date.Width = 125;
            // 
            // Reserv_Time
            // 
            this.Reserv_Time.HeaderText = "Reservation Time";
            this.Reserv_Time.MinimumWidth = 6;
            this.Reserv_Time.Name = "Reserv_Time";
            this.Reserv_Time.ReadOnly = true;
            this.Reserv_Time.Width = 125;
            // 
            // Stadium_Name
            // 
            this.Stadium_Name.HeaderText = "Stadium Name";
            this.Stadium_Name.MinimumWidth = 6;
            this.Stadium_Name.Name = "Stadium_Name";
            this.Stadium_Name.ReadOnly = true;
            this.Stadium_Name.Width = 125;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 125;
            // 
            // Reserv_Statue
            // 
            this.Reserv_Statue.HeaderText = "Reservation Statue";
            this.Reserv_Statue.MinimumWidth = 6;
            this.Reserv_Statue.Name = "Reserv_Statue";
            this.Reserv_Statue.ReadOnly = true;
            this.Reserv_Statue.Width = 125;
            // 
            // RevID
            // 
            this.RevID.HeaderText = "RevID";
            this.RevID.MinimumWidth = 6;
            this.RevID.Name = "RevID";
            this.RevID.ReadOnly = true;
            this.RevID.Visible = false;
            // 
            // ReservationDate
            // 
            this.ReservationDate.HeaderText = " Date";
            this.ReservationDate.MinimumWidth = 6;
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.ReadOnly = true;
            // 
            // ReservationTime
            // 
            this.ReservationTime.HeaderText = " Time";
            this.ReservationTime.MinimumWidth = 6;
            this.ReservationTime.Name = "ReservationTime";
            this.ReservationTime.ReadOnly = true;
            // 
            // StadiumName
            // 
            this.StadiumName.HeaderText = "Stadium Name";
            this.StadiumName.MinimumWidth = 6;
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.ReadOnly = true;
            // 
            // Payment1
            // 
            this.Payment1.HeaderText = "Payment";
            this.Payment1.MinimumWidth = 6;
            this.Payment1.Name = "Payment1";
            this.Payment1.ReadOnly = true;
            // 
            // ReservasionStatus
            // 
            this.ReservasionStatus.HeaderText = " Status";
            this.ReservasionStatus.MinimumWidth = 6;
            this.ReservasionStatus.Name = "ReservasionStatus";
            this.ReservasionStatus.ReadOnly = true;
            // 
            // DeleteResrvation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteResrvation";
            this.Text = "delLegue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rev_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserv_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserv_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadium_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserv_Statue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservasionStatus;
    }
}