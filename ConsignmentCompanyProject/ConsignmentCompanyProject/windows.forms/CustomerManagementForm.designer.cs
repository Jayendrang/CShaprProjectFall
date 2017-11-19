namespace ConsignmentCompanyProject
{
    partial class CustomerManagementForm
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
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxMailId = new System.Windows.Forms.TextBox();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.textBoxDiscountId = new System.Windows.Forms.TextBox();
            this.buttonDynamicButton = new System.Windows.Forms.Button();
            this.buttonCancelVender = new System.Windows.Forms.Button();
            this.groupBoxVendorIfo = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSearchVendor = new System.Windows.Forms.Button();
            this.radioButtonDeleteVendor = new System.Windows.Forms.RadioButton();
            this.radioButtonModifyVendor = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNewVendor = new System.Windows.Forms.RadioButton();
            this.groupBoxSearchVendor = new System.Windows.Forms.GroupBox();
            this.labelVendorStatus = new System.Windows.Forms.Label();
            this.radioButtonStatusInActive = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusActive = new System.Windows.Forms.RadioButton();
            this.dataGridViewVendorInformation = new System.Windows.Forms.DataGridView();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.groupBoxVendorIfo.SuspendLayout();
            this.groupBoxSearchVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendorInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER MANAGEMENT";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(104, 97);
            this.labelVendorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(47, 17);
            this.labelVendorName.TabIndex = 1;
            this.labelVendorName.Text = "NAME";
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
            this.labelMaidId.Location = new System.Drawing.Point(104, 222);
            this.labelMaidId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaidId.Name = "labelMaidId";
            this.labelMaidId.Size = new System.Drawing.Size(56, 17);
            this.labelMaidId.TabIndex = 4;
            this.labelMaidId.Text = "MAIL ID";
            // 
            // labelVendorContact
            // 
            this.labelVendorContact.AutoSize = true;
            this.labelVendorContact.Location = new System.Drawing.Point(104, 261);
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
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(232, 94);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(179, 22);
            this.textBoxCustomerName.TabIndex = 9;
            this.textBoxCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(448, 99);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(103, 17);
            this.labelCustomerID.TabIndex = 10;
            this.labelCustomerID.Text = "CUSTOMER ID";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(576, 96);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(132, 22);
            this.textBoxCustomerId.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(232, 141);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(179, 63);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(232, 258);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(179, 22);
            this.textBoxContact.TabIndex = 13;
            // 
            // textBoxMailId
            // 
            this.textBoxMailId.Location = new System.Drawing.Point(232, 218);
            this.textBoxMailId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMailId.Name = "textBoxMailId";
            this.textBoxMailId.Size = new System.Drawing.Size(179, 22);
            this.textBoxMailId.TabIndex = 14;
            // 
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Location = new System.Drawing.Point(576, 220);
            this.textBoxDiscountRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.ReadOnly = true;
            this.textBoxDiscountRate.Size = new System.Drawing.Size(132, 22);
            this.textBoxDiscountRate.TabIndex = 15;
            // 
            // textBoxDiscountId
            // 
            this.textBoxDiscountId.Location = new System.Drawing.Point(576, 184);
            this.textBoxDiscountId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountId.Name = "textBoxDiscountId";
            this.textBoxDiscountId.ReadOnly = true;
            this.textBoxDiscountId.Size = new System.Drawing.Size(132, 22);
            this.textBoxDiscountId.TabIndex = 16;
            // 
            // buttonDynamicButton
            // 
            this.buttonDynamicButton.Location = new System.Drawing.Point(309, 323);
            this.buttonDynamicButton.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDynamicButton.Name = "buttonDynamicButton";
            this.buttonDynamicButton.Size = new System.Drawing.Size(137, 28);
            this.buttonDynamicButton.TabIndex = 18;
            this.buttonDynamicButton.Text = "&ADD CUSTOMER";
            this.buttonDynamicButton.UseVisualStyleBackColor = true;
            this.buttonDynamicButton.Click += new System.EventHandler(this.buttonDynamicButton_Click);
            // 
            // buttonCancelVender
            // 
            this.buttonCancelVender.Location = new System.Drawing.Point(485, 323);
            this.buttonCancelVender.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelVender.Name = "buttonCancelVender";
            this.buttonCancelVender.Size = new System.Drawing.Size(137, 28);
            this.buttonCancelVender.TabIndex = 19;
            this.buttonCancelVender.Text = "&CANCEL";
            this.buttonCancelVender.UseVisualStyleBackColor = true;
            this.buttonCancelVender.Click += new System.EventHandler(this.buttonCancelVender_Click);
            // 
            // groupBoxVendorIfo
            // 
            this.groupBoxVendorIfo.Controls.Add(this.listBoxStatus);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxStatus);
            this.groupBoxVendorIfo.Controls.Add(this.labelStatus);
            this.groupBoxVendorIfo.Controls.Add(this.buttonSearchVendor);
            this.groupBoxVendorIfo.Controls.Add(this.radioButtonDeleteVendor);
            this.groupBoxVendorIfo.Controls.Add(this.radioButtonModifyVendor);
            this.groupBoxVendorIfo.Controls.Add(this.radioButtonAddNewVendor);
            this.groupBoxVendorIfo.Controls.Add(this.buttonCancelVender);
            this.groupBoxVendorIfo.Controls.Add(this.buttonDynamicButton);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxDiscountId);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxDiscountRate);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxMailId);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxContact);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxAddress);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxCustomerId);
            this.groupBoxVendorIfo.Controls.Add(this.labelCustomerID);
            this.groupBoxVendorIfo.Controls.Add(this.textBoxCustomerName);
            this.groupBoxVendorIfo.Controls.Add(this.label9);
            this.groupBoxVendorIfo.Controls.Add(this.labelDiscountId);
            this.groupBoxVendorIfo.Controls.Add(this.labelVendorContact);
            this.groupBoxVendorIfo.Controls.Add(this.labelMaidId);
            this.groupBoxVendorIfo.Controls.Add(this.labelAddress);
            this.groupBoxVendorIfo.Controls.Add(this.labelVendorName);
            this.groupBoxVendorIfo.Location = new System.Drawing.Point(54, 45);
            this.groupBoxVendorIfo.Name = "groupBoxVendorIfo";
            this.groupBoxVendorIfo.Size = new System.Drawing.Size(874, 382);
            this.groupBoxVendorIfo.TabIndex = 20;
            this.groupBoxVendorIfo.TabStop = false;
            this.groupBoxVendorIfo.Text = "VENDOR INFO";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(451, 261);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 17);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "STATUS";
            // 
            // buttonSearchVendor
            // 
            this.buttonSearchVendor.Location = new System.Drawing.Point(733, 94);
            this.buttonSearchVendor.Name = "buttonSearchVendor";
            this.buttonSearchVendor.Size = new System.Drawing.Size(101, 24);
            this.buttonSearchVendor.TabIndex = 23;
            this.buttonSearchVendor.Text = "&SEARCH";
            this.buttonSearchVendor.UseVisualStyleBackColor = true;
            this.buttonSearchVendor.Click += new System.EventHandler(this.buttonSearchVendor_Click);
            // 
            // radioButtonDeleteVendor
            // 
            this.radioButtonDeleteVendor.AutoSize = true;
            this.radioButtonDeleteVendor.Location = new System.Drawing.Point(576, 40);
            this.radioButtonDeleteVendor.Name = "radioButtonDeleteVendor";
            this.radioButtonDeleteVendor.Size = new System.Drawing.Size(226, 21);
            this.radioButtonDeleteVendor.TabIndex = 22;
            this.radioButtonDeleteVendor.TabStop = true;
            this.radioButtonDeleteVendor.Text = "DELETE CUSTOMER DETAILS";
            this.radioButtonDeleteVendor.UseVisualStyleBackColor = true;
            this.radioButtonDeleteVendor.CheckedChanged += new System.EventHandler(this.radioButtonDeleteVendor_CheckedChanged);
            // 
            // radioButtonModifyVendor
            // 
            this.radioButtonModifyVendor.AutoSize = true;
            this.radioButtonModifyVendor.Location = new System.Drawing.Point(319, 40);
            this.radioButtonModifyVendor.Name = "radioButtonModifyVendor";
            this.radioButtonModifyVendor.Size = new System.Drawing.Size(224, 21);
            this.radioButtonModifyVendor.TabIndex = 21;
            this.radioButtonModifyVendor.TabStop = true;
            this.radioButtonModifyVendor.Text = "MODIFY CUSTOMER DETAILS";
            this.radioButtonModifyVendor.UseVisualStyleBackColor = true;
            this.radioButtonModifyVendor.CheckedChanged += new System.EventHandler(this.radioButtonModifyVendor_CheckedChanged);
            // 
            // radioButtonAddNewVendor
            // 
            this.radioButtonAddNewVendor.AutoSize = true;
            this.radioButtonAddNewVendor.Location = new System.Drawing.Point(107, 40);
            this.radioButtonAddNewVendor.Name = "radioButtonAddNewVendor";
            this.radioButtonAddNewVendor.Size = new System.Drawing.Size(176, 21);
            this.radioButtonAddNewVendor.TabIndex = 20;
            this.radioButtonAddNewVendor.TabStop = true;
            this.radioButtonAddNewVendor.Text = "ADD NEW CUSTOMER";
            this.radioButtonAddNewVendor.UseVisualStyleBackColor = true;
            this.radioButtonAddNewVendor.CheckedChanged += new System.EventHandler(this.radioButtonAddNewVendor_CheckedChanged);
            // 
            // groupBoxSearchVendor
            // 
            this.groupBoxSearchVendor.Controls.Add(this.labelVendorStatus);
            this.groupBoxSearchVendor.Controls.Add(this.radioButtonStatusInActive);
            this.groupBoxSearchVendor.Controls.Add(this.radioButtonStatusActive);
            this.groupBoxSearchVendor.Controls.Add(this.dataGridViewVendorInformation);
            this.groupBoxSearchVendor.Location = new System.Drawing.Point(54, 465);
            this.groupBoxSearchVendor.Name = "groupBoxSearchVendor";
            this.groupBoxSearchVendor.Size = new System.Drawing.Size(874, 240);
            this.groupBoxSearchVendor.TabIndex = 21;
            this.groupBoxSearchVendor.TabStop = false;
            this.groupBoxSearchVendor.Text = "SEARCH CUSTOMER";
            // 
            // labelVendorStatus
            // 
            this.labelVendorStatus.AutoSize = true;
            this.labelVendorStatus.Location = new System.Drawing.Point(383, 25);
            this.labelVendorStatus.Name = "labelVendorStatus";
            this.labelVendorStatus.Size = new System.Drawing.Size(63, 17);
            this.labelVendorStatus.TabIndex = 3;
            this.labelVendorStatus.Text = "STATUS";
            // 
            // radioButtonStatusInActive
            // 
            this.radioButtonStatusInActive.AutoSize = true;
            this.radioButtonStatusInActive.Location = new System.Drawing.Point(603, 22);
            this.radioButtonStatusInActive.Name = "radioButtonStatusInActive";
            this.radioButtonStatusInActive.Size = new System.Drawing.Size(90, 21);
            this.radioButtonStatusInActive.TabIndex = 2;
            this.radioButtonStatusInActive.TabStop = true;
            this.radioButtonStatusInActive.Text = "INACTIVE";
            this.radioButtonStatusInActive.UseVisualStyleBackColor = true;
            this.radioButtonStatusInActive.CheckedChanged += new System.EventHandler(this.radioButtonStatusInActive_CheckedChanged);
            // 
            // radioButtonStatusActive
            // 
            this.radioButtonStatusActive.AutoSize = true;
            this.radioButtonStatusActive.Location = new System.Drawing.Point(491, 21);
            this.radioButtonStatusActive.Name = "radioButtonStatusActive";
            this.radioButtonStatusActive.Size = new System.Drawing.Size(77, 21);
            this.radioButtonStatusActive.TabIndex = 1;
            this.radioButtonStatusActive.TabStop = true;
            this.radioButtonStatusActive.Text = "ACTIVE";
            this.radioButtonStatusActive.UseVisualStyleBackColor = true;
            this.radioButtonStatusActive.CheckedChanged += new System.EventHandler(this.radioButtonStatusActive_CheckedChanged);
            // 
            // dataGridViewVendorInformation
            // 
            this.dataGridViewVendorInformation.AllowUserToAddRows = false;
            this.dataGridViewVendorInformation.AllowUserToDeleteRows = false;
            this.dataGridViewVendorInformation.AllowUserToOrderColumns = true;
            this.dataGridViewVendorInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendorInformation.Location = new System.Drawing.Point(6, 62);
            this.dataGridViewVendorInformation.Name = "dataGridViewVendorInformation";
            this.dataGridViewVendorInformation.ReadOnly = true;
            this.dataGridViewVendorInformation.RowTemplate.Height = 24;
            this.dataGridViewVendorInformation.Size = new System.Drawing.Size(862, 172);
            this.dataGridViewVendorInformation.TabIndex = 0;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(576, 255);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(132, 22);
            this.textBoxStatus.TabIndex = 25;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.listBoxStatus.Location = new System.Drawing.Point(576, 255);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(132, 36);
            this.listBoxStatus.TabIndex = 26;
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 717);
            this.Controls.Add(this.groupBoxSearchVendor);
            this.Controls.Add(this.groupBoxVendorIfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerManagementForm";
            this.Text = "CUSTOMER MANAGEMENT";
            this.Load += new System.EventHandler(this.VendorForm_Load);
            this.groupBoxVendorIfo.ResumeLayout(false);
            this.groupBoxVendorIfo.PerformLayout();
            this.groupBoxSearchVendor.ResumeLayout(false);
            this.groupBoxSearchVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendorInformation)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxMailId;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.TextBox textBoxDiscountId;
        private System.Windows.Forms.Button buttonDynamicButton;
        private System.Windows.Forms.Button buttonCancelVender;
        private System.Windows.Forms.GroupBox groupBoxVendorIfo;
        private System.Windows.Forms.RadioButton radioButtonDeleteVendor;
        private System.Windows.Forms.RadioButton radioButtonModifyVendor;
        private System.Windows.Forms.RadioButton radioButtonAddNewVendor;
        private System.Windows.Forms.GroupBox groupBoxSearchVendor;
        private System.Windows.Forms.DataGridView dataGridViewVendorInformation;
        private System.Windows.Forms.Label labelVendorStatus;
        private System.Windows.Forms.RadioButton radioButtonStatusInActive;
        private System.Windows.Forms.RadioButton radioButtonStatusActive;
        private System.Windows.Forms.Button buttonSearchVendor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ListBox listBoxStatus;
    }
}