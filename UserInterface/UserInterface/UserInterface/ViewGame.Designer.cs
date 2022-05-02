namespace UserInterface
{
    partial class ViewGame
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
            this.uxAwaySelect = new System.Windows.Forms.ComboBox();
            this.uxHomeSelect = new System.Windows.Forms.ComboBox();
            this.uxAtSymbol = new System.Windows.Forms.Label();
            this.uxDateSelect = new System.Windows.Forms.ComboBox();
            this.uxDate = new System.Windows.Forms.Label();
            this.uxDisplayButton = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxAwaySelect
            // 
            this.uxAwaySelect.FormattingEnabled = true;
            this.uxAwaySelect.Location = new System.Drawing.Point(12, 12);
            this.uxAwaySelect.Name = "uxAwaySelect";
            this.uxAwaySelect.Size = new System.Drawing.Size(121, 23);
            this.uxAwaySelect.TabIndex = 0;
            this.uxAwaySelect.Text = "Away Team";
            this.uxAwaySelect.SelectionChangeCommitted += new System.EventHandler(this.EnableFormControls);
            // 
            // uxHomeSelect
            // 
            this.uxHomeSelect.FormattingEnabled = true;
            this.uxHomeSelect.Location = new System.Drawing.Point(163, 12);
            this.uxHomeSelect.Name = "uxHomeSelect";
            this.uxHomeSelect.Size = new System.Drawing.Size(121, 23);
            this.uxHomeSelect.TabIndex = 1;
            this.uxHomeSelect.Text = "Home Team";
            this.uxHomeSelect.SelectionChangeCommitted += new System.EventHandler(this.EnableFormControls);
            // 
            // uxAtSymbol
            // 
            this.uxAtSymbol.AutoSize = true;
            this.uxAtSymbol.Location = new System.Drawing.Point(139, 15);
            this.uxAtSymbol.Name = "uxAtSymbol";
            this.uxAtSymbol.Size = new System.Drawing.Size(18, 15);
            this.uxAtSymbol.TabIndex = 2;
            this.uxAtSymbol.Text = "@";
            // 
            // uxDateSelect
            // 
            this.uxDateSelect.Enabled = false;
            this.uxDateSelect.FormattingEnabled = true;
            this.uxDateSelect.Location = new System.Drawing.Point(90, 63);
            this.uxDateSelect.Name = "uxDateSelect";
            this.uxDateSelect.Size = new System.Drawing.Size(194, 23);
            this.uxDateSelect.TabIndex = 3;
            this.uxDateSelect.SelectionChangeCommitted += new System.EventHandler(this.EnableFormControls);
            // 
            // uxDate
            // 
            this.uxDate.AutoSize = true;
            this.uxDate.Location = new System.Drawing.Point(12, 66);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(72, 15);
            this.uxDate.TabIndex = 9;
            this.uxDate.Text = "Date Played:";
            // 
            // uxDisplayButton
            // 
            this.uxDisplayButton.Enabled = false;
            this.uxDisplayButton.Location = new System.Drawing.Point(138, 117);
            this.uxDisplayButton.Name = "uxDisplayButton";
            this.uxDisplayButton.Size = new System.Drawing.Size(146, 23);
            this.uxDisplayButton.TabIndex = 10;
            this.uxDisplayButton.Text = "Show Information";
            this.uxDisplayButton.UseVisualStyleBackColor = true;
            this.uxDisplayButton.Click += new System.EventHandler(this.uxDisplayButton_Click);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(12, 117);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(57, 23);
            this.uxExit.TabIndex = 27;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxReset
            // 
            this.uxReset.Location = new System.Drawing.Point(75, 117);
            this.uxReset.Name = "uxReset";
            this.uxReset.Size = new System.Drawing.Size(57, 23);
            this.uxReset.TabIndex = 28;
            this.uxReset.Text = "Reset";
            this.uxReset.UseVisualStyleBackColor = true;
            this.uxReset.Click += new System.EventHandler(this.RestoreDefaults);
            // 
            // ViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 154);
            this.Controls.Add(this.uxReset);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxDisplayButton);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxDateSelect);
            this.Controls.Add(this.uxAtSymbol);
            this.Controls.Add(this.uxHomeSelect);
            this.Controls.Add(this.uxAwaySelect);
            this.Name = "ViewGame";
            this.Text = "ViewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox uxAwaySelect;
        private ComboBox uxHomeSelect;
        private Label uxAtSymbol;
        private ComboBox uxDateSelect;
        private Label uxDate;
        private Button uxDisplayButton;
        private Button uxExit;
        private Button uxReset;
    }
}