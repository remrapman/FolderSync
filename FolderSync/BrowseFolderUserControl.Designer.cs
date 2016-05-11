namespace FolderSync
{
    partial class BrowseFolderUserControl
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
            this.browseFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.browseFolderLlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseFolderTextBox
            // 
            this.browseFolderTextBox.Location = new System.Drawing.Point(3, 32);
            this.browseFolderTextBox.Name = "browseFolderTextBox";
            this.browseFolderTextBox.Size = new System.Drawing.Size(395, 20);
            this.browseFolderTextBox.TabIndex = 0;
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Location = new System.Drawing.Point(404, 30);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(26, 23);
            this.browseFolderButton.TabIndex = 1;
            this.browseFolderButton.Text = "...";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // browseFolderLlabel
            // 
            this.browseFolderLlabel.AutoSize = true;
            this.browseFolderLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseFolderLlabel.Location = new System.Drawing.Point(3, 13);
            this.browseFolderLlabel.Name = "browseFolderLlabel";
            this.browseFolderLlabel.Size = new System.Drawing.Size(86, 16);
            this.browseFolderLlabel.TabIndex = 2;
            this.browseFolderLlabel.Text = "Select Filder:";
            // 
            // BrowseFolderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browseFolderLlabel);
            this.Controls.Add(this.browseFolderButton);
            this.Controls.Add(this.browseFolderTextBox);
            this.Name = "BrowseFolderUserControl";
            this.Size = new System.Drawing.Size(440, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox browseFolderTextBox;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.Label browseFolderLlabel;
    }
}
