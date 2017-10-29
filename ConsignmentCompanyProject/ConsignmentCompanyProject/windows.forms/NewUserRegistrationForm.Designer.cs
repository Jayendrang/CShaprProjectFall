namespace ConsignmentCompanyProject.windows.forms
{
    partial class NewUserRegistrationForm
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
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBoxVendorName = new System.Windows.Forms.ComboBox();
            this.textBoxEmailId = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelIsVendor = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelMailId = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxGeneratedUsername = new System.Windows.Forms.TextBox();
            this.textBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddUser
            // 
            this.panelAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAddUser.Controls.Add(this.labelTitle);
            this.panelAddUser.Controls.Add(this.groupBox1);
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUser.Location = new System.Drawing.Point(0, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(1167, 641);
            this.panelAddUser.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(455, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 29);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "USER MANAGEMENT";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(282, 267);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.ItemHeight = 16;
            this.listBoxRoles.Location = new System.Drawing.Point(223, 360);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(120, 20);
            this.listBoxRoles.TabIndex = 25;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(223, 267);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBoxVendorName
            // 
            this.comboBoxVendorName.FormattingEnabled = true;
            this.comboBoxVendorName.Location = new System.Drawing.Point(223, 312);
            this.comboBoxVendorName.Name = "comboBoxVendorName";
            this.comboBoxVendorName.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVendorName.TabIndex = 24;
            // 
            // textBoxEmailId
            // 
            this.textBoxEmailId.Location = new System.Drawing.Point(223, 220);
            this.textBoxEmailId.Name = "textBoxEmailId";
            this.textBoxEmailId.Size = new System.Drawing.Size(193, 22);
            this.textBoxEmailId.TabIndex = 22;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(223, 140);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(193, 62);
            this.textBoxAddress.TabIndex = 21;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(223, 97);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(120, 22);
            this.textBoxContact.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(223, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 22);
            this.textBoxName.TabIndex = 19;
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(45, 319);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(110, 17);
            this.labelVendorName.TabIndex = 15;
            this.labelVendorName.Text = "VENDOR NAME";
            // 
            // labelIsVendor
            // 
            this.labelIsVendor.AutoSize = true;
            this.labelIsVendor.Location = new System.Drawing.Point(45, 271);
            this.labelIsVendor.Name = "labelIsVendor";
            this.labelIsVendor.Size = new System.Drawing.Size(83, 17);
            this.labelIsVendor.TabIndex = 14;
            this.labelIsVendor.Text = "IS VENDOR";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(45, 360);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 17);
            this.labelRole.TabIndex = 13;
            this.labelRole.Text = "ROLE";
            // 
            // labelMailId
            // 
            this.labelMailId.AutoSize = true;
            this.labelMailId.Location = new System.Drawing.Point(45, 226);
            this.labelMailId.Name = "labelMailId";
            this.labelMailId.Size = new System.Drawing.Size(65, 17);
            this.labelMailId.TabIndex = 11;
            this.labelMailId.Text = "EMAIL ID";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(45, 140);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 17);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "ADDRESS";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(45, 97);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(74, 17);
            this.labelContact.TabIndex = 9;
            this.labelContact.Text = "CONTACT";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(45, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "NAME";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(488, 195);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(238, 17);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "SYSTEM GENERATED PASSWORD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "&ADD USER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "CAN&CEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(488, 145);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(235, 17);
            this.labelUsername.TabIndex = 26;
            this.labelUsername.Text = "SYSTEM GENERATED USERNAME";
            // 
            // textBoxGeneratedUsername
            // 
            this.textBoxGeneratedUsername.Location = new System.Drawing.Point(747, 140);
            this.textBoxGeneratedUsername.Name = "textBoxGeneratedUsername";
            this.textBoxGeneratedUsername.ReadOnly = true;
            this.textBoxGeneratedUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeneratedUsername.TabIndex = 27;
            // 
            // textBoxGeneratedPassword
            // 
            this.textBoxGeneratedPassword.Location = new System.Drawing.Point(747, 188);
            this.textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            this.textBoxGeneratedPassword.ReadOnly = true;
            this.textBoxGeneratedPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeneratedPassword.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGeneratedPassword);
            this.groupBox1.Controls.Add(this.textBoxGeneratedUsername);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.listBoxRoles);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.comboBoxVendorName);
            this.groupBox1.Controls.Add(this.textBoxEmailId);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelVendorName);
            this.groupBox1.Controls.Add(this.labelIsVendor);
            this.groupBox1.Controls.Add(this.labelRole);
            this.groupBox1.Controls.Add(this.labelMailId);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelContact);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(123, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 449);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEW USER DETAILS";
            // 
            // NewUserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 641);
            this.Controls.Add(this.panelAddUser);
            this.Name = "NewUserRegistrationForm";
            this.Text = "ADD NEW USER";
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.ComboBox comboBoxVendorName;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxEmailId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelIsVendor;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelMailId;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxGeneratedPassword;
        private System.Windows.Forms.TextBox textBoxGeneratedUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}