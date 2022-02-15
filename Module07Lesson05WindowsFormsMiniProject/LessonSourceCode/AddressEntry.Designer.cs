namespace LessonSourceCode
{
    partial class AddressEntry
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
            this.cityText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.addressEntryLabel = new System.Windows.Forms.Label();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(178, 103);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(276, 31);
            this.cityText.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(123, 103);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 25);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(178, 66);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(276, 31);
            this.streetAddressText.TabIndex = 5;
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(18, 69);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(154, 25);
            this.streetAddressLabel.TabIndex = 4;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(178, 178);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(276, 31);
            this.zipCodeText.TabIndex = 10;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(73, 181);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(99, 25);
            this.zipCodeLabel.TabIndex = 7;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(178, 141);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(276, 31);
            this.stateText.TabIndex = 9;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(110, 144);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(62, 25);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // addressEntryLabel
            // 
            this.addressEntryLabel.AutoSize = true;
            this.addressEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressEntryLabel.Location = new System.Drawing.Point(108, 9);
            this.addressEntryLabel.Name = "addressEntryLabel";
            this.addressEntryLabel.Size = new System.Drawing.Size(249, 39);
            this.addressEntryLabel.TabIndex = 11;
            this.addressEntryLabel.Text = "Address Entry";
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(178, 226);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(149, 41);
            this.saveRecord.TabIndex = 12;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addressEntryLabel);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.streetAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddressEntry";
            this.Text = "Address Entry Form by Yours Truly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetAddressText;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label addressEntryLabel;
        private System.Windows.Forms.Button saveRecord;
    }
}