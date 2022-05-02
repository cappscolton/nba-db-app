namespace UserInterface
{
    partial class AddEditGame
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
            this.uxHome = new System.Windows.Forms.Label();
            this.uxAway = new System.Windows.Forms.Label();
            this.uxHomeScore = new System.Windows.Forms.Label();
            this.uxHomeSelect = new System.Windows.Forms.ComboBox();
            this.uxAwaySelect = new System.Windows.Forms.ComboBox();
            this.uxAwayScore = new System.Windows.Forms.Label();
            this.uxHomeScoreVal = new System.Windows.Forms.NumericUpDown();
            this.uxAwayScoreVal = new System.Windows.Forms.NumericUpDown();
            this.uxDate = new System.Windows.Forms.Label();
            this.uxDateSelect = new System.Windows.Forms.DateTimePicker();
            this.uxSeasonSelect = new System.Windows.Forms.ComboBox();
            this.uxSeason = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScoreVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAwayScoreVal)).BeginInit();
            this.SuspendLayout();
            // 
            // uxHome
            // 
            this.uxHome.AutoSize = true;
            this.uxHome.Location = new System.Drawing.Point(12, 9);
            this.uxHome.Name = "uxHome";
            this.uxHome.Size = new System.Drawing.Size(74, 15);
            this.uxHome.TabIndex = 0;
            this.uxHome.Text = "Home Team:";
            // 
            // uxAway
            // 
            this.uxAway.AutoSize = true;
            this.uxAway.Location = new System.Drawing.Point(315, 9);
            this.uxAway.Name = "uxAway";
            this.uxAway.Size = new System.Drawing.Size(70, 15);
            this.uxAway.TabIndex = 1;
            this.uxAway.Text = "Away Team:";
            // 
            // uxHomeScore
            // 
            this.uxHomeScore.AutoSize = true;
            this.uxHomeScore.Location = new System.Drawing.Point(12, 52);
            this.uxHomeScore.Name = "uxHomeScore";
            this.uxHomeScore.Size = new System.Drawing.Size(75, 15);
            this.uxHomeScore.TabIndex = 2;
            this.uxHomeScore.Text = "Home Score:";
            // 
            // uxHomeSelect
            // 
            this.uxHomeSelect.FormattingEnabled = true;
            this.uxHomeSelect.Location = new System.Drawing.Point(92, 6);
            this.uxHomeSelect.Name = "uxHomeSelect";
            this.uxHomeSelect.Size = new System.Drawing.Size(121, 23);
            this.uxHomeSelect.TabIndex = 3;
            this.uxHomeSelect.SelectionChangeCommitted += new System.EventHandler(this.EnableCompleteButton);
            // 
            // uxAwaySelect
            // 
            this.uxAwaySelect.FormattingEnabled = true;
            this.uxAwaySelect.Location = new System.Drawing.Point(391, 6);
            this.uxAwaySelect.Name = "uxAwaySelect";
            this.uxAwaySelect.Size = new System.Drawing.Size(121, 23);
            this.uxAwaySelect.TabIndex = 4;
            this.uxAwaySelect.SelectionChangeCommitted += new System.EventHandler(this.EnableCompleteButton);
            // 
            // uxAwayScore
            // 
            this.uxAwayScore.AutoSize = true;
            this.uxAwayScore.Location = new System.Drawing.Point(315, 52);
            this.uxAwayScore.Name = "uxAwayScore";
            this.uxAwayScore.Size = new System.Drawing.Size(71, 15);
            this.uxAwayScore.TabIndex = 5;
            this.uxAwayScore.Text = "Away Score:";
            // 
            // uxHomeScoreVal
            // 
            this.uxHomeScoreVal.Location = new System.Drawing.Point(92, 50);
            this.uxHomeScoreVal.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.uxHomeScoreVal.Name = "uxHomeScoreVal";
            this.uxHomeScoreVal.Size = new System.Drawing.Size(120, 23);
            this.uxHomeScoreVal.TabIndex = 6;
            // 
            // uxAwayScoreVal
            // 
            this.uxAwayScoreVal.Location = new System.Drawing.Point(392, 50);
            this.uxAwayScoreVal.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.uxAwayScoreVal.Name = "uxAwayScoreVal";
            this.uxAwayScoreVal.Size = new System.Drawing.Size(120, 23);
            this.uxAwayScoreVal.TabIndex = 7;
            // 
            // uxDate
            // 
            this.uxDate.AutoSize = true;
            this.uxDate.Location = new System.Drawing.Point(12, 133);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(72, 15);
            this.uxDate.TabIndex = 8;
            this.uxDate.Text = "Date Played:";
            // 
            // uxDateSelect
            // 
            this.uxDateSelect.CustomFormat = "dd MMM yyyy";
            this.uxDateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxDateSelect.Location = new System.Drawing.Point(90, 127);
            this.uxDateSelect.Name = "uxDateSelect";
            this.uxDateSelect.Size = new System.Drawing.Size(148, 23);
            this.uxDateSelect.TabIndex = 9;
            // 
            // uxSeasonSelect
            // 
            this.uxSeasonSelect.FormattingEnabled = true;
            this.uxSeasonSelect.Location = new System.Drawing.Point(392, 127);
            this.uxSeasonSelect.Name = "uxSeasonSelect";
            this.uxSeasonSelect.Size = new System.Drawing.Size(121, 23);
            this.uxSeasonSelect.TabIndex = 11;
            this.uxSeasonSelect.SelectionChangeCommitted += new System.EventHandler(this.EnableCompleteButton);
            // 
            // uxSeason
            // 
            this.uxSeason.AutoSize = true;
            this.uxSeason.Location = new System.Drawing.Point(316, 130);
            this.uxSeason.Name = "uxSeason";
            this.uxSeason.Size = new System.Drawing.Size(47, 15);
            this.uxSeason.TabIndex = 10;
            this.uxSeason.Text = "Season:";
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(12, 204);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 12;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // uxComplete
            // 
            this.uxComplete.Enabled = false;
            this.uxComplete.Location = new System.Drawing.Point(437, 204);
            this.uxComplete.Name = "uxComplete";
            this.uxComplete.Size = new System.Drawing.Size(75, 23);
            this.uxComplete.TabIndex = 13;
            this.uxComplete.Text = "Complete";
            this.uxComplete.UseVisualStyleBackColor = true;
            this.uxComplete.Click += new System.EventHandler(this.uxComplete_Click);
            // 
            // AddEditGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 239);
            this.Controls.Add(this.uxComplete);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxSeasonSelect);
            this.Controls.Add(this.uxSeason);
            this.Controls.Add(this.uxDateSelect);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxAwayScoreVal);
            this.Controls.Add(this.uxHomeScoreVal);
            this.Controls.Add(this.uxAwayScore);
            this.Controls.Add(this.uxAwaySelect);
            this.Controls.Add(this.uxHomeSelect);
            this.Controls.Add(this.uxHomeScore);
            this.Controls.Add(this.uxAway);
            this.Controls.Add(this.uxHome);
            this.Name = "AddEditGame";
            this.Text = "AddEditGame";
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeScoreVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAwayScoreVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label uxHome;
        private Label uxAway;
        private Label uxHomeScore;
        private ComboBox uxHomeSelect;
        private ComboBox uxAwaySelect;
        private Label uxAwayScore;
        private NumericUpDown uxHomeScoreVal;
        private NumericUpDown uxAwayScoreVal;
        private Label uxDate;
        private DateTimePicker uxDateSelect;
        private ComboBox uxSeasonSelect;
        private Label uxSeason;
        private Button uxCancel;
        private Button uxComplete;
    }
}