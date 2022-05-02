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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.uxAddEditPlayer.Location = new System.Drawing.Point(12, 42);
            this.uxAddEditPlayer.Name = "uxAddEditPlayer";
            this.uxAddEditPlayer.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditPlayer.TabIndex = 1;
            this.uxAddEditPlayer.Text = "Add/Edit Player";
            this.uxAddEditPlayer.UseVisualStyleBackColor = true;
            // 
            // uxAddEditTeam
            // 
            this.uxAddEditTeam.Location = new System.Drawing.Point(12, 100);
            this.uxAddEditTeam.Name = "uxAddEditTeam";
            this.uxAddEditTeam.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditTeam.TabIndex = 2;
            this.uxAddEditTeam.Text = "Add/Edit Team";
            this.uxAddEditTeam.UseVisualStyleBackColor = true;
            // 
            // uxLookupPlayer
            // 
            this.uxLookupPlayer.Location = new System.Drawing.Point(12, 71);
            this.uxLookupPlayer.Name = "uxLookupPlayer";
            this.uxLookupPlayer.Size = new System.Drawing.Size(123, 23);
            this.uxLookupPlayer.TabIndex = 3;
            this.uxLookupPlayer.Text = "Lookup Player";
            this.uxLookupPlayer.UseVisualStyleBackColor = true;
            this.uxLookupPlayer.Click += new System.EventHandler(this.uxLookupPlayer_Click);
            // 
            // uxLookupTeam
            // 
            this.uxLookupTeam.Location = new System.Drawing.Point(12, 129);
            this.uxLookupTeam.Name = "uxLookupTeam";
            this.uxLookupTeam.Size = new System.Drawing.Size(123, 23);
            this.uxLookupTeam.TabIndex = 4;
            this.uxLookupTeam.Text = "Lookup Team";
            this.uxLookupTeam.UseVisualStyleBackColor = true;
            this.uxLookupTeam.Click += new System.EventHandler(this.uxLookupTeam_Click);
            // 
            // uxAddEditGame
            // 
            this.uxAddEditGame.Location = new System.Drawing.Point(12, 158);
            this.uxAddEditGame.Name = "uxAddEditGame";
            this.uxAddEditGame.Size = new System.Drawing.Size(123, 23);
            this.uxAddEditGame.TabIndex = 5;
            this.uxAddEditGame.Text = "Add/Edit Game";
            this.uxAddEditGame.UseVisualStyleBackColor = true;
            // 
            // uxLookupGame
            // 
            this.uxLookupGame.Location = new System.Drawing.Point(12, 187);
            this.uxLookupGame.Name = "uxLookupGame";
            this.uxLookupGame.Size = new System.Drawing.Size(123, 23);
            this.uxLookupGame.TabIndex = 6;
            this.uxLookupGame.Text = "Lookup Game";
            this.uxLookupGame.UseVisualStyleBackColor = true;
            this.uxLookupGame.Click += new System.EventHandler(this.uxLookupGame_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(576, 404);
            this.dataGridView1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 266);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 428);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxLookupGame);
            this.Controls.Add(this.uxAddEditGame);
            this.Controls.Add(this.uxLookupTeam);
            this.Controls.Add(this.uxLookupPlayer);
            this.Controls.Add(this.uxAddEditTeam);
            this.Controls.Add(this.uxAddEditPlayer);
            this.Controls.Add(this.uxTitelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}