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
            this.uxExit.Location = new System.Drawing.Point(12, 77);
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
            this.uxAddPlayer.Location = new System.Drawing.Point(93, 77);
            this.uxAddPlayer.Name = "uxAddPlayer";
            this.uxAddPlayer.Size = new System.Drawing.Size(148, 23);
            this.uxAddPlayer.TabIndex = 5;
            this.uxAddPlayer.Text = "Add Player";
            this.uxAddPlayer.UseVisualStyleBackColor = true;
            this.uxAddPlayer.Click += new System.EventHandler(this.uxAddPlayer_Click);
            // 
            // AddEditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 112);
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
    }
}