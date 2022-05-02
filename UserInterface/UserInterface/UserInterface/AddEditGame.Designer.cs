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
            this.uxDate = new System.Windows.Forms.Label();
            this.uxDateSelect = new System.Windows.Forms.DateTimePicker();
            this.uxSeasonSelect = new System.Windows.Forms.ComboBox();
            this.uxSeason = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxComplete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDate
            // 
            this.uxDate.AutoSize = true;
            this.uxDate.Location = new System.Drawing.Point(15, 175);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(72, 15);
            this.uxDate.TabIndex = 8;
            this.uxDate.Text = "Date Played:";
            // 
            // uxDateSelect
            // 
            this.uxDateSelect.CustomFormat = "dd MMM yyyy";
            this.uxDateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxDateSelect.Location = new System.Drawing.Point(93, 169);
            this.uxDateSelect.Name = "uxDateSelect";
            this.uxDateSelect.Size = new System.Drawing.Size(148, 23);
            this.uxDateSelect.TabIndex = 9;
            // 
            // uxSeasonSelect
            // 
            this.uxSeasonSelect.FormattingEnabled = true;
            this.uxSeasonSelect.Location = new System.Drawing.Point(391, 169);
            this.uxSeasonSelect.Name = "uxSeasonSelect";
            this.uxSeasonSelect.Size = new System.Drawing.Size(121, 23);
            this.uxSeasonSelect.TabIndex = 11;
            // 
            // uxSeason
            // 
            this.uxSeason.AutoSize = true;
            this.uxSeason.Location = new System.Drawing.Point(338, 172);
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
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // AddEditGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 239);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxComplete);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxSeasonSelect);
            this.Controls.Add(this.uxSeason);
            this.Controls.Add(this.uxDateSelect);
            this.Controls.Add(this.uxDate);
            this.Name = "AddEditGame";
            this.Text = "AddEditGame";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label uxDate;
        private DateTimePicker uxDateSelect;
        private ComboBox uxSeasonSelect;
        private Label uxSeason;
        private Button uxCancel;
        private Button uxComplete;
        private DataGridView dataGridView1;
    }
}