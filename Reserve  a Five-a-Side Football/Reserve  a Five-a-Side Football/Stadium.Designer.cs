/*using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using Image = System.Drawing.Image;

namespace Stadiam
{
    partial class Stadium
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Format));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox11 = new PictureBox();
            label11 = new Label();
            pictureBox10 = new PictureBox();
            label9 = new Label();
            button2 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button3 = new Button();
            panel4 = new Panel();
            label21 = new Label();
            label20 = new Label();
            label18 = new Label();
            label15 = new Label();
            pictureBox16 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox12 = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            button4 = new Button();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 178);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources._82;
            pictureBox3.Location = new Point(684, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 32);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(499, 99);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 3;
            label7.Text = "7 v 7";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(331, 99);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 7;
            label5.Text = "1Pitches";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(429, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 61);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
        
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(380, 44);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 5;
            label3.Text = "Football complex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(336, 44);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 4;
            label2.Text = "Giza ,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 3);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 3;
            label1.Text = "Al Zamalek Stadium";
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(391, 146);
            button1.Name = "button1";
            button1.Size = new Size(270, 27);
            button1.TabIndex = 2;
            button1.Text = "Book 300 EGP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 174);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(417, 105);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 2;
            label6.Text = "7 v 7";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox14);
            panel2.Controls.Add(pictureBox13);
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(3, 186);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(795, 174);
            panel2.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label17.Location = new Point(342, 37);
            label17.Name = "label17";
            label17.Size = new Size(57, 21);
            label17.TabIndex = 17;
            label17.Text = "Cairo ,";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label16.Location = new Point(405, 37);
            label16.Name = "label16";
            label16.Size = new Size(86, 21);
            label16.TabIndex = 16;
            label16.Text = "Road 6429";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(412, 3);
            label14.Name = "label14";
            label14.Size = new Size(158, 25);
            label14.TabIndex = 15;
            label14.Text = "AL Diyar Garden";
           
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(629, 105);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 14;
            label13.Text = "7 v 7";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HighlightText;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(737, 105);
            label12.Name = "label12";
            label12.Size = new Size(43, 20);
            label12.TabIndex = 13;
            label12.Text = "9 v 9";
            // 
            // pictureBox14
            // 
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            pictureBox14.ErrorImage = null;
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.InitialImage = (Image)resources.GetObject("pictureBox14.InitialImage");
            pictureBox14.Location = new Point(684, 67);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(96, 67);
            pictureBox14.TabIndex = 12;
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            pictureBox13.ErrorImage = null;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.InitialImage = (Image)resources.GetObject("pictureBox13.InitialImage");
            pictureBox13.Location = new Point(585, 67);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(93, 67);
            pictureBox13.TabIndex = 11;
            pictureBox13.TabStop = false;
           
            // 
            // pictureBox11
            // 
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            pictureBox11.Image = Properties.Resources.Screenshot__31_;
            pictureBox11.Location = new Point(687, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(83, 35);
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.HighlightText;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(527, 105);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 9;
            label11.Text = "9 v 9";
           
            // 
            // pictureBox10
            // 
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox10.ErrorImage = null;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.InitialImage = (Image)resources.GetObject("pictureBox10.InitialImage");
            pictureBox10.Location = new Point(476, 67);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(103, 67);
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(317, 92);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 8;
            label9.Text = "4 Pitches";
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(400, 140);
            button2.Name = "button2";
            button2.Size = new Size(272, 29);
            button2.TabIndex = 5;
            button2.Text = "book 400 EGP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(391, 67);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(79, 67);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources.image_1;
            pictureBox4.Location = new Point(-1, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(321, 170);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = Properties.Resources.image2;
            pictureBox5.Location = new Point(3, -13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(321, 181);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(476, 153);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(pictureBox16);
            panel4.Controls.Add(pictureBox15);
            panel4.Controls.Add(pictureBox12);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(pictureBox9);
            panel4.Location = new Point(3, 366);
            panel4.Name = "panel4";
            panel4.Size = new Size(802, 181);
            panel4.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.HighlightText;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(703, 92);
            label21.Name = "label21";
            label21.Size = new Size(43, 20);
            label21.TabIndex = 20;
            label21.Text = "9 v 9";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.FlatStyle = FlatStyle.Popup;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ImageAlign = ContentAlignment.MiddleLeft;
            label20.Location = new Point(581, 92);
            label20.Name = "label20";
            label20.Size = new Size(43, 20);
            label20.TabIndex = 19;
            label20.Text = "7 v 7";
           
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(353, 40);
            label18.Name = "label18";
            label18.Size = new Size(46, 20);
            label18.TabIndex = 17;
            label18.Text = "Cairo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(380, 3);
            label15.Name = "label15";
            label15.Size = new Size(259, 25);
            label15.TabIndex = 16;
            label15.Text = "Cairo International Stadium";
            // 
            // pictureBox16
            // 
            pictureBox16.BorderStyle = BorderStyle.FixedSingle;
            pictureBox16.ErrorImage = null;
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.InitialImage = (Image)resources.GetObject("pictureBox16.InitialImage");
            pictureBox16.Location = new Point(637, 63);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(119, 64);
            pictureBox16.TabIndex = 13;
            pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BorderStyle = BorderStyle.FixedSingle;
            pictureBox15.ErrorImage = null;
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.InitialImage = (Image)resources.GetObject("pictureBox15.InitialImage");
            pictureBox15.Location = new Point(515, 63);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(116, 64);
            pictureBox15.TabIndex = 12;
            pictureBox15.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;
            pictureBox12.Image = Properties.Resources.Screenshot__32_;
            pictureBox12.Location = new Point(695, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(89, 34);
            pictureBox12.TabIndex = 11;
            pictureBox12.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(471, 92);
            label8.Name = "label8";
            label8.Size = new Size(37, 17);
            label8.TabIndex = 10;
            label8.Text = "9 v 9";
          
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(326, 90);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 9;
            label10.Text = "3 Pitches";
            // 
            // button4
            // 
            button4.BackColor = Color.Linen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Green;
            button4.Location = new Point(400, 142);
            button4.Name = "button4";
            button4.Size = new Size(278, 34);
            button4.TabIndex = 6;
            button4.Text = "book 340 EGP";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.ErrorImage = null;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.InitialImage = (Image)resources.GetObject("pictureBox8.InitialImage");
            pictureBox8.Location = new Point(400, 63);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(109, 64);
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Image = Properties.Resources.image2;
            pictureBox9.Location = new Point(3, -5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(317, 181);
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(147, 366);
            panel3.Name = "panel3";
            panel3.Size = new Size(603, 181);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(412, 40);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 21;
            label4.Text = "Nasr City";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Stadiam";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button2;
        private PictureBox pictureBox6;
        private Label label9;
        private Label label11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label17;
        private Label label16;
        private PictureBox pictureBox5;
        private Button button3;
        private Panel panel4;
        private Label label21;
        private Label label20;
        private Label label18;
        private Label label15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private PictureBox pictureBox12;
        private Label label8;
        private Label label10;
        private Button button4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Panel panel3;
        private Label label4;
    }
}
*/