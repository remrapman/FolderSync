namespace FolderSync
{
    partial class FiltersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemAddedToFilterTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.filterListBox = new System.Windows.Forms.ListBox();
            this.newItemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemAddedToFilterTextBox
            // 
            this.itemAddedToFilterTextBox.Location = new System.Drawing.Point(78, 20);
            this.itemAddedToFilterTextBox.Name = "itemAddedToFilterTextBox";
            this.itemAddedToFilterTextBox.Size = new System.Drawing.Size(284, 20);
            this.itemAddedToFilterTextBox.TabIndex = 0;
            this.itemAddedToFilterTextBox.TextChanged += new System.EventHandler(this.newFilterItemTextBox_TextChanged);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Enabled = false;
            this.addNewItemButton.Location = new System.Drawing.Point(369, 18);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(28, 23);
            this.addNewItemButton.TabIndex = 1;
            this.addNewItemButton.Text = "+";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.EnabledChanged += new System.EventHandler(this.newFilterItemTextBox_TextChanged);
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // filterListBox
            // 
            this.filterListBox.FormattingEnabled = true;
            this.filterListBox.Location = new System.Drawing.Point(20, 58);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.Size = new System.Drawing.Size(377, 394);
            this.filterListBox.TabIndex = 2;
            // 
            // newItemLabel
            // 
            this.newItemLabel.AutoSize = true;
            this.newItemLabel.Location = new System.Drawing.Point(17, 23);
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(55, 13);
            this.newItemLabel.TabIndex = 3;
            this.newItemLabel.Text = "New Item:";
            // 
            // FiltersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newItemLabel);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.addNewItemButton);
            this.Controls.Add(this.itemAddedToFilterTextBox);
            this.Name = "FiltersUserControl";
            this.Size = new System.Drawing.Size(417, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemAddedToFilterTextBox;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.ListBox filterListBox;
        private System.Windows.Forms.Label newItemLabel;
    }
}
