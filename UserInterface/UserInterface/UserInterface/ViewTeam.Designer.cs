namespace UserInterface
{
    partial class ViewTeam
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
            this.uxTeamSelect = new System.Windows.Forms.ComboBox();
            this.TeamName = new System.Windows.Forms.Label();
            this.uxSearch = new System.Windows.Forms.Button();
            this.StadiumName = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.ZipCode = new System.Windows.Forms.Label();
            this.uxStadiumName = new System.Windows.Forms.Label();
            this.uxCityName = new System.Windows.Forms.Label();
            this.uxStateName = new System.Windows.Forms.Label();
            this.uxZipCode = new System.Windows.Forms.Label();
            this.PlayerRoster = new System.Windows.Forms.Label();
            this.uxPlayerRoster = new System.Windows.Forms.ListView();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Position = new System.Windows.Forms.ColumnHeader();
            this.uxExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTeamSelect
            // 
            this.uxTeamSelect.FormattingEnabled = true;
            this.uxTeamSelect.Location = new System.Drawing.Point(91, 6);
            this.uxTeamSelect.Name = "uxTeamSelect";
            this.uxTeamSelect.Size = new System.Drawing.Size(201, 23);
            this.uxTeamSelect.TabIndex = 0;
            this.uxTeamSelect.SelectionChangeCommitted += new System.EventHandler(this.EnableSearchButton);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Location = new System.Drawing.Point(12, 9);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(73, 15);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "Team Name:";
            // 
            // uxSearch
            // 
            this.uxSearch.Enabled = false;
            this.uxSearch.Location = new System.Drawing.Point(309, 6);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(75, 23);
            this.uxSearch.TabIndex = 2;
            this.uxSearch.Text = "Search";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // StadiumName
            // 
            this.StadiumName.AutoSize = true;
            this.StadiumName.Location = new System.Drawing.Point(426, 10);
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.Size = new System.Drawing.Size(89, 15);
            this.StadiumName.TabIndex = 3;
            this.StadiumName.Text = "Stadium Name:";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(484, 35);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(31, 15);
            this.City.TabIndex = 4;
            this.City.Text = "City:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(479, 61);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(36, 15);
            this.State.TabIndex = 5;
            this.State.Text = "State:";
            // 
            // ZipCode
            // 
            this.ZipCode.AutoSize = true;
            this.ZipCode.Location = new System.Drawing.Point(457, 85);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(58, 15);
            this.ZipCode.TabIndex = 6;
            this.ZipCode.Text = "Zip Code:";
            // 
            // uxStadiumName
            // 
            this.uxStadiumName.AutoSize = true;
            this.uxStadiumName.Location = new System.Drawing.Point(521, 10);
            this.uxStadiumName.Name = "uxStadiumName";
            this.uxStadiumName.Size = new System.Drawing.Size(0, 15);
            this.uxStadiumName.TabIndex = 7;
            // 
            // uxCityName
            // 
            this.uxCityName.AutoSize = true;
            this.uxCityName.Location = new System.Drawing.Point(521, 35);
            this.uxCityName.Name = "uxCityName";
            this.uxCityName.Size = new System.Drawing.Size(0, 15);
            this.uxCityName.TabIndex = 8;
            // 
            // uxStateName
            // 
            this.uxStateName.AutoSize = true;
            this.uxStateName.Location = new System.Drawing.Point(521, 61);
            this.uxStateName.Name = "uxStateName";
            this.uxStateName.Size = new System.Drawing.Size(0, 15);
            this.uxStateName.TabIndex = 9;
            // 
            // uxZipCode
            // 
            this.uxZipCode.AutoSize = true;
            this.uxZipCode.Location = new System.Drawing.Point(521, 85);
            this.uxZipCode.Name = "uxZipCode";
            this.uxZipCode.Size = new System.Drawing.Size(0, 15);
            this.uxZipCode.TabIndex = 10;
            // 
            // PlayerRoster
            // 
            this.PlayerRoster.AutoSize = true;
            this.PlayerRoster.Location = new System.Drawing.Point(12, 43);
            this.PlayerRoster.Name = "PlayerRoster";
            this.PlayerRoster.Size = new System.Drawing.Size(75, 15);
            this.PlayerRoster.TabIndex = 12;
            this.PlayerRoster.Text = "Player Roster";
            // 
            // uxPlayerRoster
            // 
            this.uxPlayerRoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Position});
            this.uxPlayerRoster.Location = new System.Drawing.Point(12, 61);
            this.uxPlayerRoster.Name = "uxPlayerRoster";
            this.uxPlayerRoster.Size = new System.Drawing.Size(372, 377);
            this.uxPlayerRoster.TabIndex = 13;
            this.uxPlayerRoster.UseCompatibleStateImageBehavior = false;
            this.uxPlayerRoster.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Tag = "First Name";
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Tag = "Last Name";
            this.LastName.Text = "Last Name";
            this.LastName.Width = 150;
            // 
            // Position
            // 
            this.Position.Tag = "Position";
            this.Position.Text = "Position";
            this.Position.Width = 140;
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(644, 415);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(75, 23);
            this.uxExit.TabIndex = 14;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // ViewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxPlayerRoster);
            this.Controls.Add(this.PlayerRoster);
            this.Controls.Add(this.uxZipCode);
            this.Controls.Add(this.uxStateName);
            this.Controls.Add(this.uxCityName);
            this.Controls.Add(this.uxStadiumName);
            this.Controls.Add(this.ZipCode);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.StadiumName);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.uxTeamSelect);
            this.Name = "ViewTeam";
            this.Text = "ViewTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox uxTeamSelect;
        private Label TeamName;
        private Button uxSearch;
        private Label StadiumName;
        private Label City;
        private Label State;
        private Label ZipCode;
        private Label uxStadiumName;
        private Label uxCityName;
        private Label uxStateName;
        private Label uxZipCode;
        private Label PlayerRoster;
        private ListView uxPlayerRoster;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Position;
        private Button uxExit;
    }
}