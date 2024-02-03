namespace Reserve__a_Five_a_Side_Football
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.LeaguePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LeagueButton = new System.Windows.Forms.Button();
            this.StadiumButton = new System.Windows.Forms.Button();
            this.ReservationsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeaguePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaguePictureBox
            // 
            this.LeaguePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeaguePictureBox.BackgroundImage")));
            this.LeaguePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeaguePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LeaguePictureBox.InitialImage")));
            this.LeaguePictureBox.Location = new System.Drawing.Point(1, 2);
            this.LeaguePictureBox.Name = "LeaguePictureBox";
            this.LeaguePictureBox.Size = new System.Drawing.Size(612, 263);
            this.LeaguePictureBox.TabIndex = 1;
            this.LeaguePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1388, 301);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(777, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(612, 263);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LeagueButton
            // 
            this.LeagueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueButton.Location = new System.Drawing.Point(1, 265);
            this.LeagueButton.Name = "LeagueButton";
            this.LeagueButton.Size = new System.Drawing.Size(612, 58);
            this.LeagueButton.TabIndex = 4;
            this.LeagueButton.Text = "League";
            this.LeagueButton.UseVisualStyleBackColor = true;
            this.LeagueButton.Click += new System.EventHandler(this.LeagueButton_Click);
            // 
            // StadiumButton
            // 
            this.StadiumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StadiumButton.Location = new System.Drawing.Point(777, 265);
            this.StadiumButton.Name = "StadiumButton";
            this.StadiumButton.Size = new System.Drawing.Size(612, 58);
            this.StadiumButton.TabIndex = 5;
            this.StadiumButton.Text = "Stadium";
            this.StadiumButton.UseVisualStyleBackColor = true;
            this.StadiumButton.Click += new System.EventHandler(this.StadiumButton_Click);
            // 
            // ReservationsButton
            // 
            this.ReservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationsButton.Location = new System.Drawing.Point(1, 576);
            this.ReservationsButton.Name = "ReservationsButton";
            this.ReservationsButton.Size = new System.Drawing.Size(1388, 81);
            this.ReservationsButton.TabIndex = 6;
            this.ReservationsButton.Text = "Reservations";
            this.ReservationsButton.UseVisualStyleBackColor = true;
            this.ReservationsButton.Click += new System.EventHandler(this.ReservationsButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1389, 755);
            this.Controls.Add(this.ReservationsButton);
            this.Controls.Add(this.StadiumButton);
            this.Controls.Add(this.LeagueButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LeaguePictureBox);
            this.Name = "HomeScreen";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.LeaguePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox LeaguePictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LeagueButton;
        private System.Windows.Forms.Button StadiumButton;
        private System.Windows.Forms.Button ReservationsButton;
    }
}

