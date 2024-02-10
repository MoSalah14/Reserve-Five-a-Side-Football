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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeagueGridView = new System.Windows.Forms.DataGridView();
            this.NameGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LeagueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LeagueGridView
            // 
            this.LeagueGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeagueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeagueGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeagueGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeagueGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LeagueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeagueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameGridView,
            this.CityGridView,
            this.StartDateGridView,
            this.EndDateGridView,
            this.TimeGridView,
            this.RewardGridView});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeagueGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.LeagueGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.LeagueGridView.EnableHeadersVisualStyles = false;
            this.LeagueGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeagueGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LeagueGridView.Location = new System.Drawing.Point(3, 1);
            this.LeagueGridView.Name = "LeagueGridView";
            this.LeagueGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeagueGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LeagueGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.LeagueGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LeagueGridView.RowTemplate.Height = 24;
            this.LeagueGridView.Size = new System.Drawing.Size(1309, 751);
            this.LeagueGridView.TabIndex = 1;
            this.LeagueGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeagueGridView_CellDoubleClick);
            // 
            // NameGridView
            // 
            this.NameGridView.HeaderText = "Name";
            this.NameGridView.MinimumWidth = 6;
            this.NameGridView.Name = "NameGridView";
            this.NameGridView.ReadOnly = true;
            // 
            // CityGridView
            // 
            this.CityGridView.HeaderText = "City";
            this.CityGridView.MinimumWidth = 6;
            this.CityGridView.Name = "CityGridView";
            this.CityGridView.ReadOnly = true;
            // 
            // StartDateGridView
            // 
            this.StartDateGridView.HeaderText = "StartDate";
            this.StartDateGridView.MinimumWidth = 6;
            this.StartDateGridView.Name = "StartDateGridView";
            this.StartDateGridView.ReadOnly = true;
            // 
            // EndDateGridView
            // 
            this.EndDateGridView.HeaderText = "EndDate";
            this.EndDateGridView.MinimumWidth = 6;
            this.EndDateGridView.Name = "EndDateGridView";
            this.EndDateGridView.ReadOnly = true;
            // 
            // TimeGridView
            // 
            this.TimeGridView.HeaderText = "Time";
            this.TimeGridView.MinimumWidth = 6;
            this.TimeGridView.Name = "TimeGridView";
            this.TimeGridView.ReadOnly = true;
            // 
            // RewardGridView
            // 
            this.RewardGridView.HeaderText = "Reward";
            this.RewardGridView.MinimumWidth = 6;
            this.RewardGridView.Name = "RewardGridView";
            this.RewardGridView.ReadOnly = true;
            // 
            // LeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 751);
            this.Controls.Add(this.LeagueGridView);
            this.Name = "LeagueForm";
            this.Text = "League";
            this.Load += new System.EventHandler(this.LeagueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeagueGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView LeagueGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardGridView;
    }
}