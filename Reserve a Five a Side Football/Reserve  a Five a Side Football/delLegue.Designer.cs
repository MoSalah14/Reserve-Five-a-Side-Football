namespace Reserve__a_Five_a_Side_Football
{
    partial class delLegue
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leg_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePlay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Your legue";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.leg_Name,
            this.StadiumName,
            this.BeginDate,
            this.EndDate,
            this.TimePlay,
            this.Reward});
            this.dataGridView1.Location = new System.Drawing.Point(4, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 194);
            this.dataGridView1.TabIndex = 2;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "fullName";
            this.fullName.Name = "fullName";
            // 
            // leg_Name
            // 
            this.leg_Name.HeaderText = "leg_Name";
            this.leg_Name.Name = "leg_Name";
            // 
            // StadiumName
            // 
            this.StadiumName.HeaderText = "StadiumName";
            this.StadiumName.Name = "StadiumName";
            // 
            // BeginDate
            // 
            this.BeginDate.HeaderText = "BeginDate";
            this.BeginDate.Name = "BeginDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            // 
            // TimePlay
            // 
            this.TimePlay.HeaderText = "TimePlay";
            this.TimePlay.Name = "TimePlay";
            // 
            // Reward
            // 
            this.Reward.HeaderText = "Reward";
            this.Reward.Name = "Reward";
            // 
            // delLegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "delLegue";
            this.Text = "delLegue";
            this.Load += new System.EventHandler(this.delLegue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn leg_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reward;
    }
}