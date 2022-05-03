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
            this.uxLookupPlayer = new System.Windows.Forms.Button();
            this.uxLookupTeam = new System.Windows.Forms.Button();
            this.uxLookupGame = new System.Windows.Forms.Button();
            this.uxLookup = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uxReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTitelLabel
            // 
            this.uxTitelLabel.AutoSize = true;
            this.uxTitelLabel.Location = new System.Drawing.Point(12, 9);
            this.uxTitelLabel.Name = "uxTitelLabel";
            this.uxTitelLabel.Size = new System.Drawing.Size(123, 15);
            this.uxTitelLabel.TabIndex = 0;
            this.uxTitelLabel.Text = "NBA Statistics Lookup";
            // 
            // uxAddEditPlayer
            // 
            this.uxAddEditPlayer.Location = new System.Drawing.Point(12, 31);
            this.uxAddEditPlayer.Name = "uxAddEditPlayer";
            this.uxAddEditPlayer.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditPlayer.TabIndex = 1;
            this.uxAddEditPlayer.Text = "Add Player";
            this.uxAddEditPlayer.UseVisualStyleBackColor = true;
            this.uxAddEditPlayer.Click += new System.EventHandler(this.uxAddEditPlayer_Click);
            // 
            // uxLookupPlayer
            // 
            this.uxLookupPlayer.Location = new System.Drawing.Point(141, 31);
            this.uxLookupPlayer.Name = "uxLookupPlayer";
            this.uxLookupPlayer.Size = new System.Drawing.Size(123, 23);
            this.uxLookupPlayer.TabIndex = 3;
            this.uxLookupPlayer.Text = "Lookup Player";
            this.uxLookupPlayer.UseVisualStyleBackColor = true;
            this.uxLookupPlayer.Click += new System.EventHandler(this.uxLookupPlayer_Click);
            // 
            // uxLookupTeam
            // 
            this.uxLookupTeam.Location = new System.Drawing.Point(141, 60);
            this.uxLookupTeam.Name = "uxLookupTeam";
            this.uxLookupTeam.Size = new System.Drawing.Size(123, 23);
            this.uxLookupTeam.TabIndex = 4;
            this.uxLookupTeam.Text = "Lookup Team";
            this.uxLookupTeam.UseVisualStyleBackColor = true;
            this.uxLookupTeam.Click += new System.EventHandler(this.uxLookupTeam_Click);
            // 
            // uxLookupGame
            // 
            this.uxLookupGame.Location = new System.Drawing.Point(12, 60);
            this.uxLookupGame.Name = "uxLookupGame";
            this.uxLookupGame.Size = new System.Drawing.Size(123, 23);
            this.uxLookupGame.TabIndex = 6;
            this.uxLookupGame.Text = "Lookup Game";
            this.uxLookupGame.UseVisualStyleBackColor = true;
            this.uxLookupGame.Click += new System.EventHandler(this.uxLookupGame_Click);
            // 
            // uxLookup
            // 
            this.uxLookup.FormattingEnabled = true;
            this.uxLookup.Location = new System.Drawing.Point(270, 31);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(121, 23);
            this.uxLookup.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "PlusMinus Rankings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "PER Leaders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Matchup Stats";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uxReset
            // 
            this.uxReset.Location = new System.Drawing.Point(334, 60);
            this.uxReset.Name = "uxReset";
            this.uxReset.Size = new System.Drawing.Size(57, 23);
            this.uxReset.TabIndex = 29;
            this.uxReset.Text = "Reset";
            this.uxReset.UseVisualStyleBackColor = true;
            this.uxReset.Click += new System.EventHandler(this.RestoreDefaults);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 129);
            this.Controls.Add(this.uxReset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uxLookup);
            this.Controls.Add(this.uxLookupGame);
            this.Controls.Add(this.uxLookupTeam);
            this.Controls.Add(this.uxLookupPlayer);
            this.Controls.Add(this.uxAddEditPlayer);
            this.Controls.Add(this.uxTitelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label uxTitelLabel;
        private Button uxAddEditPlayer;
        private Button uxLookupPlayer;
        private Button uxLookupTeam;
        private Button uxLookupGame;
        private ComboBox uxLookup;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button uxReset;
    }
}