namespace ConsignmentCompanyProject.com.windows.forms
{
    partial class CustomerMainWindow
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.menuStripCustomer = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERRETURNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOTALBALANCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pURCHASEREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSessionUser = new System.Windows.Forms.Label();
            this.labelSessionVendor = new System.Windows.Forms.Label();
            this.labelSessionDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomerOrders = new System.Windows.Forms.DataGridView();
            this.radioButtonCompleted = new System.Windows.Forms.RadioButton();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.groupBoxCancelOrder = new System.Windows.Forms.GroupBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.textBoxCancelDescription = new System.Windows.Forms.TextBox();
            this.buttonCloseCancel = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCancelOrderId = new System.Windows.Forms.TextBox();
            this.labelCancel = new System.Windows.Forms.Label();
            this.radioButtonCancelled = new System.Windows.Forms.RadioButton();
            this.radioButtonAllOrder = new System.Windows.Forms.RadioButton();
            this.textBoxSessionUser = new System.Windows.Forms.TextBox();
            this.textBoxSessionVendor = new System.Windows.Forms.TextBox();
            this.textBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.uSERPROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerOrders)).BeginInit();
            this.groupBoxCancelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(985, 131);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 17);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "DATE";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(985, 101);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(67, 17);
            this.labelVendorName.TabIndex = 9;
            this.labelVendorName.Text = "VENDOR";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(985, 64);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(46, 17);
            this.labelUserName.TabIndex = 8;
            this.labelUserName.Text = "USER";
            // 
            // menuStripCustomer
            // 
            this.menuStripCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.oRDERSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.menuStripCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripCustomer.Name = "menuStripCustomer";
            this.menuStripCustomer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripCustomer.Size = new System.Drawing.Size(1273, 28);
            this.menuStripCustomer.TabIndex = 14;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.uSERPROFILEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "&FILE";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.eXITToolStripMenuItem.Text = "&EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // oRDERSToolStripMenuItem
            // 
            this.oRDERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCustomer,
            this.cANCELORDERToolStripMenuItem,
            this.oRDERRETURNSToolStripMenuItem});
            this.oRDERSToolStripMenuItem.Name = "oRDERSToolStripMenuItem";
            this.oRDERSToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.oRDERSToolStripMenuItem.Text = "OR&DERS";
            // 
            // ToolStripMenuItemCustomer
            // 
            this.ToolStripMenuItemCustomer.Name = "ToolStripMenuItemCustomer";
            this.ToolStripMenuItemCustomer.Size = new System.Drawing.Size(199, 26);
            this.ToolStripMenuItemCustomer.Text = "&NEW ORDER ";
            this.ToolStripMenuItemCustomer.Click += new System.EventHandler(this.ToolStripMenuItemCustomer_Click);
            // 
            // cANCELORDERToolStripMenuItem
            // 
            this.cANCELORDERToolStripMenuItem.Name = "cANCELORDERToolStripMenuItem";
            this.cANCELORDERToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cANCELORDERToolStripMenuItem.Text = "&CANCEL ORDER";
            this.cANCELORDERToolStripMenuItem.Click += new System.EventHandler(this.cANCELORDERToolStripMenuItem_Click);
            // 
            // oRDERRETURNSToolStripMenuItem
            // 
            this.oRDERRETURNSToolStripMenuItem.Name = "oRDERRETURNSToolStripMenuItem";
            this.oRDERRETURNSToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.oRDERRETURNSToolStripMenuItem.Text = "ORDER &RETURNS";
            this.oRDERRETURNSToolStripMenuItem.Click += new System.EventHandler(this.oRDERRETURNSToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOTALBALANCEToolStripMenuItem,
            this.pURCHASEREPORTToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.rEPORTSToolStripMenuItem.Text = "&REPORTS";
            // 
            // tOTALBALANCEToolStripMenuItem
            // 
            this.tOTALBALANCEToolStripMenuItem.Name = "tOTALBALANCEToolStripMenuItem";
            this.tOTALBALANCEToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.tOTALBALANCEToolStripMenuItem.Text = "OUTSTANDING &BALANCE";
            // 
            // pURCHASEREPORTToolStripMenuItem
            // 
            this.pURCHASEREPORTToolStripMenuItem.Name = "pURCHASEREPORTToolStripMenuItem";
            this.pURCHASEREPORTToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.pURCHASEREPORTToolStripMenuItem.Text = "PURCHASE &REPORT";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.aBOUTToolStripMenuItem.Text = "&ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // labelSessionUser
            // 
            this.labelSessionUser.AutoSize = true;
            this.labelSessionUser.Location = new System.Drawing.Point(1096, 64);
            this.labelSessionUser.Name = "labelSessionUser";
            this.labelSessionUser.Size = new System.Drawing.Size(0, 17);
            this.labelSessionUser.TabIndex = 16;
            // 
            // labelSessionVendor
            // 
            this.labelSessionVendor.AutoSize = true;
            this.labelSessionVendor.Location = new System.Drawing.Point(1096, 101);
            this.labelSessionVendor.Name = "labelSessionVendor";
            this.labelSessionVendor.Size = new System.Drawing.Size(0, 17);
            this.labelSessionVendor.TabIndex = 17;
            // 
            // labelSessionDate
            // 
            this.labelSessionDate.AutoSize = true;
            this.labelSessionDate.Location = new System.Drawing.Point(1096, 131);
            this.labelSessionDate.Name = "labelSessionDate";
            this.labelSessionDate.Size = new System.Drawing.Size(0, 17);
            this.labelSessionDate.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCustomerOrders);
            this.groupBox1.Location = new System.Drawing.Point(63, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 345);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORDERS";
            // 
            // dataGridViewCustomerOrders
            // 
            this.dataGridViewCustomerOrders.AllowUserToAddRows = false;
            this.dataGridViewCustomerOrders.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomerOrders.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewCustomerOrders.Name = "dataGridViewCustomerOrders";
            this.dataGridViewCustomerOrders.ReadOnly = true;
            this.dataGridViewCustomerOrders.RowTemplate.Height = 24;
            this.dataGridViewCustomerOrders.Size = new System.Drawing.Size(1070, 324);
            this.dataGridViewCustomerOrders.TabIndex = 0;
            // 
            // radioButtonCompleted
            // 
            this.radioButtonCompleted.AutoSize = true;
            this.radioButtonCompleted.Location = new System.Drawing.Point(818, 324);
            this.radioButtonCompleted.Name = "radioButtonCompleted";
            this.radioButtonCompleted.Size = new System.Drawing.Size(114, 21);
            this.radioButtonCompleted.TabIndex = 20;
            this.radioButtonCompleted.TabStop = true;
            this.radioButtonCompleted.Text = "COMPLETED";
            this.radioButtonCompleted.UseVisualStyleBackColor = true;
            this.radioButtonCompleted.CheckedChanged += new System.EventHandler(this.radioButtonCompleted_CheckedChanged);
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Location = new System.Drawing.Point(711, 324);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(77, 21);
            this.radioButtonActive.TabIndex = 21;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "ACTIVE";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            this.radioButtonActive.CheckedChanged += new System.EventHandler(this.radioButtonActive_CheckedChanged);
            // 
            // groupBoxCancelOrder
            // 
            this.groupBoxCancelOrder.Controls.Add(this.labelReason);
            this.groupBoxCancelOrder.Controls.Add(this.textBoxCancelDescription);
            this.groupBoxCancelOrder.Controls.Add(this.buttonCloseCancel);
            this.groupBoxCancelOrder.Controls.Add(this.buttonCancel);
            this.groupBoxCancelOrder.Controls.Add(this.textBoxCancelOrderId);
            this.groupBoxCancelOrder.Controls.Add(this.labelCancel);
            this.groupBoxCancelOrder.Location = new System.Drawing.Point(63, 154);
            this.groupBoxCancelOrder.Name = "groupBoxCancelOrder";
            this.groupBoxCancelOrder.Size = new System.Drawing.Size(566, 125);
            this.groupBoxCancelOrder.TabIndex = 22;
            this.groupBoxCancelOrder.TabStop = false;
            this.groupBoxCancelOrder.Text = "CANCEL ORDERS";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(24, 69);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(66, 17);
            this.labelReason.TabIndex = 5;
            this.labelReason.Text = "REASON";
            // 
            // textBoxCancelDescription
            // 
            this.textBoxCancelDescription.Location = new System.Drawing.Point(152, 69);
            this.textBoxCancelDescription.Multiline = true;
            this.textBoxCancelDescription.Name = "textBoxCancelDescription";
            this.textBoxCancelDescription.Size = new System.Drawing.Size(188, 50);
            this.textBoxCancelDescription.TabIndex = 4;
            // 
            // buttonCloseCancel
            // 
            this.buttonCloseCancel.Location = new System.Drawing.Point(527, 11);
            this.buttonCloseCancel.Name = "buttonCloseCancel";
            this.buttonCloseCancel.Size = new System.Drawing.Size(33, 23);
            this.buttonCloseCancel.TabIndex = 3;
            this.buttonCloseCancel.Text = "X";
            this.buttonCloseCancel.UseVisualStyleBackColor = true;
            this.buttonCloseCancel.Click += new System.EventHandler(this.buttonCloseCancel_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(390, 95);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 24);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&CANCEL ORDER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxCancelOrderId
            // 
            this.textBoxCancelOrderId.Location = new System.Drawing.Point(152, 31);
            this.textBoxCancelOrderId.Name = "textBoxCancelOrderId";
            this.textBoxCancelOrderId.Size = new System.Drawing.Size(100, 22);
            this.textBoxCancelOrderId.TabIndex = 1;
            // 
            // labelCancel
            // 
            this.labelCancel.AutoSize = true;
            this.labelCancel.Location = new System.Drawing.Point(21, 31);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(75, 17);
            this.labelCancel.TabIndex = 0;
            this.labelCancel.Text = "ORDER ID";
            // 
            // radioButtonCancelled
            // 
            this.radioButtonCancelled.AutoSize = true;
            this.radioButtonCancelled.Location = new System.Drawing.Point(953, 324);
            this.radioButtonCancelled.Name = "radioButtonCancelled";
            this.radioButtonCancelled.Size = new System.Drawing.Size(110, 21);
            this.radioButtonCancelled.TabIndex = 24;
            this.radioButtonCancelled.TabStop = true;
            this.radioButtonCancelled.Text = "CANCELLED";
            this.radioButtonCancelled.UseVisualStyleBackColor = true;
            this.radioButtonCancelled.CheckedChanged += new System.EventHandler(this.radioButtonCancelled_CheckedChanged);
            // 
            // radioButtonAllOrder
            // 
            this.radioButtonAllOrder.AutoSize = true;
            this.radioButtonAllOrder.Location = new System.Drawing.Point(1082, 324);
            this.radioButtonAllOrder.Name = "radioButtonAllOrder";
            this.radioButtonAllOrder.Size = new System.Drawing.Size(54, 21);
            this.radioButtonAllOrder.TabIndex = 25;
            this.radioButtonAllOrder.TabStop = true;
            this.radioButtonAllOrder.Text = "ALL";
            this.radioButtonAllOrder.UseVisualStyleBackColor = true;
            this.radioButtonAllOrder.CheckedChanged += new System.EventHandler(this.radioButtonAllOrder_CheckedChanged);
            // 
            // textBoxSessionUser
            // 
            this.textBoxSessionUser.Location = new System.Drawing.Point(1099, 59);
            this.textBoxSessionUser.Name = "textBoxSessionUser";
            this.textBoxSessionUser.ReadOnly = true;
            this.textBoxSessionUser.Size = new System.Drawing.Size(100, 22);
            this.textBoxSessionUser.TabIndex = 27;
            // 
            // textBoxSessionVendor
            // 
            this.textBoxSessionVendor.Location = new System.Drawing.Point(1099, 96);
            this.textBoxSessionVendor.Name = "textBoxSessionVendor";
            this.textBoxSessionVendor.ReadOnly = true;
            this.textBoxSessionVendor.Size = new System.Drawing.Size(100, 22);
            this.textBoxSessionVendor.TabIndex = 28;
            // 
            // textBoxCurrentDate
            // 
            this.textBoxCurrentDate.Location = new System.Drawing.Point(1099, 128);
            this.textBoxCurrentDate.Name = "textBoxCurrentDate";
            this.textBoxCurrentDate.ReadOnly = true;
            this.textBoxCurrentDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrentDate.TabIndex = 29;
            // 
            // uSERPROFILEToolStripMenuItem
            // 
            this.uSERPROFILEToolStripMenuItem.Name = "uSERPROFILEToolStripMenuItem";
            this.uSERPROFILEToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.uSERPROFILEToolStripMenuItem.Text = "&USER PROFILE";
            this.uSERPROFILEToolStripMenuItem.Click += new System.EventHandler(this.uSERPROFILEToolStripMenuItem_Click);
            // 
            // CustomerMainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1273, 724);
            this.Controls.Add(this.textBoxCurrentDate);
            this.Controls.Add(this.textBoxSessionVendor);
            this.Controls.Add(this.textBoxSessionUser);
            this.Controls.Add(this.radioButtonAllOrder);
            this.Controls.Add(this.radioButtonCancelled);
            this.Controls.Add(this.groupBoxCancelOrder);
            this.Controls.Add(this.radioButtonActive);
            this.Controls.Add(this.radioButtonCompleted);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSessionDate);
            this.Controls.Add(this.labelSessionVendor);
            this.Controls.Add(this.labelSessionUser);
            this.Controls.Add(this.menuStripCustomer);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelVendorName);
            this.Controls.Add(this.labelUserName);
            this.IsMdiContainer = true;
            this.Name = "CustomerMainWindow";
            this.Text = "CUSTOMER WINDOW";
            this.Load += new System.EventHandler(this.CustomerMainWindow_Load);
            this.menuStripCustomer.ResumeLayout(false);
            this.menuStripCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerOrders)).EndInit();
            this.groupBoxCancelOrder.ResumeLayout(false);
            this.groupBoxCancelOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MenuStrip menuStripCustomer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCustomer;
        private System.Windows.Forms.ToolStripMenuItem cANCELORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERRETURNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOTALBALANCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pURCHASEREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.Label labelSessionUser;
        private System.Windows.Forms.Label labelSessionVendor;
        private System.Windows.Forms.Label labelSessionDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewCustomerOrders;
        private System.Windows.Forms.RadioButton radioButtonCompleted;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.GroupBox groupBoxCancelOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCancelOrderId;
        private System.Windows.Forms.Label labelCancel;
        private System.Windows.Forms.Button buttonCloseCancel;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.TextBox textBoxCancelDescription;
        private System.Windows.Forms.RadioButton radioButtonCancelled;
        private System.Windows.Forms.RadioButton radioButtonAllOrder;
        private System.Windows.Forms.TextBox textBoxSessionUser;
        private System.Windows.Forms.TextBox textBoxSessionVendor;
        private System.Windows.Forms.TextBox textBoxCurrentDate;
        private System.Windows.Forms.ToolStripMenuItem uSERPROFILEToolStripMenuItem;
    }
}