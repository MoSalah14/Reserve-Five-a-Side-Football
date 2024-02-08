﻿namespace ReservationPage
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
            this.stadbx = new System.Windows.Forms.ComboBox();
            this.timebx = new System.Windows.Forms.DateTimePicker();
            this.paybx = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.datealarm = new System.Windows.Forms.Label();
            this.payalarm = new System.Windows.Forms.Label();
            this.stadalarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stadium Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay Way";
            // 
            // confbtn
            // 
            this.confbtn.Location = new System.Drawing.Point(125, 406);
            this.confbtn.Name = "confbtn";
            this.confbtn.Size = new System.Drawing.Size(258, 59);
            this.confbtn.TabIndex = 5;
            this.confbtn.Text = "Confirm";
            this.confbtn.UseVisualStyleBackColor = true;
            this.confbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // datebx
            // 
            this.datebx.CustomFormat = "dd-MM-yyyy";
            this.datebx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebx.Location = new System.Drawing.Point(105, 83);
            this.datebx.Name = "datebx";
            this.datebx.Size = new System.Drawing.Size(205, 31);
            this.datebx.TabIndex = 6;
            // 
            // stadbx
            // 
            this.stadbx.FormattingEnabled = true;
            this.stadbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.stadbx.Location = new System.Drawing.Point(211, 143);
            this.stadbx.Name = "stadbx";
            this.stadbx.Size = new System.Drawing.Size(121, 33);
            this.stadbx.TabIndex = 7;
            // 
            // timebx
            // 
            this.timebx.CustomFormat = "HH:mm:SS";
            this.timebx.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timebx.Location = new System.Drawing.Point(189, 214);
            this.timebx.Name = "timebx";
            this.timebx.Size = new System.Drawing.Size(143, 31);
            this.timebx.TabIndex = 8;
            // 
            // paybx
            // 
            this.paybx.FormattingEnabled = true;
            this.paybx.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "wallet Cash"});
            this.paybx.Location = new System.Drawing.Point(174, 302);
            this.paybx.Name = "paybx";
            this.paybx.Size = new System.Drawing.Size(179, 33);
            this.paybx.TabIndex = 9;
            // 
            // datealarm
            // 
            this.datealarm.AutoSize = true;
            this.datealarm.BackColor = System.Drawing.Color.Red;
            this.datealarm.Location = new System.Drawing.Point(411, 83);
            this.datealarm.Name = "datealarm";
            this.datealarm.Size = new System.Drawing.Size(201, 25);
            this.datealarm.TabIndex = 10;
            this.datealarm.Text = "Date Must be future";
            // 
            // payalarm
            // 
            this.payalarm.AutoSize = true;
            this.payalarm.BackColor = System.Drawing.Color.Red;
            this.payalarm.Location = new System.Drawing.Point(411, 305);
            this.payalarm.Name = "payalarm";
            this.payalarm.Size = new System.Drawing.Size(200, 25);
            this.payalarm.TabIndex = 11;
            this.payalarm.Text = "Choose Way to pay";
            // 
            // stadalarm
            // 
            this.stadalarm.AutoSize = true;
            this.stadalarm.BackColor = System.Drawing.Color.Red;
            this.stadalarm.Location = new System.Drawing.Point(411, 146);
            this.stadalarm.Name = "stadalarm";
            this.stadalarm.Size = new System.Drawing.Size(170, 25);
            this.stadalarm.TabIndex = 12;
            this.stadalarm.Text = "Choose Stadium";
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 584);
            this.Controls.Add(this.stadalarm);
            this.Controls.Add(this.payalarm);
            this.Controls.Add(this.datealarm);
            this.Controls.Add(this.paybx);
            this.Controls.Add(this.timebx);
            this.Controls.Add(this.stadbx);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.confbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Reserve";
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
        private System.Windows.Forms.ComboBox stadbx;
        private System.Windows.Forms.DateTimePicker timebx;
        private System.Windows.Forms.ComboBox paybx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label datealarm;
        private System.Windows.Forms.Label payalarm;
        private System.Windows.Forms.Label stadalarm;
    }
}