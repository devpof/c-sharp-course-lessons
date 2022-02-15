namespace Module07Lesson05WindowsFormsMiniProject
{
    partial class PersonForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressListBox = new System.Windows.Forms.ListBox();
            this.addAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(134, 6);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(315, 31);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 46);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(134, 43);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(315, 31);
            this.lastNameText.TabIndex = 2;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(12, 83);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birthDateLabel.Size = new System.Drawing.Size(107, 25);
            this.birthDateLabel.TabIndex = 0;
            this.birthDateLabel.Text = "Birth Date";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(134, 78);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 31);
            this.birthDate.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 122);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressLabel.Size = new System.Drawing.Size(114, 25);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Addresses";
            // 
            // addressListBox
            // 
            this.addressListBox.FormattingEnabled = true;
            this.addressListBox.ItemHeight = 25;
            this.addressListBox.Location = new System.Drawing.Point(17, 150);
            this.addressListBox.Name = "addressListBox";
            this.addressListBox.Size = new System.Drawing.Size(523, 279);
            this.addressListBox.TabIndex = 5;
            this.addressListBox.TabStop = false;
            // 
            // addAddress
            // 
            this.addAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddress.Location = new System.Drawing.Point(134, 121);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(128, 23);
            this.addAddress.TabIndex = 4;
            this.addAddress.Text = "Add Address";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.AddAddress_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 454);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.addressListBox);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PersonForm";
            this.Text = "Person Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.ListBox addressListBox;
        private System.Windows.Forms.Button addAddress;
    }
}

