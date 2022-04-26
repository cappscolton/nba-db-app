namespace UserInterface
{
    partial class Form1
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
            this.uxTitelLabel = new System.Windows.Forms.Label();
            this.uxAddEditPlayer = new System.Windows.Forms.Button();
            this.uxAddEditTeam = new System.Windows.Forms.Button();
            this.uxLookupPlayer = new System.Windows.Forms.Button();
            this.uxLookupTeam = new System.Windows.Forms.Button();
            this.uxAddEditGame = new System.Windows.Forms.Button();
            this.uxLookupGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTitelLabel
            // 
            this.uxTitelLabel.AutoSize = true;
            this.uxTitelLabel.Location = new System.Drawing.Point(64, 9);
            this.uxTitelLabel.Name = "uxTitelLabel";
            this.uxTitelLabel.Size = new System.Drawing.Size(123, 15);
            this.uxTitelLabel.TabIndex = 0;
            this.uxTitelLabel.Text = "NBA Statistics Lookup";
            // 
            // uxAddEditPlayer
            // 
            this.uxAddEditPlayer.Location = new System.Drawing.Point(64, 42);
            this.uxAddEditPlayer.Name = "uxAddEditPlayer";
            this.uxAddEditPlayer.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditPlayer.TabIndex = 1;
            this.uxAddEditPlayer.Text = "Add/Edit Player";
            this.uxAddEditPlayer.UseVisualStyleBackColor = true;
            // 
            // uxAddEditTeam
            // 
            this.uxAddEditTeam.Location = new System.Drawing.Point(64, 100);
            this.uxAddEditTeam.Name = "uxAddEditTeam";
            this.uxAddEditTeam.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditTeam.TabIndex = 2;
            this.uxAddEditTeam.Text = "Add/Edit Team";
            this.uxAddEditTeam.UseVisualStyleBackColor = true;
            // 
            // uxLookupPlayer
            // 
            this.uxLookupPlayer.Location = new System.Drawing.Point(64, 71);
            this.uxLookupPlayer.Name = "uxLookupPlayer";
            this.uxLookupPlayer.Size = new System.Drawing.Size(123, 23);
            this.uxLookupPlayer.TabIndex = 3;
            this.uxLookupPlayer.Text = "Lookup Player";
            this.uxLookupPlayer.UseVisualStyleBackColor = true;
            // 
            // uxLookupTeam
            // 
            this.uxLookupTeam.Location = new System.Drawing.Point(64, 129);
            this.uxLookupTeam.Name = "uxLookupTeam";
            this.uxLookupTeam.Size = new System.Drawing.Size(123, 23);
            this.uxLookupTeam.TabIndex = 4;
            this.uxLookupTeam.Text = "Lookup Team";
            this.uxLookupTeam.UseVisualStyleBackColor = true;
            // 
            // uxAddEditGame
            // 
            this.uxAddEditGame.Location = new System.Drawing.Point(64, 158);
            this.uxAddEditGame.Name = "uxAddEditGame";
            this.uxAddEditGame.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditGame.TabIndex = 5;
            this.uxAddEditGame.Text = "Add/Edit Game";
            this.uxAddEditGame.UseVisualStyleBackColor = true;
            // 
            // uxLookupGame
            // 
            this.uxLookupGame.Location = new System.Drawing.Point(64, 187);
            this.uxLookupGame.Name = "uxLookupGame";
            this.uxLookupGame.Size = new System.Drawing.Size(123, 23);
            this.uxLookupGame.TabIndex = 6;
            this.uxLookupGame.Text = "Lookup Game";
            this.uxLookupGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 226);
            this.Controls.Add(this.uxLookupGame);
            this.Controls.Add(this.uxAddEditGame);
            this.Controls.Add(this.uxLookupTeam);
            this.Controls.Add(this.uxLookupPlayer);
            this.Controls.Add(this.uxAddEditTeam);
            this.Controls.Add(this.uxAddEditPlayer);
            this.Controls.Add(this.uxTitelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label uxTitelLabel;
        private Button uxAddEditPlayer;
        private Button uxAddEditTeam;
        private Button uxLookupPlayer;
        private Button uxLookupTeam;
        private Button uxAddEditGame;
        private Button uxLookupGame;
    }
}