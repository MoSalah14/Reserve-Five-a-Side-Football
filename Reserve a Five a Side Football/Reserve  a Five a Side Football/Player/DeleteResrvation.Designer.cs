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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rev_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation For Player";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rev_ID,
            this.RevDate,
            this.RevTime,
            this.StadiumName,
            this.Payment1,
            this.Status1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(732, 181);
            this.dataGridView1.TabIndex = 3;
            // 
            // Rev_ID
            // 
            this.Rev_ID.HeaderText = "RevID";
            this.Rev_ID.MinimumWidth = 6;
            this.Rev_ID.Name = "Rev_ID";
            this.Rev_ID.Visible = false;
            this.Rev_ID.Width = 125;
            // 
            // RevDate
            // 
            this.RevDate.HeaderText = "RevDate";
            this.RevDate.MinimumWidth = 6;
            this.RevDate.Name = "RevDate";
            this.RevDate.Width = 125;
            // 
            // RevTime
            // 
            this.RevTime.HeaderText = "RevTime";
            this.RevTime.MinimumWidth = 6;
            this.RevTime.Name = "RevTime";
            this.RevTime.ReadOnly = true;
            this.RevTime.Width = 125;
            // 
            // StadiumName
            // 
            this.StadiumName.HeaderText = "Stadium";
            this.StadiumName.MinimumWidth = 6;
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.ReadOnly = true;
            this.StadiumName.Width = 125;
            // 
            // Payment1
            // 
            this.Payment1.HeaderText = "Payment";
            this.Payment1.MinimumWidth = 6;
            this.Payment1.Name = "Payment1";
            this.Payment1.ReadOnly = true;
            this.Payment1.Width = 125;
            // 
            // Status1
            // 
            this.Status1.HeaderText = "Status";
            this.Status1.MinimumWidth = 6;
            this.Status1.Name = "Status1";
            this.Status1.ReadOnly = true;
            this.Status1.Width = 125;
            // 
            // DeleteResrvation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 362);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RevDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status1;
    }
}