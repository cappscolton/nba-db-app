namespace UserInterface
{
    partial class AddEditPlayer
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxAddPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxTeamComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 43);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(85, 6);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(156, 23);
            this.uxFirstName.TabIndex = 2;
            this.uxFirstName.TextChanged += new System.EventHandler(this.EnableCompleteButton);
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(85, 40);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(156, 23);
            this.uxLastName.TabIndex = 3;
            this.uxLastName.TextChanged += new System.EventHandler(this.EnableCompleteButton);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(11, 144);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(75, 23);
            this.uxExit.TabIndex = 4;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxAddPlayer
            // 
            this.uxAddPlayer.Enabled = false;
            this.uxAddPlayer.Location = new System.Drawing.Point(92, 144);
            this.uxAddPlayer.Name = "uxAddPlayer";
            this.uxAddPlayer.Size = new System.Drawing.Size(148, 23);
            this.uxAddPlayer.TabIndex = 5;
            this.uxAddPlayer.Text = "Confirm";
            this.uxAddPlayer.UseVisualStyleBackColor = true;
            this.uxAddPlayer.Click += new System.EventHandler(this.uxAddPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team:";
            // 
            // uxTeamComboBox
            // 
            this.uxTeamComboBox.FormattingEnabled = true;
            this.uxTeamComboBox.Location = new System.Drawing.Point(85, 70);
            this.uxTeamComboBox.Name = "uxTeamComboBox";
            this.uxTeamComboBox.Size = new System.Drawing.Size(155, 23);
            this.uxTeamComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // uxPosition
            // 
            this.uxPosition.Location = new System.Drawing.Point(85, 103);
            this.uxPosition.Name = "uxPosition";
            this.uxPosition.Size = new System.Drawing.Size(100, 23);
            this.uxPosition.TabIndex = 9;
            // 
            // AddEditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 222);
            this.Controls.Add(this.uxPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxTeamComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxAddPlayer);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "AddEditPlayer";
            this.Text = "AddEditPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox uxFirstName;
        private TextBox uxLastName;
        private Button uxExit;
        private Button uxAddPlayer;
        private Label label1;
        private ComboBox uxTeamComboBox;
        private Label label2;
        private TextBox uxPosition;
    }
}