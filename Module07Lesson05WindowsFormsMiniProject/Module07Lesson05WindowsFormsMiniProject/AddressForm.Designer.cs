namespace Module07Lesson05WindowsFormsMiniProject
{
    partial class AddressForm
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
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.addAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(12, 9);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(69, 25);
            this.streetLabel.TabIndex = 0;
            this.streetLabel.Text = "Street";
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(124, 6);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(394, 31);
            this.streetText.TabIndex = 1;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 46);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 25);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(124, 43);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(394, 31);
            this.cityText.TabIndex = 2;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(12, 83);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(62, 25);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "State";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(124, 80);
            this.stateText.MaxLength = 2;
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(394, 31);
            this.stateText.TabIndex = 3;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(12, 120);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(99, 25);
            this.zipCodeLabel.TabIndex = 0;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(124, 117);
            this.zipCodeText.MaxLength = 5;
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(394, 31);
            this.zipCodeText.TabIndex = 4;
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(124, 170);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(209, 36);
            this.addAddress.TabIndex = 5;
            this.addAddress.Text = "Add Address";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.AddAddress_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 236);
            this.ControlBox = false;
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetText);
            this.Controls.Add(this.streetLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddressForm";
            this.Text = "Address Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.Button addAddress;
    }
}