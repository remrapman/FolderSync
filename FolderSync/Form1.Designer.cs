namespace FolderSync
{
    partial class Form1
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
            this.SyncSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.LeftFolderTextBox = new System.Windows.Forms.TextBox();
            this.LeftFolderBrowseButton = new System.Windows.Forms.Button();
            this.ActionTypesComboBox = new System.Windows.Forms.ComboBox();
            this.AnalizeButton = new System.Windows.Forms.Button();
            this.SyncFolderButton = new System.Windows.Forms.Button();
            this.ActionTypeLabel = new System.Windows.Forms.Label();
            this.RightFolderTextBox = new System.Windows.Forms.TextBox();
            this.RightFolderBrowseButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FoldersDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LeftFolderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightFolderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SyncSettingsGroupBox.SuspendLayout();
            this.FoldersDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SyncSettingsGroupBox
            // 
            this.SyncSettingsGroupBox.Controls.Add(this.CancelButton);
            this.SyncSettingsGroupBox.Controls.Add(this.RightFolderBrowseButton);
            this.SyncSettingsGroupBox.Controls.Add(this.RightFolderTextBox);
            this.SyncSettingsGroupBox.Controls.Add(this.ActionTypeLabel);
            this.SyncSettingsGroupBox.Controls.Add(this.SyncFolderButton);
            this.SyncSettingsGroupBox.Controls.Add(this.AnalizeButton);
            this.SyncSettingsGroupBox.Controls.Add(this.ActionTypesComboBox);
            this.SyncSettingsGroupBox.Controls.Add(this.LeftFolderBrowseButton);
            this.SyncSettingsGroupBox.Controls.Add(this.LeftFolderTextBox);
            this.SyncSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SyncSettingsGroupBox.Name = "SyncSettingsGroupBox";
            this.SyncSettingsGroupBox.Size = new System.Drawing.Size(934, 176);
            this.SyncSettingsGroupBox.TabIndex = 0;
            this.SyncSettingsGroupBox.TabStop = false;
            this.SyncSettingsGroupBox.Text = "Sync Setting";
            // 
            // LeftFolderTextBox
            // 
            this.LeftFolderTextBox.Location = new System.Drawing.Point(20, 28);
            this.LeftFolderTextBox.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.LeftFolderTextBox.Name = "LeftFolderTextBox";
            this.LeftFolderTextBox.Size = new System.Drawing.Size(395, 20);
            this.LeftFolderTextBox.TabIndex = 0;
            // 
            // LeftFolderBrowseButton
            // 
            this.LeftFolderBrowseButton.Location = new System.Drawing.Point(421, 26);
            this.LeftFolderBrowseButton.Name = "LeftFolderBrowseButton";
            this.LeftFolderBrowseButton.Size = new System.Drawing.Size(26, 23);
            this.LeftFolderBrowseButton.TabIndex = 1;
            this.LeftFolderBrowseButton.Text = "...";
            this.LeftFolderBrowseButton.UseVisualStyleBackColor = true;
            // 
            // ActionTypesComboBox
            // 
            this.ActionTypesComboBox.FormattingEnabled = true;
            this.ActionTypesComboBox.Items.AddRange(new object[] {
            "<<Update Left",
            ">>Update Right",
            "<>Update Both",
            "<=Replace To Left",
            "=>Replace To Right"});
            this.ActionTypesComboBox.Location = new System.Drawing.Point(421, 75);
            this.ActionTypesComboBox.Name = "ActionTypesComboBox";
            this.ActionTypesComboBox.Size = new System.Drawing.Size(169, 21);
            this.ActionTypesComboBox.TabIndex = 2;
            // 
            // AnalizeButton
            // 
            this.AnalizeButton.Location = new System.Drawing.Point(344, 106);
            this.AnalizeButton.Name = "AnalizeButton";
            this.AnalizeButton.Size = new System.Drawing.Size(100, 23);
            this.AnalizeButton.TabIndex = 3;
            this.AnalizeButton.Text = "Analize";
            this.AnalizeButton.UseVisualStyleBackColor = true;
            // 
            // SyncFolderButton
            // 
            this.SyncFolderButton.Location = new System.Drawing.Point(344, 140);
            this.SyncFolderButton.Name = "SyncFolderButton";
            this.SyncFolderButton.Size = new System.Drawing.Size(246, 23);
            this.SyncFolderButton.TabIndex = 5;
            this.SyncFolderButton.Text = "Sync Folders";
            this.SyncFolderButton.UseVisualStyleBackColor = true;
            // 
            // ActionTypeLabel
            // 
            this.ActionTypeLabel.AutoSize = true;
            this.ActionTypeLabel.Location = new System.Drawing.Point(348, 78);
            this.ActionTypeLabel.Name = "ActionTypeLabel";
            this.ActionTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.ActionTypeLabel.TabIndex = 6;
            this.ActionTypeLabel.Text = "Action Type:";
            // 
            // RightFolderTextBox
            // 
            this.RightFolderTextBox.Location = new System.Drawing.Point(490, 28);
            this.RightFolderTextBox.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.RightFolderTextBox.Name = "RightFolderTextBox";
            this.RightFolderTextBox.Size = new System.Drawing.Size(395, 20);
            this.RightFolderTextBox.TabIndex = 7;
            // 
            // RightFolderBrowseButton
            // 
            this.RightFolderBrowseButton.Location = new System.Drawing.Point(891, 26);
            this.RightFolderBrowseButton.Margin = new System.Windows.Forms.Padding(3, 3, 23, 3);
            this.RightFolderBrowseButton.Name = "RightFolderBrowseButton";
            this.RightFolderBrowseButton.Size = new System.Drawing.Size(26, 23);
            this.RightFolderBrowseButton.TabIndex = 8;
            this.RightFolderBrowseButton.Text = "...";
            this.RightFolderBrowseButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(490, 106);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // FoldersDataGroupBox
            // 
            this.FoldersDataGroupBox.Controls.Add(this.LeftFolderTableLayoutPanel);
            this.FoldersDataGroupBox.Controls.Add(this.RightFolderTableLayoutPanel);
            this.FoldersDataGroupBox.Location = new System.Drawing.Point(12, 194);
            this.FoldersDataGroupBox.Name = "FoldersDataGroupBox";
            this.FoldersDataGroupBox.Size = new System.Drawing.Size(934, 475);
            this.FoldersDataGroupBox.TabIndex = 1;
            this.FoldersDataGroupBox.TabStop = false;
            this.FoldersDataGroupBox.Text = "Folders Data";
            // 
            // LeftFolderTableLayoutPanel
            // 
            this.LeftFolderTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LeftFolderTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.LeftFolderTableLayoutPanel.ColumnCount = 3;
            this.LeftFolderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.LeftFolderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LeftFolderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LeftFolderTableLayoutPanel.Location = new System.Drawing.Point(20, 19);
            this.LeftFolderTableLayoutPanel.Name = "LeftFolderTableLayoutPanel";
            this.LeftFolderTableLayoutPanel.RowCount = 2;
            this.LeftFolderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LeftFolderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LeftFolderTableLayoutPanel.Size = new System.Drawing.Size(427, 450);
            this.LeftFolderTableLayoutPanel.TabIndex = 2;
            // 
            // RightFolderTableLayoutPanel
            // 
            this.RightFolderTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RightFolderTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.RightFolderTableLayoutPanel.ColumnCount = 3;
            this.RightFolderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.RightFolderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.RightFolderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightFolderTableLayoutPanel.Location = new System.Drawing.Point(490, 19);
            this.RightFolderTableLayoutPanel.Name = "RightFolderTableLayoutPanel";
            this.RightFolderTableLayoutPanel.RowCount = 2;
            this.RightFolderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightFolderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightFolderTableLayoutPanel.Size = new System.Drawing.Size(427, 450);
            this.RightFolderTableLayoutPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 681);
            this.Controls.Add(this.FoldersDataGroupBox);
            this.Controls.Add(this.SyncSettingsGroupBox);
            this.Name = "Form1";
            this.Text = "REM - Sync Folder";
            this.SyncSettingsGroupBox.ResumeLayout(false);
            this.SyncSettingsGroupBox.PerformLayout();
            this.FoldersDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SyncSettingsGroupBox;
        private System.Windows.Forms.Label ActionTypeLabel;
        private System.Windows.Forms.Button SyncFolderButton;
        private System.Windows.Forms.Button AnalizeButton;
        private System.Windows.Forms.ComboBox ActionTypesComboBox;
        private System.Windows.Forms.Button LeftFolderBrowseButton;
        private System.Windows.Forms.TextBox LeftFolderTextBox;
        private System.Windows.Forms.TextBox RightFolderTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RightFolderBrowseButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox FoldersDataGroupBox;
        private System.Windows.Forms.TableLayoutPanel RightFolderTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel LeftFolderTableLayoutPanel;
    }
}

