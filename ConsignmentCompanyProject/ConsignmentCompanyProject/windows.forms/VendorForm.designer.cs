namespace ConsignmentCompanyProject
{
    partial class VendorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMaidId = new System.Windows.Forms.Label();
            this.labelVendorContact = new System.Windows.Forms.Label();
            this.labelDiscountId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVenderName = new System.Windows.Forms.TextBox();
            this.labelVendorID = new System.Windows.Forms.Label();
            this.textBoxVenderId = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxMailId = new System.Windows.Forms.TextBox();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.textBoxDiscountId = new System.Windows.Forms.TextBox();
            this.buttonAddVender = new System.Windows.Forms.Button();
            this.buttonCancelVender = new System.Windows.Forms.Button();
            this.groupBoxVendorIfo = new System.Windows.Forms.GroupBox();
            this.radioButtonAddNewVendor = new System.Windows.Forms.RadioButton();
            this.radioButtonModifyVendor = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteVendor = new System.Windows.Forms.RadioButton();
            this.groupBoxVendorIfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENDOR MANAGEMENT";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(104, 97);
            this.labelVendorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(110, 17);
            this.labelVendorName.TabIndex = 1;
            this.labelVendorName.Text = "VENDOR NAME";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(104, 141);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 17);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "ADDRESS";
            // 
            // labelMaidId
            // 
            this.labelMaidId.AutoSize = true;
            this.labelMaidId.Location = new System.Drawing.Point(104, 189);
            this.labelMaidId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaidId.Name = "labelMaidId";
            this.labelMaidId.Size = new System.Drawing.Size(56, 17);
            this.labelMaidId.TabIndex = 4;
            this.labelMaidId.Text = "MAIL ID";
            // 
            // labelVendorContact
            // 
            this.labelVendorContact.AutoSize = true;
            this.labelVendorContact.Location = new System.Drawing.Point(104, 228);
            this.labelVendorContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendorContact.Name = "labelVendorContact";
            this.labelVendorContact.Size = new System.Drawing.Size(74, 17);
            this.labelVendorContact.TabIndex = 5;
            this.labelVendorContact.Text = "CONTACT";
            // 
            // labelDiscountId
            // 
            this.labelDiscountId.AutoSize = true;
            this.labelDiscountId.Location = new System.Drawing.Point(449, 187);
            this.labelDiscountId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountId.Name = "labelDiscountId";
            this.labelDiscountId.Size = new System.Drawing.Size(96, 17);
            this.labelDiscountId.TabIndex = 7;
            this.labelDiscountId.Text = "DISCOUNT ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "DISCOUNT RATE";
            // 
            // textBoxVenderName
            // 
            this.textBoxVenderName.Location = new System.Drawing.Point(232, 94);
            this.textBoxVenderName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVenderName.Name = "textBoxVenderName";
            this.textBoxVenderName.Size = new System.Drawing.Size(132, 22);
            this.textBoxVenderName.TabIndex = 9;
            this.textBoxVenderName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelVendorID
            // 
            this.labelVendorID.AutoSize = true;
            this.labelVendorID.Location = new System.Drawing.Point(448, 99);
            this.labelVendorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendorID.Name = "labelVendorID";
            this.labelVendorID.Size = new System.Drawing.Size(84, 17);
            this.labelVendorID.TabIndex = 10;
            this.labelVendorID.Text = "VENDOR ID";
            // 
            // textBoxVenderId
            // 
            this.textBoxVenderId.Location = new System.Drawing.Point(576, 96);
            this.textBoxVenderId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVenderId.Name = "textBoxVenderId";
            this.textBoxVenderId.ReadOnly = true;
            this.textBoxVenderId.Size = new System.Drawing.Size(132, 22);
            this.textBoxVenderId.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(232, 141);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(232, 225);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(132, 22);
            this.textBoxContact.TabIndex = 13;
            // 
            // textBoxMailId
            // 
            this.textBoxMailId.Location = new System.Drawing.Point(232, 185);
            this.textBoxMailId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMailId.Name = "textBoxMailId";
            this.textBoxMailId.Size = new System.Drawing.Size(132, 22);
            this.textBoxMailId.TabIndex = 14;
            // 
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Location = new System.Drawing.Point(576, 220);
            this.textBoxDiscountRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.Size = new System.Drawing.Size(132, 22);
            this.textBoxDiscountRate.TabIndex = 15;
            // 
            // textBoxDiscountId
            // 
            this.textBoxDiscountId.Location = new System.Drawing.Point(576, 184);
            this.textBoxDiscountId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountId.Name = "textBoxDiscountId";
            this.textBoxDiscountId.Size = new System.Drawing.Size(132, 22);
            this.textBoxDiscountId.TabIndex = 16;
            // 
            // buttonAddVender
            // 
            this.buttonAddVender.Location = new System.Drawing.Point(319, 281);
            this.buttonAddVender.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddVender.Name = "buttonAddVender";
            this.buttonAddVender.Size = new System.Drawing.Size(137, 28);
            this.buttonAddVender.TabIndex = 18;
            this.buttonAddVender.Text = "&ADD VENDOR";
            this.buttonAddVender.UseVisualStyleBackColor = true;
            this.buttonAddVender.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelVender
            // 
            this.buttonCancelVender.Location = new System.Drawing.Point(495, 281);
            this.buttonCancelVender.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelVender.Name = "buttonCancelVender";
            this.buttonCancelVender.Size = new System.Drawing.Size(137, 28);
            this.buttonCancelVender.TabIndex = 19;
            this.buttonCancelVender.Text = "&CANCEL";
            this.buttonCancelVender.UseVisualStyleBackColor = true;
            // 
            // groupBoxVendorIfo
            // 
            this.groupBoxVendorIfo.Controls.Add(this.radioButtonDeleteVendor);
            this.groupBoxVendorIfo.Controls.Add(this.radioButtonModifyVendor);
            this.groupBoxVendorIfo.Controls.Add(this.radioButtonAddNewVendor);
            this.groupBoxVendorIfo.Controls.Add(this.buttonCancelVender);
            this.groupBoxVendorIfo.Controls.Add(this.buttonAddVender);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxDiscountId);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxDiscountRate);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxMailId);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxContact);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxAddress);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxVenderId);
            this.groupBoxVendorIfo.Controls.Add(this.labelVendorID);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxVenderName);
            this.groupBoxVendorIfo.Controls.Add(this.label9);
            this.groupBoxVendorIfo.Controls.Add(this.labelDiscountId);
            this.groupBoxVendorIfo.Controls.Add(this.labelVendorContact);
            this.groupBoxVendorIfo.Controls.Add(this.labelMaidId);
            this.groupBoxVendorIfo.Controls.Add(this.labelAddress);
            this.groupBoxVendorIfo.Controls.Add(this.labelVendorName);
            this.groupBoxVendorIfo.Location = new System.Drawing.Point(54, 45);
            this.groupBoxVendorIfo.Name = "groupBoxVendorIfo";
            this.groupBoxVendorIfo.Size = new System.Drawing.Size(874, 333);
            this.groupBoxVendorIfo.TabIndex = 20;
            this.groupBoxVendorIfo.TabStop = false;
            this.groupBoxVendorIfo.Text = "VENDOR INFO";
            // 
            // radioButtonAddNewVendor
            // 
            this.radioButtonAddNewVendor.AutoSize = true;
            this.radioButtonAddNewVendor.Location = new System.Drawing.Point(107, 40);
            this.radioButtonAddNewVendor.Name = "radioButtonAddNewVendor";
            this.radioButtonAddNewVendor.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAddNewVendor.TabIndex = 20;
            this.radioButtonAddNewVendor.TabStop = true;
            this.radioButtonAddNewVendor.Text = "ADD VENDOR";
            this.radioButtonAddNewVendor.UseVisualStyleBackColor = true;
            // 
            // radioButtonModifyVendor
            // 
            this.radioButtonModifyVendor.AutoSize = true;
            this.radioButtonModifyVendor.Location = new System.Drawing.Point(319, 40);
            this.radioButtonModifyVendor.Name = "radioButtonModifyVendor";
            this.radioButtonModifyVendor.Size = new System.Drawing.Size(205, 21);
            this.radioButtonModifyVendor.TabIndex = 21;
            this.radioButtonModifyVendor.TabStop = true;
            this.radioButtonModifyVendor.Text = "MODIFY VENDOR DETAILS";
            this.radioButtonModifyVendor.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteVendor
            // 
            this.radioButtonDeleteVendor.AutoSize = true;
            this.radioButtonDeleteVendor.Location = new System.Drawing.Point(576, 40);
            this.radioButtonDeleteVendor.Name = "radioButtonDeleteVendor";
            this.radioButtonDeleteVendor.Size = new System.Drawing.Size(207, 21);
            this.radioButtonDeleteVendor.TabIndex = 22;
            this.radioButtonDeleteVendor.TabStop = true;
            this.radioButtonDeleteVendor.Text = "DELETE VENDOR DETAILS";
            this.radioButtonDeleteVendor.UseVisualStyleBackColor = true;
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 475);
            this.Controls.Add(this.groupBoxVendorIfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendorForm";
            this.Text = "Vender";
            this.groupBoxVendorIfo.ResumeLayout(false);
            this.groupBoxVendorIfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelMaidId;
        private System.Windows.Forms.Label labelVendorContact;
        private System.Windows.Forms.Label labelDiscountId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVenderName;
        private System.Windows.Forms.Label labelVendorID;
        private System.Windows.Forms.TextBox textBoxVenderId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxMailId;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.TextBox textBoxDiscountId;
        private System.Windows.Forms.Button buttonAddVender;
        private System.Windows.Forms.Button buttonCancelVender;
        private System.Windows.Forms.GroupBox groupBoxVendorIfo;
        private System.Windows.Forms.RadioButton radioButtonDeleteVendor;
        private System.Windows.Forms.RadioButton radioButtonModifyVendor;
        private System.Windows.Forms.RadioButton radioButtonAddNewVendor;
    }
}