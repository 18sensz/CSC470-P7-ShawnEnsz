namespace P5
{
    partial class FormModifyIssue
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.createIssueButton = new System.Windows.Forms.Button();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.componentTextbox = new System.Windows.Forms.TextBox();
            this.discovererTextbox = new System.Windows.Forms.TextBox();
            this.discoveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.componentLabel = new System.Windows.Forms.Label();
            this.discovererLabel = new System.Windows.Forms.Label();
            this.discoveryDateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(316, 510);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createIssueButton
            // 
            this.createIssueButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createIssueButton.Location = new System.Drawing.Point(416, 510);
            this.createIssueButton.Name = "createIssueButton";
            this.createIssueButton.Size = new System.Drawing.Size(75, 23);
            this.createIssueButton.TabIndex = 30;
            this.createIssueButton.Text = "Create Issue";
            this.createIssueButton.UseVisualStyleBackColor = true;
            this.createIssueButton.Click += new System.EventHandler(this.createIssueButton_Click);
            // 
            // statusDropdown
            // 
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Location = new System.Drawing.Point(142, 202);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(349, 21);
            this.statusDropdown.TabIndex = 29;
            // 
            // componentTextbox
            // 
            this.componentTextbox.Location = new System.Drawing.Point(142, 171);
            this.componentTextbox.Name = "componentTextbox";
            this.componentTextbox.Size = new System.Drawing.Size(349, 20);
            this.componentTextbox.TabIndex = 28;
            // 
            // discovererTextbox
            // 
            this.discovererTextbox.Location = new System.Drawing.Point(142, 144);
            this.discovererTextbox.Name = "discovererTextbox";
            this.discovererTextbox.Size = new System.Drawing.Size(349, 20);
            this.discovererTextbox.TabIndex = 27;
            // 
            // discoveryDateDateTimePicker
            // 
            this.discoveryDateDateTimePicker.Location = new System.Drawing.Point(142, 115);
            this.discoveryDateDateTimePicker.Name = "discoveryDateDateTimePicker";
            this.discoveryDateDateTimePicker.Size = new System.Drawing.Size(349, 20);
            this.discoveryDateDateTimePicker.TabIndex = 26;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(142, 89);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(349, 20);
            this.titleTextbox.TabIndex = 25;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(142, 63);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.ReadOnly = true;
            this.idTextbox.Size = new System.Drawing.Size(50, 20);
            this.idTextbox.TabIndex = 24;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(142, 252);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(349, 238);
            this.descriptionTextbox.TabIndex = 23;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(102, 230);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(90, 13);
            this.descriptionLabel.TabIndex = 22;
            this.descriptionLabel.Text = "Initial Description:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(102, 205);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Satus:";
            // 
            // componentLabel
            // 
            this.componentLabel.AutoSize = true;
            this.componentLabel.Location = new System.Drawing.Point(75, 174);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(64, 13);
            this.componentLabel.TabIndex = 20;
            this.componentLabel.Text = "Component:";
            // 
            // discovererLabel
            // 
            this.discovererLabel.AutoSize = true;
            this.discovererLabel.Location = new System.Drawing.Point(78, 147);
            this.discovererLabel.Name = "discovererLabel";
            this.discovererLabel.Size = new System.Drawing.Size(61, 13);
            this.discovererLabel.TabIndex = 19;
            this.discovererLabel.Text = "Discoverer:";
            // 
            // discoveryDateLabel
            // 
            this.discoveryDateLabel.AutoSize = true;
            this.discoveryDateLabel.Location = new System.Drawing.Point(56, 120);
            this.discoveryDateLabel.Name = "discoveryDateLabel";
            this.discoveryDateLabel.Size = new System.Drawing.Size(83, 13);
            this.discoveryDateLabel.TabIndex = 18;
            this.discoveryDateLabel.Text = "Discovery Date:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(109, 92);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Title:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(120, 66);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "Id:";
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 592);
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
            this.Name = "FormModifyIssue";
            this.Text = "Modify Issue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createIssueButton;
        private System.Windows.Forms.ComboBox statusDropdown;
        private System.Windows.Forms.TextBox componentTextbox;
        private System.Windows.Forms.TextBox discovererTextbox;
        private System.Windows.Forms.DateTimePicker discoveryDateDateTimePicker;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label discovererLabel;
        private System.Windows.Forms.Label discoveryDateLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label idLabel;
    }
}