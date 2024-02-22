namespace ReservationPage
{
    partial class ReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confbtn = new System.Windows.Forms.Button();
            this.datebx = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.datealarm = new System.Windows.Forms.Label();
            this.payalarm = new System.Windows.Forms.Label();
            this.stadalarm = new System.Windows.Forms.Label();
            this.CityCompoBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Citylbl = new System.Windows.Forms.Label();
            this.stadbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.paybx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Timelbl = new System.Windows.Forms.Label();
            this.lblcCity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stadium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay Way";
            // 
            // confbtn
            // 
            this.confbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.confbtn.ForeColor = System.Drawing.Color.White;
            this.confbtn.Location = new System.Drawing.Point(409, 366);
            this.confbtn.Name = "confbtn";
            this.confbtn.Size = new System.Drawing.Size(157, 59);
            this.confbtn.TabIndex = 5;
            this.confbtn.Text = "Confirm";
            this.confbtn.UseVisualStyleBackColor = false;
            this.confbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // datebx
            // 
            this.datebx.CustomFormat = "dd-MM-yyyy";
            this.datebx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebx.Location = new System.Drawing.Point(191, 63);
            this.datebx.MinDate = new System.DateTime(2024, 2, 21, 0, 0, 0, 0);
            this.datebx.Name = "datebx";
            this.datebx.Size = new System.Drawing.Size(205, 31);
            this.datebx.TabIndex = 6;
            this.datebx.ValueChanged += new System.EventHandler(this.datebx_ValueChanged);
            // 
            // datealarm
            // 
            this.datealarm.AutoSize = true;
            this.datealarm.BackColor = System.Drawing.Color.Transparent;
            this.datealarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datealarm.ForeColor = System.Drawing.Color.DimGray;
            this.datealarm.Location = new System.Drawing.Point(192, 103);
            this.datealarm.Name = "datealarm";
            this.datealarm.Size = new System.Drawing.Size(133, 17);
            this.datealarm.TabIndex = 10;
            this.datealarm.Text = "Date Must be future";
            // 
            // payalarm
            // 
            this.payalarm.AutoSize = true;
            this.payalarm.BackColor = System.Drawing.Color.Transparent;
            this.payalarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payalarm.ForeColor = System.Drawing.Color.DimGray;
            this.payalarm.Location = new System.Drawing.Point(192, 357);
            this.payalarm.Name = "payalarm";
            this.payalarm.Size = new System.Drawing.Size(131, 17);
            this.payalarm.TabIndex = 11;
            this.payalarm.Text = "Choose Way to pay";
            // 
            // stadalarm
            // 
            this.stadalarm.AutoSize = true;
            this.stadalarm.BackColor = System.Drawing.Color.Transparent;
            this.stadalarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stadalarm.ForeColor = System.Drawing.Color.DimGray;
            this.stadalarm.Location = new System.Drawing.Point(187, 225);
            this.stadalarm.Name = "stadalarm";
            this.stadalarm.Size = new System.Drawing.Size(111, 17);
            this.stadalarm.TabIndex = 12;
            this.stadalarm.Text = "Choose Stadium";
            // 
            // CityCompoBox
            // 
            this.CityCompoBox.BackColor = System.Drawing.Color.Transparent;
            this.CityCompoBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CityCompoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityCompoBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CityCompoBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CityCompoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CityCompoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CityCompoBox.ItemHeight = 30;
            this.CityCompoBox.Location = new System.Drawing.Point(604, 58);
            this.CityCompoBox.Name = "CityCompoBox";
            this.CityCompoBox.Size = new System.Drawing.Size(180, 36);
            this.CityCompoBox.TabIndex = 14;
            this.CityCompoBox.SelectedIndexChanged += new System.EventHandler(this.CityCompoBox_SelectedIndexChanged);
            // 
            // Citylbl
            // 
            this.Citylbl.AutoSize = true;
            this.Citylbl.Location = new System.Drawing.Point(507, 68);
            this.Citylbl.Name = "Citylbl";
            this.Citylbl.Size = new System.Drawing.Size(49, 25);
            this.Citylbl.TabIndex = 15;
            this.Citylbl.Text = "City";
            // 
            // stadbx
            // 
            this.stadbx.BackColor = System.Drawing.Color.Transparent;
            this.stadbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stadbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stadbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stadbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stadbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stadbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.stadbx.ItemHeight = 30;
            this.stadbx.Location = new System.Drawing.Point(190, 172);
            this.stadbx.Name = "stadbx";
            this.stadbx.Size = new System.Drawing.Size(206, 36);
            this.stadbx.TabIndex = 16;
            this.stadbx.SelectedIndexChanged += new System.EventHandler(this.stadbx_SelectedIndexChanged_1);
            // 
            // timeComboBox
            // 
            this.timeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.timeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.timeComboBox.DropDownHeight = 100;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.timeComboBox.IntegralHeight = false;
            this.timeComboBox.ItemHeight = 30;
            this.timeComboBox.Location = new System.Drawing.Point(604, 172);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(180, 36);
            this.timeComboBox.TabIndex = 17;
            // 
            // paybx
            // 
            this.paybx.BackColor = System.Drawing.Color.Transparent;
            this.paybx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paybx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paybx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paybx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paybx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.paybx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.paybx.FormattingEnabled = true;
            this.paybx.ItemHeight = 30;
            this.paybx.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "wallet Cash",
            "Cash",
            "Credit Card",
            "Cash Wallet"});
            this.paybx.Location = new System.Drawing.Point(191, 306);
            this.paybx.Name = "paybx";
            this.paybx.Size = new System.Drawing.Size(140, 36);
            this.paybx.TabIndex = 18;
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.BackColor = System.Drawing.Color.Transparent;
            this.Timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.ForeColor = System.Drawing.Color.DimGray;
            this.Timelbl.Location = new System.Drawing.Point(798, 180);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(82, 17);
            this.Timelbl.TabIndex = 20;
            this.Timelbl.Text = "Select Time";
            this.Timelbl.Visible = false;
            // 
            // lblcCity
            // 
            this.lblcCity.AutoSize = true;
            this.lblcCity.BackColor = System.Drawing.Color.Transparent;
            this.lblcCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcCity.ForeColor = System.Drawing.Color.DimGray;
            this.lblcCity.Location = new System.Drawing.Point(798, 69);
            this.lblcCity.Name = "lblcCity";
            this.lblcCity.Size = new System.Drawing.Size(74, 17);
            this.lblcCity.TabIndex = 19;
            this.lblcCity.Text = "Select City";
            this.lblcCity.Visible = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1089, 626);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.lblcCity);
            this.Controls.Add(this.paybx);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.stadbx);
            this.Controls.Add(this.Citylbl);
            this.Controls.Add(this.CityCompoBox);
            this.Controls.Add(this.stadalarm);
            this.Controls.Add(this.payalarm);
            this.Controls.Add(this.datealarm);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.confbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReservationForm";
            this.Text = "Reserve";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reserve_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confbtn;
        private System.Windows.Forms.DateTimePicker datebx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label datealarm;
        private System.Windows.Forms.Label payalarm;
        private System.Windows.Forms.Label stadalarm;
        private Guna.UI2.WinForms.Guna2ComboBox CityCompoBox;
        private System.Windows.Forms.Label Citylbl;
        private Guna.UI2.WinForms.Guna2ComboBox stadbx;
        private Guna.UI2.WinForms.Guna2ComboBox timeComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox paybx;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Label lblcCity;
    }
}