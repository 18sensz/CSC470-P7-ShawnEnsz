namespace P5
{
    partial class FormModifyFeature
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
            this.featureTitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.modifyFeatureButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // featureTitleLabel
            // 
            this.featureTitleLabel.AutoSize = true;
            this.featureTitleLabel.Location = new System.Drawing.Point(37, 63);
            this.featureTitleLabel.Name = "featureTitleLabel";
            this.featureTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.featureTitleLabel.TabIndex = 0;
            this.featureTitleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(73, 60);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(428, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // modifyFeatureButton
            // 
            this.modifyFeatureButton.Location = new System.Drawing.Point(403, 118);
            this.modifyFeatureButton.Name = "modifyFeatureButton";
            this.modifyFeatureButton.Size = new System.Drawing.Size(98, 23);
            this.modifyFeatureButton.TabIndex = 2;
            this.modifyFeatureButton.Text = "Modify Feature";
            this.modifyFeatureButton.UseVisualStyleBackColor = true;
            this.modifyFeatureButton.Click += new System.EventHandler(this.modifyFeatureButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(272, 118);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormModifyFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 176);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifyFeatureButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.featureTitleLabel);
            this.Name = "FormModifyFeature";
            this.Text = "Modify Feature";
            this.Load += new System.EventHandler(this.FormModifyFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label featureTitleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button modifyFeatureButton;
        private System.Windows.Forms.Button cancelButton;
    }
}