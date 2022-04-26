namespace UserInterface
{
    partial class AddEditForm
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
            this.uxCloseForm = new System.Windows.Forms.Button();
            this.uxDeleteEntry = new System.Windows.Forms.Button();
            this.uxAddEditEntry = new System.Windows.Forms.Button();
            this.uxItemSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxCloseForm
            // 
            this.uxCloseForm.Location = new System.Drawing.Point(12, 41);
            this.uxCloseForm.Name = "uxCloseForm";
            this.uxCloseForm.Size = new System.Drawing.Size(75, 23);
            this.uxCloseForm.TabIndex = 1;
            this.uxCloseForm.Text = "Back";
            this.uxCloseForm.UseVisualStyleBackColor = true;
            // 
            // uxDeleteEntry
            // 
            this.uxDeleteEntry.Enabled = false;
            this.uxDeleteEntry.Location = new System.Drawing.Point(93, 41);
            this.uxDeleteEntry.Name = "uxDeleteEntry";
            this.uxDeleteEntry.Size = new System.Drawing.Size(75, 23);
            this.uxDeleteEntry.TabIndex = 2;
            this.uxDeleteEntry.Text = "Delete";
            this.uxDeleteEntry.UseVisualStyleBackColor = true;
            // 
            // uxAddEditEntry
            // 
            this.uxAddEditEntry.Enabled = false;
            this.uxAddEditEntry.Location = new System.Drawing.Point(174, 41);
            this.uxAddEditEntry.Name = "uxAddEditEntry";
            this.uxAddEditEntry.Size = new System.Drawing.Size(75, 23);
            this.uxAddEditEntry.TabIndex = 3;
            this.uxAddEditEntry.Text = "Add/Edit";
            this.uxAddEditEntry.UseVisualStyleBackColor = true;
            // 
            // uxItemSelect
            // 
            this.uxItemSelect.FormattingEnabled = true;
            this.uxItemSelect.Location = new System.Drawing.Point(12, 12);
            this.uxItemSelect.MaxDropDownItems = 10;
            this.uxItemSelect.Name = "uxItemSelect";
            this.uxItemSelect.Size = new System.Drawing.Size(237, 23);
            this.uxItemSelect.TabIndex = 4;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 73);
            this.Controls.Add(this.uxItemSelect);
            this.Controls.Add(this.uxAddEditEntry);
            this.Controls.Add(this.uxDeleteEntry);
            this.Controls.Add(this.uxCloseForm);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button uxCloseForm;
        private Button uxDeleteEntry;
        private Button uxAddEditEntry;
        private ComboBox uxItemSelect;
    }
}