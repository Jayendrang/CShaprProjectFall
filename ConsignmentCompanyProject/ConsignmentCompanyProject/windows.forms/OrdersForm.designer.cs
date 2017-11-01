namespace ConsignmentCompanyProject
{
    partial class Orders
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
            this.panelOrder = new System.Windows.Forms.Panel();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.lablelProductName = new System.Windows.Forms.Label();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.labelManufacturerName = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.labelProductType = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxDiscountId = new System.Windows.Forms.TextBox();
            this.textBoxBalanceAmount = new System.Windows.Forms.TextBox();
            this.textBoxPricePerUnit = new System.Windows.Forms.TextBox();
            this.textBoxRaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelDiscountId = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelBalanceAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelPricePerUnit = new System.Windows.Forms.Label();
            this.groupBoxVendor = new System.Windows.Forms.GroupBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxVendor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelVendorId = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonSubmitOrder = new System.Windows.Forms.Button();
            this.panelOrder.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.groupBoxVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrder
            // 
            this.panelOrder.AutoSize = true;
            this.panelOrder.Controls.Add(this.groupBoxOrderDetails);
            this.panelOrder.Controls.Add(this.groupBoxVendor);
            this.panelOrder.Controls.Add(this.labelFormTitle);
            this.panelOrder.Controls.Add(this.buttonAddToOrder);
            this.panelOrder.Controls.Add(this.buttonCancelOrder);
            this.panelOrder.Controls.Add(this.buttonSubmitOrder);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1035, 652);
            this.panelOrder.TabIndex = 0;
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.textBoxOrderDate);
            this.groupBoxOrderDetails.Controls.Add(this.labelDate);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxOrderId);
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderID);
            this.groupBoxOrderDetails.Controls.Add(this.comboBoxProductName);
            this.groupBoxOrderDetails.Controls.Add(this.lablelProductName);
            this.groupBoxOrderDetails.Controls.Add(this.comboBoxManufacturer);
            this.groupBoxOrderDetails.Controls.Add(this.labelManufacturerName);
            this.groupBoxOrderDetails.Controls.Add(this.comboBoxProductType);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxProduct);
            this.groupBoxOrderDetails.Controls.Add(this.labelProductType);
            this.groupBoxOrderDetails.Controls.Add(this.labelProductId);
            this.groupBoxOrderDetails.Controls.Add(this.labelTotalPrice);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxDiscountId);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxBalanceAmount);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxPricePerUnit);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxRaidAmount);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxCount);
            this.groupBoxOrderDetails.Controls.Add(this.labelDiscountId);
            this.groupBoxOrderDetails.Controls.Add(this.labelPaidAmount);
            this.groupBoxOrderDetails.Controls.Add(this.labelBalanceAmount);
            this.groupBoxOrderDetails.Controls.Add(this.label10);
            this.groupBoxOrderDetails.Controls.Add(this.labelCount);
            this.groupBoxOrderDetails.Controls.Add(this.labelPricePerUnit);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(66, 118);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(919, 327);
            this.groupBoxOrderDetails.TabIndex = 83;
            this.groupBoxOrderDetails.TabStop = false;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Location = new System.Drawing.Point(212, 69);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.ReadOnly = true;
            this.textBoxOrderDate.Size = new System.Drawing.Size(113, 22);
            this.textBoxOrderDate.TabIndex = 84;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(45, 74);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 17);
            this.labelDate.TabIndex = 83;
            this.labelDate.Text = "DATE";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(212, 34);
            this.textBoxOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.ReadOnly = true;
            this.textBoxOrderId.Size = new System.Drawing.Size(113, 22);
            this.textBoxOrderId.TabIndex = 82;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(45, 39);
            this.labelOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(75, 17);
            this.labelOrderID.TabIndex = 81;
            this.labelOrderID.Text = "ORDER ID";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(212, 192);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProductName.TabIndex = 80;
            // 
            // lablelProductName
            // 
            this.lablelProductName.AutoSize = true;
            this.lablelProductName.Location = new System.Drawing.Point(45, 199);
            this.lablelProductName.Name = "lablelProductName";
            this.lablelProductName.Size = new System.Drawing.Size(119, 17);
            this.lablelProductName.TabIndex = 79;
            this.lablelProductName.Text = "PRODUCT NAME";
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(212, 152);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(160, 24);
            this.comboBoxManufacturer.TabIndex = 78;
            // 
            // labelManufacturerName
            // 
            this.labelManufacturerName.AutoSize = true;
            this.labelManufacturerName.Location = new System.Drawing.Point(45, 156);
            this.labelManufacturerName.Name = "labelManufacturerName";
            this.labelManufacturerName.Size = new System.Drawing.Size(122, 17);
            this.labelManufacturerName.TabIndex = 77;
            this.labelManufacturerName.Text = "MANUFACTURER";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(212, 114);
            this.comboBoxProductType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProductType.TabIndex = 76;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(212, 233);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.ReadOnly = true;
            this.textBoxProduct.Size = new System.Drawing.Size(104, 22);
            this.textBoxProduct.TabIndex = 75;
            // 
            // labelProductType
            // 
            this.labelProductType.AutoSize = true;
            this.labelProductType.Location = new System.Drawing.Point(45, 119);
            this.labelProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductType.Name = "labelProductType";
            this.labelProductType.Size = new System.Drawing.Size(116, 17);
            this.labelProductType.TabIndex = 74;
            this.labelProductType.Text = "PRODUCT TYPE";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(45, 238);
            this.labelProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(93, 17);
            this.labelProductId.TabIndex = 73;
            this.labelProductId.Text = "PRODUCT ID";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(236, 219);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(0, 17);
            this.labelTotalPrice.TabIndex = 72;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(739, 196);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(113, 22);
            this.textBoxTotalPrice.TabIndex = 62;
            // 
            // textBoxDiscountId
            // 
            this.textBoxDiscountId.Location = new System.Drawing.Point(739, 151);
            this.textBoxDiscountId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountId.Name = "textBoxDiscountId";
            this.textBoxDiscountId.ReadOnly = true;
            this.textBoxDiscountId.Size = new System.Drawing.Size(113, 22);
            this.textBoxDiscountId.TabIndex = 51;
            // 
            // textBoxBalanceAmount
            // 
            this.textBoxBalanceAmount.Location = new System.Drawing.Point(739, 233);
            this.textBoxBalanceAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBalanceAmount.Name = "textBoxBalanceAmount";
            this.textBoxBalanceAmount.Size = new System.Drawing.Size(113, 22);
            this.textBoxBalanceAmount.TabIndex = 50;
            // 
            // textBoxPricePerUnit
            // 
            this.textBoxPricePerUnit.Location = new System.Drawing.Point(739, 25);
            this.textBoxPricePerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.ReadOnly = true;
            this.textBoxPricePerUnit.Size = new System.Drawing.Size(113, 22);
            this.textBoxPricePerUnit.TabIndex = 49;
            // 
            // textBoxRaidAmount
            // 
            this.textBoxRaidAmount.Location = new System.Drawing.Point(739, 109);
            this.textBoxRaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRaidAmount.Name = "textBoxRaidAmount";
            this.textBoxRaidAmount.Size = new System.Drawing.Size(113, 22);
            this.textBoxRaidAmount.TabIndex = 48;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(739, 69);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(113, 22);
            this.textBoxCount.TabIndex = 47;
            // 
            // labelDiscountId
            // 
            this.labelDiscountId.AutoSize = true;
            this.labelDiscountId.Location = new System.Drawing.Point(548, 156);
            this.labelDiscountId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountId.Name = "labelDiscountId";
            this.labelDiscountId.Size = new System.Drawing.Size(96, 17);
            this.labelDiscountId.TabIndex = 42;
            this.labelDiscountId.Text = "DISCOUNT ID";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(548, 114);
            this.labelPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(103, 17);
            this.labelPaidAmount.TabIndex = 41;
            this.labelPaidAmount.Text = "PAID AMOUNT";
            // 
            // labelBalanceAmount
            // 
            this.labelBalanceAmount.AutoSize = true;
            this.labelBalanceAmount.Location = new System.Drawing.Point(548, 238);
            this.labelBalanceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceAmount.Name = "labelBalanceAmount";
            this.labelBalanceAmount.Size = new System.Drawing.Size(135, 17);
            this.labelBalanceAmount.TabIndex = 40;
            this.labelBalanceAmount.Text = "BALANCE AMOUNT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 203);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "TOTAL PRICE";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(548, 74);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 17);
            this.labelCount.TabIndex = 36;
            this.labelCount.Text = "COUNT";
            // 
            // labelPricePerUnit
            // 
            this.labelPricePerUnit.AutoSize = true;
            this.labelPricePerUnit.Location = new System.Drawing.Point(548, 30);
            this.labelPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPricePerUnit.Name = "labelPricePerUnit";
            this.labelPricePerUnit.Size = new System.Drawing.Size(116, 17);
            this.labelPricePerUnit.TabIndex = 35;
            this.labelPricePerUnit.Text = "PRICE PER UNIT";
            // 
            // groupBoxVendor
            // 
            this.groupBoxVendor.Controls.Add(this.textBoxUser);
            this.groupBoxVendor.Controls.Add(this.textBoxVendor);
            this.groupBoxVendor.Controls.Add(this.label8);
            this.groupBoxVendor.Controls.Add(this.labelVendorId);
            this.groupBoxVendor.Controls.Add(this.labelUserId);
            this.groupBoxVendor.Location = new System.Drawing.Point(711, 22);
            this.groupBoxVendor.Name = "groupBoxVendor";
            this.groupBoxVendor.Size = new System.Drawing.Size(274, 90);
            this.groupBoxVendor.TabIndex = 63;
            this.groupBoxVendor.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(137, 17);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(113, 22);
            this.textBoxUser.TabIndex = 45;
            // 
            // textBoxVendor
            // 
            this.textBoxVendor.Location = new System.Drawing.Point(137, 60);
            this.textBoxVendor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVendor.Name = "textBoxVendor";
            this.textBoxVendor.ReadOnly = true;
            this.textBoxVendor.Size = new System.Drawing.Size(113, 22);
            this.textBoxVendor.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 38;
            // 
            // labelVendorId
            // 
            this.labelVendorId.AutoSize = true;
            this.labelVendorId.Location = new System.Drawing.Point(18, 60);
            this.labelVendorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendorId.Name = "labelVendorId";
            this.labelVendorId.Size = new System.Drawing.Size(67, 17);
            this.labelVendorId.TabIndex = 34;
            this.labelVendorId.Text = "VENDOR";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(18, 20);
            this.labelUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(46, 17);
            this.labelUserId.TabIndex = 32;
            this.labelUserId.Text = "USER";
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.Location = new System.Drawing.Point(473, 30);
            this.labelFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(126, 29);
            this.labelFormTitle.TabIndex = 57;
            this.labelFormTitle.Text = "ORDERS\r\n";
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(632, 452);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(135, 28);
            this.buttonAddToOrder.TabIndex = 56;
            this.buttonAddToOrder.Text = "&ADD TO CART";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(478, 452);
            this.buttonCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(121, 28);
            this.buttonCancelOrder.TabIndex = 55;
            this.buttonCancelOrder.Text = "&CANCEL";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitOrder
            // 
            this.buttonSubmitOrder.Location = new System.Drawing.Point(308, 452);
            this.buttonSubmitOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitOrder.Name = "buttonSubmitOrder";
            this.buttonSubmitOrder.Size = new System.Drawing.Size(130, 28);
            this.buttonSubmitOrder.TabIndex = 54;
            this.buttonSubmitOrder.Text = "SUBMIT &ORDER";
            this.buttonSubmitOrder.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1035, 652);
            this.Controls.Add(this.panelOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orders";
            this.Text = "PURCHASE ORDER ";
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.groupBoxVendor.ResumeLayout(false);
            this.groupBoxVendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonSubmitOrder;
        private System.Windows.Forms.TextBox textBoxDiscountId;
        private System.Windows.Forms.TextBox textBoxBalanceAmount;
        private System.Windows.Forms.TextBox textBoxPricePerUnit;
        private System.Windows.Forms.TextBox textBoxRaidAmount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxVendor;
        private System.Windows.Forms.Label labelDiscountId;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelBalanceAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPricePerUnit;
        private System.Windows.Forms.Label labelVendorId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Label lablelProductName;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Label labelManufacturerName;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label labelProductType;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxVendor;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label labelDate;
    }
}