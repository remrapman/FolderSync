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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ActionTypeLabel = new System.Windows.Forms.Label();
            this.SyncFolderButton = new System.Windows.Forms.Button();
            this.AnalizeButton = new System.Windows.Forms.Button();
            this.ActionTypesComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.includeFilterLabel = new System.Windows.Forms.Label();
            this.excludeFilterLabel = new System.Windows.Forms.Label();
            this.filtersUserControl2 = new FolderSync.FiltersUserControl();
            this.filtersUserControl1 = new FolderSync.FiltersUserControl();
            this.browseFolderUserControl1 = new FolderSync.BrowseFolderUserControl();
            this.browseFolderUserControl2 = new FolderSync.BrowseFolderUserControl();
            this.foldersDifferenceGroupBox = new System.Windows.Forms.GroupBox();
            this.actionsListBox = new System.Windows.Forms.ListBox();
            this.leftFolderListBox = new System.Windows.Forms.ListBox();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.rightFolderListBox = new System.Windows.Forms.ListBox();
            this.SyncSettingsGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.foldersDifferenceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SyncSettingsGroupBox
            // 
            this.SyncSettingsGroupBox.Controls.Add(this.browseFolderUserControl2);
            this.SyncSettingsGroupBox.Controls.Add(this.browseFolderUserControl1);
            this.SyncSettingsGroupBox.Controls.Add(this.CancelButton);
            this.SyncSettingsGroupBox.Controls.Add(this.ActionTypeLabel);
            this.SyncSettingsGroupBox.Controls.Add(this.SyncFolderButton);
            this.SyncSettingsGroupBox.Controls.Add(this.AnalizeButton);
            this.SyncSettingsGroupBox.Controls.Add(this.ActionTypesComboBox);
            this.SyncSettingsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.SyncSettingsGroupBox.Name = "SyncSettingsGroupBox";
            this.SyncSettingsGroupBox.Size = new System.Drawing.Size(916, 203);
            this.SyncSettingsGroupBox.TabIndex = 0;
            this.SyncSettingsGroupBox.TabStop = false;
            this.SyncSettingsGroupBox.Text = "Sync Setting";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(493, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ActionTypeLabel
            // 
            this.ActionTypeLabel.AutoSize = true;
            this.ActionTypeLabel.Location = new System.Drawing.Point(351, 99);
            this.ActionTypeLabel.Name = "ActionTypeLabel";
            this.ActionTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.ActionTypeLabel.TabIndex = 6;
            this.ActionTypeLabel.Text = "Action Type:";
            // 
            // SyncFolderButton
            // 
            this.SyncFolderButton.Location = new System.Drawing.Point(347, 161);
            this.SyncFolderButton.Name = "SyncFolderButton";
            this.SyncFolderButton.Size = new System.Drawing.Size(246, 23);
            this.SyncFolderButton.TabIndex = 5;
            this.SyncFolderButton.Text = "Sync Folders";
            this.SyncFolderButton.UseVisualStyleBackColor = true;
            // 
            // AnalizeButton
            // 
            this.AnalizeButton.Location = new System.Drawing.Point(347, 127);
            this.AnalizeButton.Name = "AnalizeButton";
            this.AnalizeButton.Size = new System.Drawing.Size(100, 23);
            this.AnalizeButton.TabIndex = 3;
            this.AnalizeButton.Text = "Analize";
            this.AnalizeButton.UseVisualStyleBackColor = true;
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
            this.ActionTypesComboBox.Location = new System.Drawing.Point(424, 96);
            this.ActionTypesComboBox.Name = "ActionTypesComboBox";
            this.ActionTypesComboBox.Size = new System.Drawing.Size(169, 21);
            this.ActionTypesComboBox.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(933, 656);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.actionsLabel);
            this.tabPage1.Controls.Add(this.actionsListBox);
            this.tabPage1.Controls.Add(this.foldersDifferenceGroupBox);
            this.tabPage1.Controls.Add(this.SyncSettingsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.excludeFilterLabel);
            this.tabPage2.Controls.Add(this.includeFilterLabel);
            this.tabPage2.Controls.Add(this.filtersUserControl2);
            this.tabPage2.Controls.Add(this.filtersUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // includeFilterLabel
            // 
            this.includeFilterLabel.AutoSize = true;
            this.includeFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.includeFilterLabel.Location = new System.Drawing.Point(30, 11);
            this.includeFilterLabel.Name = "includeFilterLabel";
            this.includeFilterLabel.Size = new System.Drawing.Size(94, 18);
            this.includeFilterLabel.TabIndex = 0;
            this.includeFilterLabel.Text = "Include Filter:";
            // 
            // excludeFilterLabel
            // 
            this.excludeFilterLabel.AutoSize = true;
            this.excludeFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excludeFilterLabel.Location = new System.Drawing.Point(512, 11);
            this.excludeFilterLabel.Name = "excludeFilterLabel";
            this.excludeFilterLabel.Size = new System.Drawing.Size(100, 18);
            this.excludeFilterLabel.TabIndex = 3;
            this.excludeFilterLabel.Text = "Exclude Filter:";
            // 
            // filtersUserControl2
            // 
            this.filtersUserControl2.Location = new System.Drawing.Point(492, 39);
            this.filtersUserControl2.Name = "filtersUserControl2";
            this.filtersUserControl2.Size = new System.Drawing.Size(417, 473);
            this.filtersUserControl2.TabIndex = 2;
            // 
            // filtersUserControl1
            // 
            this.filtersUserControl1.Location = new System.Drawing.Point(10, 39);
            this.filtersUserControl1.Name = "filtersUserControl1";
            this.filtersUserControl1.Size = new System.Drawing.Size(417, 483);
            this.filtersUserControl1.TabIndex = 1;
            // 
            // browseFolderUserControl1
            // 
            this.browseFolderUserControl1.Location = new System.Drawing.Point(7, 20);
            this.browseFolderUserControl1.Name = "browseFolderUserControl1";
            this.browseFolderUserControl1.Size = new System.Drawing.Size(440, 60);
            this.browseFolderUserControl1.TabIndex = 10;
            // 
            // browseFolderUserControl2
            // 
            this.browseFolderUserControl2.Location = new System.Drawing.Point(470, 20);
            this.browseFolderUserControl2.Name = "browseFolderUserControl2";
            this.browseFolderUserControl2.Size = new System.Drawing.Size(440, 60);
            this.browseFolderUserControl2.TabIndex = 11;
            // 
            // foldersDifferenceGroupBox
            // 
            this.foldersDifferenceGroupBox.Controls.Add(this.rightFolderListBox);
            this.foldersDifferenceGroupBox.Controls.Add(this.leftFolderListBox);
            this.foldersDifferenceGroupBox.Location = new System.Drawing.Point(7, 216);
            this.foldersDifferenceGroupBox.Name = "foldersDifferenceGroupBox";
            this.foldersDifferenceGroupBox.Size = new System.Drawing.Size(912, 237);
            this.foldersDifferenceGroupBox.TabIndex = 1;
            this.foldersDifferenceGroupBox.TabStop = false;
            this.foldersDifferenceGroupBox.Text = "Folders Difference:";
            // 
            // actionsListBox
            // 
            this.actionsListBox.FormattingEnabled = true;
            this.actionsListBox.Location = new System.Drawing.Point(10, 485);
            this.actionsListBox.Name = "actionsListBox";
            this.actionsListBox.Size = new System.Drawing.Size(903, 134);
            this.actionsListBox.TabIndex = 2;
            // 
            // leftFolderListBox
            // 
            this.leftFolderListBox.FormattingEnabled = true;
            this.leftFolderListBox.Location = new System.Drawing.Point(7, 20);
            this.leftFolderListBox.Name = "leftFolderListBox";
            this.leftFolderListBox.Size = new System.Drawing.Size(436, 212);
            this.leftFolderListBox.TabIndex = 0;
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.actionsLabel.Location = new System.Drawing.Point(11, 467);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(49, 15);
            this.actionsLabel.TabIndex = 3;
            this.actionsLabel.Text = "Actions:";
            // 
            // rightFolderListBox
            // 
            this.rightFolderListBox.FormattingEnabled = true;
            this.rightFolderListBox.Location = new System.Drawing.Point(466, 19);
            this.rightFolderListBox.Name = "rightFolderListBox";
            this.rightFolderListBox.Size = new System.Drawing.Size(440, 212);
            this.rightFolderListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 681);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "REM - Sync Folder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SyncSettingsGroupBox.ResumeLayout(false);
            this.SyncSettingsGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.foldersDifferenceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SyncSettingsGroupBox;
        private System.Windows.Forms.Label ActionTypeLabel;
        private System.Windows.Forms.Button SyncFolderButton;
        private System.Windows.Forms.Button AnalizeButton;
        private System.Windows.Forms.ComboBox ActionTypesComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label excludeFilterLabel;
        private FiltersUserControl filtersUserControl2;
        private FiltersUserControl filtersUserControl1;
        private System.Windows.Forms.Label includeFilterLabel;
        private BrowseFolderUserControl browseFolderUserControl2;
        private BrowseFolderUserControl browseFolderUserControl1;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.ListBox actionsListBox;
        private System.Windows.Forms.GroupBox foldersDifferenceGroupBox;
        private System.Windows.Forms.ListBox rightFolderListBox;
        private System.Windows.Forms.ListBox leftFolderListBox;
    }
}

