namespace P5
{
    partial class FormDashboardIssue
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
            this.numOfIssuesLabel = new System.Windows.Forms.Label();
            this.numOfIssuesDisplayLabel = new System.Windows.Forms.Label();
            this.issueByMonthListBox = new System.Windows.Forms.ListBox();
            this.issueByDiscovererListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.issueByMonthLabel = new System.Windows.Forms.Label();
            this.issueByDiscovererLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOfIssuesLabel
            // 
            this.numOfIssuesLabel.AutoSize = true;
            this.numOfIssuesLabel.Location = new System.Drawing.Point(73, 30);
            this.numOfIssuesLabel.Name = "numOfIssuesLabel";
            this.numOfIssuesLabel.Size = new System.Drawing.Size(119, 13);
            this.numOfIssuesLabel.TabIndex = 0;
            this.numOfIssuesLabel.Text = "Total Number of Issues:";
            // 
            // numOfIssuesDisplayLabel
            // 
            this.numOfIssuesDisplayLabel.AutoSize = true;
            this.numOfIssuesDisplayLabel.Location = new System.Drawing.Point(198, 30);
            this.numOfIssuesDisplayLabel.Name = "numOfIssuesDisplayLabel";
            this.numOfIssuesDisplayLabel.Size = new System.Drawing.Size(13, 13);
            this.numOfIssuesDisplayLabel.TabIndex = 1;
            this.numOfIssuesDisplayLabel.Text = "0";
            // 
            // issueByMonthListBox
            // 
            this.issueByMonthListBox.FormattingEnabled = true;
            this.issueByMonthListBox.Location = new System.Drawing.Point(31, 88);
            this.issueByMonthListBox.Name = "issueByMonthListBox";
            this.issueByMonthListBox.Size = new System.Drawing.Size(255, 134);
            this.issueByMonthListBox.TabIndex = 2;
            // 
            // issueByDiscovererListBox
            // 
            this.issueByDiscovererListBox.FormattingEnabled = true;
            this.issueByDiscovererListBox.Location = new System.Drawing.Point(31, 258);
            this.issueByDiscovererListBox.Name = "issueByDiscovererListBox";
            this.issueByDiscovererListBox.Size = new System.Drawing.Size(255, 134);
            this.issueByDiscovererListBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(211, 412);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // issueByMonthLabel
            // 
            this.issueByMonthLabel.AutoSize = true;
            this.issueByMonthLabel.Location = new System.Drawing.Point(28, 72);
            this.issueByMonthLabel.Name = "issueByMonthLabel";
            this.issueByMonthLabel.Size = new System.Drawing.Size(83, 13);
            this.issueByMonthLabel.TabIndex = 5;
            this.issueByMonthLabel.Text = "Issue By Month:";
            // 
            // issueByDiscovererLabel
            // 
            this.issueByDiscovererLabel.AutoSize = true;
            this.issueByDiscovererLabel.Location = new System.Drawing.Point(28, 242);
            this.issueByDiscovererLabel.Name = "issueByDiscovererLabel";
            this.issueByDiscovererLabel.Size = new System.Drawing.Size(104, 13);
            this.issueByDiscovererLabel.TabIndex = 6;
            this.issueByDiscovererLabel.Text = "Issue By Discoverer:";
            // 
            // FormDashboardIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 447);
            this.Controls.Add(this.issueByDiscovererLabel);
            this.Controls.Add(this.issueByMonthLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.issueByDiscovererListBox);
            this.Controls.Add(this.issueByMonthListBox);
            this.Controls.Add(this.numOfIssuesDisplayLabel);
            this.Controls.Add(this.numOfIssuesLabel);
            this.Name = "FormDashboardIssue";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormDashboardIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfIssuesLabel;
        private System.Windows.Forms.Label numOfIssuesDisplayLabel;
        private System.Windows.Forms.ListBox issueByMonthListBox;
        private System.Windows.Forms.ListBox issueByDiscovererListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label issueByMonthLabel;
        private System.Windows.Forms.Label issueByDiscovererLabel;
    }
}