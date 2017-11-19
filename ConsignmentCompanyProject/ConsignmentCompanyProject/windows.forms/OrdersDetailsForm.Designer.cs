namespace ConsignmentCompanyProject.com.windows.forms
{
    partial class OrdersDetailsForm
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
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxVendorId = new System.Windows.Forms.TextBox();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridViewItinerary = new System.Windows.Forms.DataGridView();
            this.labelVendorId = new System.Windows.Forms.Label();
            this.labeliOrderID = new System.Windows.Forms.Label();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItinerary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.textBoxDate);
            this.groupBoxOrder.Controls.Add(this.textBoxVendorId);
            this.groupBoxOrder.Controls.Add(this.textBoxOrderId);
            this.groupBoxOrder.Controls.Add(this.buttonUpdate);
            this.groupBoxOrder.Controls.Add(this.labelStatus);
            this.groupBoxOrder.Controls.Add(this.listBoxStatus);
            this.groupBoxOrder.Controls.Add(this.labelDate);
            this.groupBoxOrder.Controls.Add(this.dataGridViewItinerary);
            this.groupBoxOrder.Controls.Add(this.labelVendorId);
            this.groupBoxOrder.Controls.Add(this.labeliOrderID);
            this.groupBoxOrder.Location = new System.Drawing.Point(33, 36);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(1003, 582);
            this.groupBoxOrder.TabIndex = 0;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "NEW ORDER";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(847, 56);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(88, 22);
            this.textBoxDate.TabIndex = 9;
            // 
            // textBoxVendorId
            // 
            this.textBoxVendorId.Location = new System.Drawing.Point(204, 111);
            this.textBoxVendorId.Name = "textBoxVendorId";
            this.textBoxVendorId.ReadOnly = true;
            this.textBoxVendorId.Size = new System.Drawing.Size(105, 22);
            this.textBoxVendorId.TabIndex = 8;
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(204, 56);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.ReadOnly = true;
            this.textBoxOrderId.Size = new System.Drawing.Size(105, 22);
            this.textBoxOrderId.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(439, 174);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 36);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "&UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(66, 174);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(123, 17);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "UPDATE STATUS";
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Items.AddRange(new object[] {
            "INPROCESS",
            "COMPLETED"});
            this.listBoxStatus.Location = new System.Drawing.Point(257, 174);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(157, 36);
            this.listBoxStatus.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(753, 61);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 17);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "DATE";
            // 
            // dataGridViewItinerary
            // 
            this.dataGridViewItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItinerary.Location = new System.Drawing.Point(47, 246);
            this.dataGridViewItinerary.Name = "dataGridViewItinerary";
            this.dataGridViewItinerary.RowTemplate.Height = 24;
            this.dataGridViewItinerary.Size = new System.Drawing.Size(918, 306);
            this.dataGridViewItinerary.TabIndex = 2;
            // 
            // labelVendorId
            // 
            this.labelVendorId.AutoSize = true;
            this.labelVendorId.Location = new System.Drawing.Point(66, 116);
            this.labelVendorId.Name = "labelVendorId";
            this.labelVendorId.Size = new System.Drawing.Size(84, 17);
            this.labelVendorId.TabIndex = 1;
            this.labelVendorId.Text = "VENDOR ID";
            // 
            // labeliOrderID
            // 
            this.labeliOrderID.AutoSize = true;
            this.labeliOrderID.Location = new System.Drawing.Point(66, 61);
            this.labeliOrderID.Name = "labeliOrderID";
            this.labeliOrderID.Size = new System.Drawing.Size(75, 17);
            this.labeliOrderID.TabIndex = 0;
            this.labeliOrderID.Text = "ORDER ID";
            // 
            // OrdersDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 642);
            this.Controls.Add(this.groupBoxOrder);
            this.Name = "OrdersDetailsForm";
            this.Text = "ORDER DETAILS";
            this.Load += new System.EventHandler(this.ordersDetailsForm_Load);
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItinerary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxOrder;
        public System.Windows.Forms.DataGridView dataGridViewItinerary;
        public System.Windows.Forms.Label labelVendorId;
        public System.Windows.Forms.Label labeliOrderID;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxVendorId;
        private System.Windows.Forms.TextBox textBoxOrderId;
    }
}