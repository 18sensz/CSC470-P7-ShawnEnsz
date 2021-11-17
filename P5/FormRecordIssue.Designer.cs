namespace P5
{
    partial class FormRecordIssue
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
            this.idLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.discoveryDateLabel = new System.Windows.Forms.Label();
            this.discovererLabel = new System.Windows.Forms.Label();
            this.componentLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.discoveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.discovererTextbox = new System.Windows.Forms.TextBox();
            this.componentTextbox = new System.Windows.Forms.TextBox();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.createIssueButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(111, 56);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(100, 82);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // discoveryDateLabel
            // 
            this.discoveryDateLabel.AutoSize = true;
            this.discoveryDateLabel.Location = new System.Drawing.Point(47, 110);
            this.discoveryDateLabel.Name = "discoveryDateLabel";
            this.discoveryDateLabel.Size = new System.Drawing.Size(83, 13);
            this.discoveryDateLabel.TabIndex = 2;
            this.discoveryDateLabel.Text = "Discovery Date:";
            // 
            // discovererLabel
            // 
            this.discovererLabel.AutoSize = true;
            this.discovererLabel.Location = new System.Drawing.Point(69, 137);
            this.discovererLabel.Name = "discovererLabel";
            this.discovererLabel.Size = new System.Drawing.Size(61, 13);
            this.discovererLabel.TabIndex = 3;
            this.discovererLabel.Text = "Discoverer:";
            // 
            // componentLabel
            // 
            this.componentLabel.AutoSize = true;
            this.componentLabel.Location = new System.Drawing.Point(66, 164);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(64, 13);
            this.componentLabel.TabIndex = 4;
            this.componentLabel.Text = "Component:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(93, 195);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Satus:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(93, 220);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(90, 13);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Initial Description:";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(133, 242);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(349, 238);
            this.descriptionTextbox.TabIndex = 7;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(133, 53);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.ReadOnly = true;
            this.idTextbox.Size = new System.Drawing.Size(50, 20);
            this.idTextbox.TabIndex = 8;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(133, 79);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(349, 20);
            this.titleTextbox.TabIndex = 9;
            // 
            // discoveryDateDateTimePicker
            // 
            this.discoveryDateDateTimePicker.Location = new System.Drawing.Point(133, 105);
            this.discoveryDateDateTimePicker.Name = "discoveryDateDateTimePicker";
            this.discoveryDateDateTimePicker.Size = new System.Drawing.Size(349, 20);
            this.discoveryDateDateTimePicker.TabIndex = 10;
            // 
            // discovererTextbox
            // 
            this.discovererTextbox.Location = new System.Drawing.Point(133, 134);
            this.discovererTextbox.Name = "discovererTextbox";
            this.discovererTextbox.Size = new System.Drawing.Size(349, 20);
            this.discovererTextbox.TabIndex = 11;
            // 
            // componentTextbox
            // 
            this.componentTextbox.Location = new System.Drawing.Point(133, 161);
            this.componentTextbox.Name = "componentTextbox";
            this.componentTextbox.Size = new System.Drawing.Size(349, 20);
            this.componentTextbox.TabIndex = 12;
            // 
            // statusDropdown
            // 
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Location = new System.Drawing.Point(133, 192);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(349, 21);
            this.statusDropdown.TabIndex = 13;
            // 
            // createIssueButton
            // 
            this.createIssueButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createIssueButton.Location = new System.Drawing.Point(407, 500);
            this.createIssueButton.Name = "createIssueButton";
            this.createIssueButton.Size = new System.Drawing.Size(75, 23);
            this.createIssueButton.TabIndex = 14;
            this.createIssueButton.Text = "Create Issue";
            this.createIssueButton.UseVisualStyleBackColor = true;
            this.createIssueButton.Click += new System.EventHandler(this.createIssueButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(307, 500);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 568);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createIssueButton);
            this.Controls.Add(this.statusDropdown);
            this.Controls.Add(this.componentTextbox);
            this.Controls.Add(this.discovererTextbox);
            this.Controls.Add(this.discoveryDateDateTimePicker);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.componentLabel);
            this.Controls.Add(this.discovererLabel);
            this.Controls.Add(this.discoveryDateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormRecordIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label discoveryDateLabel;
        private System.Windows.Forms.Label discovererLabel;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.DateTimePicker discoveryDateDateTimePicker;
        private System.Windows.Forms.TextBox discovererTextbox;
        private System.Windows.Forms.TextBox componentTextbox;
        private System.Windows.Forms.ComboBox statusDropdown;
        private System.Windows.Forms.Button createIssueButton;
        private System.Windows.Forms.Button cancelButton;
    }
}