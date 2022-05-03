namespace UserInterface
{
    partial class PERLeaders
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.uxExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Season:";
            // 
            // uxSeasonComboBox
            // 
            this.uxSeasonComboBox.FormattingEnabled = true;
            this.uxSeasonComboBox.Location = new System.Drawing.Point(182, 349);
            this.uxSeasonComboBox.Name = "uxSeasonComboBox";
            this.uxSeasonComboBox.Size = new System.Drawing.Size(121, 23);
            this.uxSeasonComboBox.TabIndex = 6;
            this.uxSeasonComboBox.SelectedIndexChanged += new System.EventHandler(this.uxSeasonComboBox_SelectedIndexChanged);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(12, 349);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(75, 23);
            this.uxExit.TabIndex = 5;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(447, 315);
            this.dataGridView1.TabIndex = 4;
            // 
            // PERLeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSeasonComboBox);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PERLeaders";
            this.Text = "PERLeaders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox uxSeasonComboBox;
        private Button uxExit;
        private DataGridView dataGridView1;
    }
}