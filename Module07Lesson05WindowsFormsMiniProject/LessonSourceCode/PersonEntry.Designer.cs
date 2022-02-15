namespace LessonSourceCode
{
    partial class PersonEntry
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
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressesList = new System.Windows.Forms.ListBox();
            this.addressesListLabel = new System.Windows.Forms.Label();
            this.addNewAddress = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(49, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(183, 37);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(211, 31);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(49, 77);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(183, 74);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(211, 31);
            this.lastNameText.TabIndex = 2;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(183, 118);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(15, 14);
            this.isActive.TabIndex = 3;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(50, 112);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(71, 25);
            this.isActiveLabel.TabIndex = 0;
            this.isActiveLabel.Text = "Active";
            // 
            // addressesList
            // 
            this.addressesList.FormattingEnabled = true;
            this.addressesList.ItemHeight = 25;
            this.addressesList.Location = new System.Drawing.Point(55, 192);
            this.addressesList.Name = "addressesList";
            this.addressesList.Size = new System.Drawing.Size(339, 279);
            this.addressesList.TabIndex = 5;
            this.addressesList.TabStop = false;
            // 
            // addressesListLabel
            // 
            this.addressesListLabel.AutoSize = true;
            this.addressesListLabel.Location = new System.Drawing.Point(49, 164);
            this.addressesListLabel.Name = "addressesListLabel";
            this.addressesListLabel.Size = new System.Drawing.Size(114, 25);
            this.addressesListLabel.TabIndex = 0;
            this.addressesListLabel.Text = "Addresses";
            // 
            // addNewAddress
            // 
            this.addNewAddress.Location = new System.Drawing.Point(327, 158);
            this.addNewAddress.Name = "addNewAddress";
            this.addNewAddress.Size = new System.Drawing.Size(67, 31);
            this.addNewAddress.TabIndex = 4;
            this.addNewAddress.Text = "Add";
            this.addNewAddress.UseVisualStyleBackColor = true;
            this.addNewAddress.Click += new System.EventHandler(this.AddNewAddress_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(140, 477);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(149, 41);
            this.saveRecord.TabIndex = 6;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 539);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addNewAddress);
            this.Controls.Add(this.addressesList);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.addressesListLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form by Yours Truly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.Label addressesListLabel;
        private System.Windows.Forms.Button addNewAddress;
        private System.Windows.Forms.Button saveRecord;
    }
}

