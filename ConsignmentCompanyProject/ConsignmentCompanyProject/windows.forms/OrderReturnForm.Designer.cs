namespace ConsignmentCompanyProject.windows.forms
{
    partial class OrderReturnForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.panelReturnOrder = new System.Windows.Forms.Panel();
            this.groupBoxProcessOrder = new System.Windows.Forms.GroupBox();
            this.dataGridViewProcessedOrders = new System.Windows.Forms.DataGridView();
            this.labelReturnOrderHeading = new System.Windows.Forms.Label();
            this.groupBoxOrderInformation = new System.Windows.Forms.GroupBox();
            this.dataGridViewItinerary = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.textBoxReturnId = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelReturnID = new System.Windows.Forms.Label();
            this.textBoxVendorName = new System.Windows.Forms.TextBox();
            this.buttonCreateReturn = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxReturnReason = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelProductReturn = new System.Windows.Forms.Label();
            this.textBoxReturnTotal = new System.Windows.Forms.TextBox();
            this.labelReturnStatus = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxReturnStatus = new System.Windows.Forms.TextBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelReturnOrder.SuspendLayout();
            this.groupBoxProcessOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessedOrders)).BeginInit();
            this.groupBoxOrderInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItinerary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Order Return ";
            // 
            // panelReturnOrder
            // 
            this.panelReturnOrder.Controls.Add(this.groupBoxProcessOrder);
            this.panelReturnOrder.Controls.Add(this.labelReturnOrderHeading);
            this.panelReturnOrder.Controls.Add(this.groupBoxOrderInformation);
            this.panelReturnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReturnOrder.Location = new System.Drawing.Point(3, 18);
            this.panelReturnOrder.Name = "panelReturnOrder";
            this.panelReturnOrder.Size = new System.Drawing.Size(1071, 688);
            this.panelReturnOrder.TabIndex = 36;
            // 
            // groupBoxProcessOrder
            // 
            this.groupBoxProcessOrder.Controls.Add(this.dataGridViewProcessedOrders);
            this.groupBoxProcessOrder.Location = new System.Drawing.Point(78, 50);
            this.groupBoxProcessOrder.Name = "groupBoxProcessOrder";
            this.groupBoxProcessOrder.Size = new System.Drawing.Size(689, 168);
            this.groupBoxProcessOrder.TabIndex = 36;
            this.groupBoxProcessOrder.TabStop = false;
            this.groupBoxProcessOrder.Text = "SELECT PROCESSED ORDER";
            // 
            // dataGridViewProcessedOrders
            // 
            this.dataGridViewProcessedOrders.AllowUserToAddRows = false;
            this.dataGridViewProcessedOrders.AllowUserToDeleteRows = false;
            this.dataGridViewProcessedOrders.AllowUserToOrderColumns = true;
            this.dataGridViewProcessedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcessedOrders.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewProcessedOrders.Name = "dataGridViewProcessedOrders";
            this.dataGridViewProcessedOrders.ReadOnly = true;
            this.dataGridViewProcessedOrders.RowTemplate.Height = 24;
            this.dataGridViewProcessedOrders.Size = new System.Drawing.Size(683, 147);
            this.dataGridViewProcessedOrders.TabIndex = 0;
            this.dataGridViewProcessedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessedOrder_CellClick);
            // 
            // labelReturnOrderHeading
            // 
            this.labelReturnOrderHeading.AutoSize = true;
            this.labelReturnOrderHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnOrderHeading.Location = new System.Drawing.Point(471, 8);
            this.labelReturnOrderHeading.Name = "labelReturnOrderHeading";
            this.labelReturnOrderHeading.Size = new System.Drawing.Size(221, 29);
            this.labelReturnOrderHeading.TabIndex = 35;
            this.labelReturnOrderHeading.Text = "ORDER RETURN ";
            // 
            // groupBoxOrderInformation
            // 
            this.groupBoxOrderInformation.Controls.Add(this.dataGridViewItinerary);
            this.groupBoxOrderInformation.Controls.Add(this.buttonCancel);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxOrderId);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxReturnId);
            this.groupBoxOrderInformation.Controls.Add(this.labelOrder);
            this.groupBoxOrderInformation.Controls.Add(this.labelReturnID);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxVendorName);
            this.groupBoxOrderInformation.Controls.Add(this.buttonCreateReturn);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxCount);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxReturnReason);
            this.groupBoxOrderInformation.Controls.Add(this.labelTotal);
            this.groupBoxOrderInformation.Controls.Add(this.labelVendorName);
            this.groupBoxOrderInformation.Controls.Add(this.labelProductReturn);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxReturnTotal);
            this.groupBoxOrderInformation.Controls.Add(this.labelReturnStatus);
            this.groupBoxOrderInformation.Controls.Add(this.labelCount);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxReturnStatus);
            this.groupBoxOrderInformation.Controls.Add(this.labelReason);
            this.groupBoxOrderInformation.Location = new System.Drawing.Point(78, 224);
            this.groupBoxOrderInformation.Name = "groupBoxOrderInformation";
            this.groupBoxOrderInformation.Size = new System.Drawing.Size(939, 455);
            this.groupBoxOrderInformation.TabIndex = 37;
            this.groupBoxOrderInformation.TabStop = false;
            this.groupBoxOrderInformation.Text = "ORDER INFORMATION";
            // 
            // dataGridViewItinerary
            // 
            this.dataGridViewItinerary.AllowUserToAddRows = false;
            this.dataGridViewItinerary.AllowUserToDeleteRows = false;
            this.dataGridViewItinerary.AllowUserToOrderColumns = true;
            this.dataGridViewItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItinerary.Location = new System.Drawing.Point(282, 120);
            this.dataGridViewItinerary.Name = "dataGridViewItinerary";
            this.dataGridViewItinerary.ReadOnly = true;
            this.dataGridViewItinerary.RowTemplate.Height = 24;
            this.dataGridViewItinerary.Size = new System.Drawing.Size(651, 161);
            this.dataGridViewItinerary.TabIndex = 36;
            this.dataGridViewItinerary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItinerary_CellClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Location = new System.Drawing.Point(468, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 32);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "&CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(283, 26);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.ReadOnly = true;
            this.textBoxOrderId.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderId.TabIndex = 27;
            // 
            // textBoxReturnId
            // 
            this.textBoxReturnId.Location = new System.Drawing.Point(717, 27);
            this.textBoxReturnId.Name = "textBoxReturnId";
            this.textBoxReturnId.ReadOnly = true;
            this.textBoxReturnId.Size = new System.Drawing.Size(100, 22);
            this.textBoxReturnId.TabIndex = 35;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(60, 27);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(66, 17);
            this.labelOrder.TabIndex = 19;
            this.labelOrder.Text = "ORDER#";
            // 
            // labelReturnID
            // 
            this.labelReturnID.AutoSize = true;
            this.labelReturnID.Location = new System.Drawing.Point(564, 30);
            this.labelReturnID.Name = "labelReturnID";
            this.labelReturnID.Size = new System.Drawing.Size(91, 17);
            this.labelReturnID.TabIndex = 34;
            this.labelReturnID.Text = "RETURN ID#";
            // 
            // textBoxVendorName
            // 
            this.textBoxVendorName.Location = new System.Drawing.Point(282, 68);
            this.textBoxVendorName.Name = "textBoxVendorName";
            this.textBoxVendorName.ReadOnly = true;
            this.textBoxVendorName.Size = new System.Drawing.Size(100, 22);
            this.textBoxVendorName.TabIndex = 28;
            // 
            // buttonCreateReturn
            // 
            this.buttonCreateReturn.Location = new System.Drawing.Point(299, 392);
            this.buttonCreateReturn.Name = "buttonCreateReturn";
            this.buttonCreateReturn.Size = new System.Drawing.Size(144, 32);
            this.buttonCreateReturn.TabIndex = 26;
            this.buttonCreateReturn.Text = "SUBMIT &RETURN";
            this.buttonCreateReturn.UseVisualStyleBackColor = true;
            this.buttonCreateReturn.Click += new System.EventHandler(this.buttonCreateReturn_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(282, 307);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 30;
            this.textBoxCount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCount_Validating);
            // 
            // textBoxReturnReason
            // 
            this.textBoxReturnReason.Location = new System.Drawing.Point(558, 310);
            this.textBoxReturnReason.Multiline = true;
            this.textBoxReturnReason.Name = "textBoxReturnReason";
            this.textBoxReturnReason.Size = new System.Drawing.Size(311, 62);
            this.textBoxReturnReason.TabIndex = 31;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(61, 348);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 17);
            this.labelTotal.TabIndex = 24;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(60, 68);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(84, 17);
            this.labelVendorName.TabIndex = 20;
            this.labelVendorName.Text = "VENDOR ID";
            // 
            // labelProductReturn
            // 
            this.labelProductReturn.AutoSize = true;
            this.labelProductReturn.Location = new System.Drawing.Point(61, 120);
            this.labelProductReturn.Name = "labelProductReturn";
            this.labelProductReturn.Size = new System.Drawing.Size(133, 17);
            this.labelProductReturn.TabIndex = 21;
            this.labelProductReturn.Text = "SELECT PRODUCT";
            // 
            // textBoxReturnTotal
            // 
            this.textBoxReturnTotal.Location = new System.Drawing.Point(282, 345);
            this.textBoxReturnTotal.Name = "textBoxReturnTotal";
            this.textBoxReturnTotal.ReadOnly = true;
            this.textBoxReturnTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxReturnTotal.TabIndex = 33;
            // 
            // labelReturnStatus
            // 
            this.labelReturnStatus.AutoSize = true;
            this.labelReturnStatus.Location = new System.Drawing.Point(564, 63);
            this.labelReturnStatus.Name = "labelReturnStatus";
            this.labelReturnStatus.Size = new System.Drawing.Size(125, 17);
            this.labelReturnStatus.TabIndex = 25;
            this.labelReturnStatus.Text = "RETURN STATUS";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(61, 310);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(173, 17);
            this.labelCount.TabIndex = 23;
            this.labelCount.Text = "RETURNS UNITS COUNT";
            // 
            // textBoxReturnStatus
            // 
            this.textBoxReturnStatus.Location = new System.Drawing.Point(717, 63);
            this.textBoxReturnStatus.Name = "textBoxReturnStatus";
            this.textBoxReturnStatus.ReadOnly = true;
            this.textBoxReturnStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxReturnStatus.TabIndex = 32;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(555, 287);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(100, 17);
            this.labelReason.TabIndex = 22;
            this.labelReason.Text = "DESCRIPTION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelReturnOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 709);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // OrderReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1077, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Name = "OrderReturnForm";
            this.Text = "ORDER RETURN";
            this.Load += new System.EventHandler(this.OrderReturnForm_Load);
            this.panelReturnOrder.ResumeLayout(false);
            this.panelReturnOrder.PerformLayout();
            this.groupBoxProcessOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessedOrders)).EndInit();
            this.groupBoxOrderInformation.ResumeLayout(false);
            this.groupBoxOrderInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItinerary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelReturnOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelReturnOrderHeading;
        private System.Windows.Forms.TextBox textBoxReturnReason;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxVendorName;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Button buttonCreateReturn;
        private System.Windows.Forms.Label labelReturnStatus;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label labelProductReturn;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.TextBox textBoxReturnTotal;
        private System.Windows.Forms.TextBox textBoxReturnStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxProcessOrder;
        private System.Windows.Forms.DataGridView dataGridViewProcessedOrders;
        private System.Windows.Forms.GroupBox groupBoxOrderInformation;
        private System.Windows.Forms.TextBox textBoxReturnId;
        private System.Windows.Forms.Label labelReturnID;
        private System.Windows.Forms.DataGridView dataGridViewItinerary;
    }
}