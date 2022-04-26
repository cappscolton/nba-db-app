namespace UserInterface
{
    partial class ViewForm
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
            this.uxItemSelect = new System.Windows.Forms.ComboBox();
            this.uxViewEntry = new System.Windows.Forms.Button();
            this.uxCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxItemSelect
            // 
            this.uxItemSelect.FormattingEnabled = true;
            this.uxItemSelect.Location = new System.Drawing.Point(12, 12);
            this.uxItemSelect.MaxDropDownItems = 10;
            this.uxItemSelect.Name = "uxItemSelect";
            this.uxItemSelect.Size = new System.Drawing.Size(237, 23);
            this.uxItemSelect.TabIndex = 8;
            // 
            // uxViewEntry
            // 
            this.uxViewEntry.Enabled = false;
            this.uxViewEntry.Location = new System.Drawing.Point(174, 41);
            this.uxViewEntry.Name = "uxViewEntry";
            this.uxViewEntry.Size = new System.Drawing.Size(75, 23);
            this.uxViewEntry.TabIndex = 7;
            this.uxViewEntry.Text = "View";
            this.uxViewEntry.UseVisualStyleBackColor = true;
            // 
            // uxCloseForm
            // 
            this.uxCloseForm.Location = new System.Drawing.Point(12, 41);
            this.uxCloseForm.Name = "uxCloseForm";
            this.uxCloseForm.Size = new System.Drawing.Size(75, 23);
            this.uxCloseForm.TabIndex = 5;
            this.uxCloseForm.Text = "Back";
            this.uxCloseForm.UseVisualStyleBackColor = true;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 76);
            this.Controls.Add(this.uxItemSelect);
            this.Controls.Add(this.uxViewEntry);
            this.Controls.Add(this.uxCloseForm);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox uxItemSelect;
        private Button uxViewEntry;
        private Button uxCloseForm;
    }
}