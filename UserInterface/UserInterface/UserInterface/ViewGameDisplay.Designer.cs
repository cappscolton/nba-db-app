namespace UserInterface
{
    partial class ViewGameDisplay
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
            this.uxExit = new System.Windows.Forms.Button();
            this.uxSeason = new System.Windows.Forms.Label();
            this.uxDatePlayed = new System.Windows.Forms.DateTimePicker();
            this.uxDate = new System.Windows.Forms.Label();
            this.uxAwayScore = new System.Windows.Forms.Label();
            this.uxHomeScore = new System.Windows.Forms.Label();
            this.uxAway = new System.Windows.Forms.Label();
            this.uxHome = new System.Windows.Forms.Label();
            this.uxHomeTeamName = new System.Windows.Forms.Label();
            this.uxHomeTeamScore = new System.Windows.Forms.Label();
            this.uxAwayTeamName = new System.Windows.Forms.Label();
            this.uxAwayTeamScore = new System.Windows.Forms.Label();
            this.uxSeasonValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(17, 210);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(75, 23);
            this.uxExit.TabIndex = 26;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxSeason
            // 
            this.uxSeason.AutoSize = true;
            this.uxSeason.Location = new System.Drawing.Point(321, 136);
            this.uxSeason.Name = "uxSeason";
            this.uxSeason.Size = new System.Drawing.Size(47, 15);
            this.uxSeason.TabIndex = 24;
            this.uxSeason.Text = "Season:";
            // 
            // uxDatePlayed
            // 
            this.uxDatePlayed.CustomFormat = "dd MMM yyyy";
            this.uxDatePlayed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxDatePlayed.Location = new System.Drawing.Point(95, 133);
            this.uxDatePlayed.Name = "uxDatePlayed";
            this.uxDatePlayed.Size = new System.Drawing.Size(148, 23);
            this.uxDatePlayed.TabIndex = 23;
            // 
            // uxDate
            // 
            this.uxDate.AutoSize = true;
            this.uxDate.Location = new System.Drawing.Point(17, 139);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(72, 15);
            this.uxDate.TabIndex = 22;
            this.uxDate.Text = "Date Played:";
            // 
            // uxAwayScore
            // 
            this.uxAwayScore.AutoSize = true;
            this.uxAwayScore.Location = new System.Drawing.Point(320, 58);
            this.uxAwayScore.Name = "uxAwayScore";
            this.uxAwayScore.Size = new System.Drawing.Size(71, 15);
            this.uxAwayScore.TabIndex = 19;
            this.uxAwayScore.Text = "Away Score:";
            // 
            // uxHomeScore
            // 
            this.uxHomeScore.AutoSize = true;
            this.uxHomeScore.Location = new System.Drawing.Point(17, 58);
            this.uxHomeScore.Name = "uxHomeScore";
            this.uxHomeScore.Size = new System.Drawing.Size(75, 15);
            this.uxHomeScore.TabIndex = 16;
            this.uxHomeScore.Text = "Home Score:";
            // 
            // uxAway
            // 
            this.uxAway.AutoSize = true;
            this.uxAway.Location = new System.Drawing.Point(320, 15);
            this.uxAway.Name = "uxAway";
            this.uxAway.Size = new System.Drawing.Size(70, 15);
            this.uxAway.TabIndex = 15;
            this.uxAway.Text = "Away Team:";
            // 
            // uxHome
            // 
            this.uxHome.AutoSize = true;
            this.uxHome.Location = new System.Drawing.Point(17, 15);
            this.uxHome.Name = "uxHome";
            this.uxHome.Size = new System.Drawing.Size(74, 15);
            this.uxHome.TabIndex = 14;
            this.uxHome.Text = "Home Team:";
            // 
            // uxHomeTeamName
            // 
            this.uxHomeTeamName.AutoSize = true;
            this.uxHomeTeamName.Location = new System.Drawing.Point(97, 15);
            this.uxHomeTeamName.Name = "uxHomeTeamName";
            this.uxHomeTeamName.Size = new System.Drawing.Size(44, 15);
            this.uxHomeTeamName.TabIndex = 28;
            this.uxHomeTeamName.Text = "default";
            // 
            // uxHomeTeamScore
            // 
            this.uxHomeTeamScore.AutoSize = true;
            this.uxHomeTeamScore.Location = new System.Drawing.Point(98, 58);
            this.uxHomeTeamScore.Name = "uxHomeTeamScore";
            this.uxHomeTeamScore.Size = new System.Drawing.Size(44, 15);
            this.uxHomeTeamScore.TabIndex = 29;
            this.uxHomeTeamScore.Text = "default";
            // 
            // uxAwayTeamName
            // 
            this.uxAwayTeamName.AutoSize = true;
            this.uxAwayTeamName.Location = new System.Drawing.Point(396, 15);
            this.uxAwayTeamName.Name = "uxAwayTeamName";
            this.uxAwayTeamName.Size = new System.Drawing.Size(44, 15);
            this.uxAwayTeamName.TabIndex = 30;
            this.uxAwayTeamName.Text = "default";
            // 
            // uxAwayTeamScore
            // 
            this.uxAwayTeamScore.AutoSize = true;
            this.uxAwayTeamScore.Location = new System.Drawing.Point(396, 58);
            this.uxAwayTeamScore.Name = "uxAwayTeamScore";
            this.uxAwayTeamScore.Size = new System.Drawing.Size(44, 15);
            this.uxAwayTeamScore.TabIndex = 31;
            this.uxAwayTeamScore.Text = "default";
            // 
            // uxSeasonValue
            // 
            this.uxSeasonValue.AutoSize = true;
            this.uxSeasonValue.Location = new System.Drawing.Point(374, 136);
            this.uxSeasonValue.Name = "uxSeasonValue";
            this.uxSeasonValue.Size = new System.Drawing.Size(44, 15);
            this.uxSeasonValue.TabIndex = 32;
            this.uxSeasonValue.Text = "default";
            // 
            // ViewGameDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 248);
            this.Controls.Add(this.uxSeasonValue);
            this.Controls.Add(this.uxAwayTeamScore);
            this.Controls.Add(this.uxAwayTeamName);
            this.Controls.Add(this.uxHomeTeamScore);
            this.Controls.Add(this.uxHomeTeamName);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxSeason);
            this.Controls.Add(this.uxDatePlayed);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxAwayScore);
            this.Controls.Add(this.uxHomeScore);
            this.Controls.Add(this.uxAway);
            this.Controls.Add(this.uxHome);
            this.Name = "ViewGameDisplay";
            this.Text = "ViewGameDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button uxExit;
        private Label uxSeason;
        private DateTimePicker uxDatePlayed;
        private Label uxDate;
        private Label uxAwayScore;
        private Label uxHomeScore;
        private Label uxAway;
        private Label uxHome;
        private Label uxHomeTeamName;
        private Label uxHomeTeamScore;
        private Label uxAwayTeamName;
        private Label uxAwayTeamScore;
        private Label uxSeasonValue;
    }
}