namespace ConsignmentCompanyProject.windows.forms
{
    partial class UserProfileChangeForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelVendor = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxProfileDetails = new System.Windows.Forms.GroupBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxVendorName = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxnName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxProfileDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(100, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NAME";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(100, 166);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(74, 17);
            this.labelContact.TabIndex = 1;
            this.labelContact.Text = "CONTACT";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(100, 202);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 17);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "ADDRESS";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(100, 267);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "EMAIL ID";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(548, 120);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(63, 17);
            this.labelUserId.TabIndex = 4;
            this.labelUserId.Text = "USER ID";
            // 
            // labelVendor
            // 
            this.labelVendor.AutoSize = true;
            this.labelVendor.Location = new System.Drawing.Point(548, 161);
            this.labelVendor.Name = "labelVendor";
            this.labelVendor.Size = new System.Drawing.Size(110, 17);
            this.labelVendor.TabIndex = 6;
            this.labelVendor.Text = "VENDOR NAME";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(548, 199);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 17);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "STATUS";
            // 
            // groupBoxProfileDetails
            // 
            this.groupBoxProfileDetails.Controls.Add(this.textBoxStatus);
            this.groupBoxProfileDetails.Controls.Add(this.textBoxVendorName);
            this.groupBoxProfileDetails.Controls.Add(this.textBoxUserId);
            this.groupBoxProfileDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxProfileDetails.Controls.Add(this.textBoxAddress);
            this.groupBoxProfileDetails.Controls.Add(this.textBoxContact);
            this.groupBoxProfileDetails.Controls.Add(this.textBoxnName);
            this.groupBoxProfileDetails.Controls.Add(this.button2);
            this.groupBoxProfileDetails.Controls.Add(this.buttonUpdate);
            this.groupBoxProfileDetails.Controls.Add(this.labelTitle);
            this.groupBoxProfileDetails.Controls.Add(this.labelUserId);
            this.groupBoxProfileDetails.Controls.Add(this.labelStatus);
            this.groupBoxProfileDetails.Controls.Add(this.labelName);
            this.groupBoxProfileDetails.Controls.Add(this.labelVendor);
            this.groupBoxProfileDetails.Controls.Add(this.labelContact);
            this.groupBoxProfileDetails.Controls.Add(this.labelAddress);
            this.groupBoxProfileDetails.Controls.Add(this.labelEmail);
            this.groupBoxProfileDetails.Location = new System.Drawing.Point(67, 46);
            this.groupBoxProfileDetails.Name = "groupBoxProfileDetails";
            this.groupBoxProfileDetails.Size = new System.Drawing.Size(909, 454);
            this.groupBoxProfileDetails.TabIndex = 8;
            this.groupBoxProfileDetails.TabStop = false;
            this.groupBoxProfileDetails.Text = "PROFILE DETAILS";
            this.groupBoxProfileDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(682, 196);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(117, 22);
            this.textBoxStatus.TabIndex = 18;
            // 
            // textBoxVendorName
            // 
            this.textBoxVendorName.Location = new System.Drawing.Point(682, 158);
            this.textBoxVendorName.Name = "textBoxVendorName";
            this.textBoxVendorName.ReadOnly = true;
            this.textBoxVendorName.Size = new System.Drawing.Size(117, 22);
            this.textBoxVendorName.TabIndex = 17;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(682, 115);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.ReadOnly = true;
            this.textBoxUserId.Size = new System.Drawing.Size(116, 22);
            this.textBoxUserId.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(224, 264);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 22);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(224, 199);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(167, 54);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(224, 161);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(133, 22);
            this.textBoxContact.TabIndex = 12;
            // 
            // textBoxnName
            // 
            this.textBoxnName.Location = new System.Drawing.Point(224, 115);
            this.textBoxnName.Name = "textBoxnName";
            this.textBoxnName.ReadOnly = true;
            this.textBoxnName.Size = new System.Drawing.Size(133, 22);
            this.textBoxnName.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "&CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(307, 350);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(102, 28);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(355, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 25);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "USER PROFILE DETAILS";
            // 
            // UserProfileChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 577);
            this.Controls.Add(this.groupBoxProfileDetails);
            this.Name = "UserProfileChangeForm";
            this.Text = "USER PROFILE";
            this.Load += new System.EventHandler(this.UserProfileChangeForm_Load);
            this.groupBoxProfileDetails.ResumeLayout(false);
            this.groupBoxProfileDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelVendor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxProfileDetails;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxVendorName;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxnName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelTitle;
    }
}