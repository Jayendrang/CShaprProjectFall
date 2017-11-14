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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxItemTotalPrice = new System.Windows.Forms.TextBox();
            this.labelItemTotalPrice = new System.Windows.Forms.Label();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.lablelProductName = new System.Windows.Forms.Label();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.labelManufacturerName = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.labelProductType = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxDiscountId = new System.Windows.Forms.TextBox();
            this.textBoxBalanceAmount = new System.Windows.Forms.TextBox();
            this.textBoxPricePerUnit = new System.Windows.Forms.TextBox();
            this.textBoxAdvanceAmount = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelDiscountId = new System.Windows.Forms.Label();
            this.labelAdvancePay = new System.Windows.Forms.Label();
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
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonSubmitOrder = new System.Windows.Forms.Button();
            this.groupBoxCart = new System.Windows.Forms.GroupBox();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.panelOrder.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.groupBoxVendor.SuspendLayout();
            this.groupBoxCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOrder
            // 
            this.panelOrder.AutoSize = true;
            this.panelOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOrder.Controls.Add(this.groupBoxOrderDetails);
            this.panelOrder.Controls.Add(this.groupBoxVendor);
            this.panelOrder.Controls.Add(this.labelFormTitle);
            this.panelOrder.Controls.Add(this.buttonAddToCart);
            this.panelOrder.Controls.Add(this.buttonCancelOrder);
            this.panelOrder.Controls.Add(this.buttonSubmitOrder);
            this.panelOrder.Controls.Add(this.groupBoxCart);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1114, 706);
            this.panelOrder.TabIndex = 0;
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.textBoxDescription);
            this.groupBoxOrderDetails.Controls.Add(this.labelDescription);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxItemTotalPrice);
            this.groupBoxOrderDetails.Controls.Add(this.labelItemTotalPrice);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxOrderDate);
            this.groupBoxOrderDetails.Controls.Add(this.labelDate);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxOrderId);
            this.groupBoxOrderDetails.Controls.Add(this.labelOrderID);
            this.groupBoxOrderDetails.Controls.Add(this.comboBoxProductName);
            this.groupBoxOrderDetails.Controls.Add(this.lablelProductName);
            this.groupBoxOrderDetails.Controls.Add(this.comboBoxManufacturer);
            this.groupBoxOrderDetails.Controls.Add(this.labelManufacturerName);
            this.groupBoxOrderDetails.Controls.Add(this.comboBoxProductType);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxProductId);
            this.groupBoxOrderDetails.Controls.Add(this.labelProductType);
            this.groupBoxOrderDetails.Controls.Add(this.labelProductId);
            this.groupBoxOrderDetails.Controls.Add(this.labelTotalPrice);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxDiscountId);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxBalanceAmount);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxPricePerUnit);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxAdvanceAmount);
            this.groupBoxOrderDetails.Controls.Add(this.textBoxCount);
            this.groupBoxOrderDetails.Controls.Add(this.labelDiscountId);
            this.groupBoxOrderDetails.Controls.Add(this.labelAdvancePay);
            this.groupBoxOrderDetails.Controls.Add(this.labelBalanceAmount);
            this.groupBoxOrderDetails.Controls.Add(this.label10);
            this.groupBoxOrderDetails.Controls.Add(this.labelCount);
            this.groupBoxOrderDetails.Controls.Add(this.labelPricePerUnit);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(66, 115);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(919, 341);
            this.groupBoxOrderDetails.TabIndex = 83;
            this.groupBoxOrderDetails.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(736, 261);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(174, 58);
            this.textBoxDescription.TabIndex = 88;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(517, 261);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 17);
            this.labelDescription.TabIndex = 87;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // textBoxItemTotalPrice
            // 
            this.textBoxItemTotalPrice.Location = new System.Drawing.Point(737, 66);
            this.textBoxItemTotalPrice.Name = "textBoxItemTotalPrice";
            this.textBoxItemTotalPrice.Size = new System.Drawing.Size(113, 22);
            this.textBoxItemTotalPrice.TabIndex = 86;
            // 
            // labelItemTotalPrice
            // 
            this.labelItemTotalPrice.AutoSize = true;
            this.labelItemTotalPrice.Location = new System.Drawing.Point(517, 71);
            this.labelItemTotalPrice.Name = "labelItemTotalPrice";
            this.labelItemTotalPrice.Size = new System.Drawing.Size(134, 17);
            this.labelItemTotalPrice.TabIndex = 85;
            this.labelItemTotalPrice.Text = "ITEM TOTAL PRICE";
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
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
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
            this.comboBoxManufacturer.SelectedIndexChanged += new System.EventHandler(this.comboBoxManufacturer_SelectedIndexChanged);
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
            this.comboBoxProductType.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductType_SelectedIndexChanged);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(212, 233);
            this.textBoxProductId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.ReadOnly = true;
            this.textBoxProductId.Size = new System.Drawing.Size(104, 22);
            this.textBoxProductId.TabIndex = 75;
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
            this.textBoxTotalPrice.Location = new System.Drawing.Point(737, 189);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(113, 22);
            this.textBoxTotalPrice.TabIndex = 62;
            // 
            // textBoxDiscountId
            // 
            this.textBoxDiscountId.Location = new System.Drawing.Point(737, 144);
            this.textBoxDiscountId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountId.Name = "textBoxDiscountId";
            this.textBoxDiscountId.ReadOnly = true;
            this.textBoxDiscountId.Size = new System.Drawing.Size(113, 22);
            this.textBoxDiscountId.TabIndex = 51;
            // 
            // textBoxBalanceAmount
            // 
            this.textBoxBalanceAmount.Location = new System.Drawing.Point(737, 226);
            this.textBoxBalanceAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBalanceAmount.Name = "textBoxBalanceAmount";
            this.textBoxBalanceAmount.Size = new System.Drawing.Size(113, 22);
            this.textBoxBalanceAmount.TabIndex = 50;
            // 
            // textBoxPricePerUnit
            // 
            this.textBoxPricePerUnit.Location = new System.Drawing.Point(212, 263);
            this.textBoxPricePerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.ReadOnly = true;
            this.textBoxPricePerUnit.Size = new System.Drawing.Size(104, 22);
            this.textBoxPricePerUnit.TabIndex = 49;
            // 
            // textBoxAdvanceAmount
            // 
            this.textBoxAdvanceAmount.Location = new System.Drawing.Point(737, 102);
            this.textBoxAdvanceAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdvanceAmount.Name = "textBoxAdvanceAmount";
            this.textBoxAdvanceAmount.Size = new System.Drawing.Size(113, 22);
            this.textBoxAdvanceAmount.TabIndex = 48;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(736, 30);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(113, 22);
            this.textBoxCount.TabIndex = 47;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // labelDiscountId
            // 
            this.labelDiscountId.AutoSize = true;
            this.labelDiscountId.Location = new System.Drawing.Point(517, 147);
            this.labelDiscountId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountId.Name = "labelDiscountId";
            this.labelDiscountId.Size = new System.Drawing.Size(83, 17);
            this.labelDiscountId.TabIndex = 42;
            this.labelDiscountId.Text = "DISCOUNT ";
            // 
            // labelAdvancePay
            // 
            this.labelAdvancePay.AutoSize = true;
            this.labelAdvancePay.Location = new System.Drawing.Point(517, 105);
            this.labelAdvancePay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdvancePay.Name = "labelAdvancePay";
            this.labelAdvancePay.Size = new System.Drawing.Size(206, 17);
            this.labelAdvancePay.TabIndex = 41;
            this.labelAdvancePay.Text = "MINIMUM ADVANCE PAYMENT";
            // 
            // labelBalanceAmount
            // 
            this.labelBalanceAmount.AutoSize = true;
            this.labelBalanceAmount.Location = new System.Drawing.Point(517, 229);
            this.labelBalanceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceAmount.Name = "labelBalanceAmount";
            this.labelBalanceAmount.Size = new System.Drawing.Size(135, 17);
            this.labelBalanceAmount.TabIndex = 40;
            this.labelBalanceAmount.Text = "BALANCE AMOUNT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "TOTAL PRICE";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(517, 33);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 17);
            this.labelCount.TabIndex = 36;
            this.labelCount.Text = "COUNT";
            // 
            // labelPricePerUnit
            // 
            this.labelPricePerUnit.AutoSize = true;
            this.labelPricePerUnit.Location = new System.Drawing.Point(48, 268);
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
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(640, 473);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(135, 28);
            this.buttonAddToCart.TabIndex = 56;
            this.buttonAddToCart.Text = "&ADD TO CART";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(486, 473);
            this.buttonCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(121, 28);
            this.buttonCancelOrder.TabIndex = 55;
            this.buttonCancelOrder.Text = "&CANCEL";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonSubmitOrder
            // 
            this.buttonSubmitOrder.Location = new System.Drawing.Point(316, 473);
            this.buttonSubmitOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitOrder.Name = "buttonSubmitOrder";
            this.buttonSubmitOrder.Size = new System.Drawing.Size(130, 28);
            this.buttonSubmitOrder.TabIndex = 54;
            this.buttonSubmitOrder.Text = "SUBMIT &ORDER";
            this.buttonSubmitOrder.UseVisualStyleBackColor = true;
            this.buttonSubmitOrder.Click += new System.EventHandler(this.buttonSubmitOrder_Click);
            // 
            // groupBoxCart
            // 
            this.groupBoxCart.Controls.Add(this.dataGridViewCart);
            this.groupBoxCart.Location = new System.Drawing.Point(97, 508);
            this.groupBoxCart.Name = "groupBoxCart";
            this.groupBoxCart.Size = new System.Drawing.Size(847, 162);
            this.groupBoxCart.TabIndex = 84;
            this.groupBoxCart.TabStop = false;
            this.groupBoxCart.Text = "CART";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCart.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowTemplate.Height = 24;
            this.dataGridViewCart.Size = new System.Drawing.Size(841, 141);
            this.dataGridViewCart.TabIndex = 0;
            // 
            // Orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1114, 706);
            this.Controls.Add(this.panelOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orders";
            this.Text = "PURCHASE ORDER ";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.groupBoxVendor.ResumeLayout(false);
            this.groupBoxVendor.PerformLayout();
            this.groupBoxCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonSubmitOrder;
        private System.Windows.Forms.TextBox textBoxDiscountId;
        private System.Windows.Forms.TextBox textBoxBalanceAmount;
        private System.Windows.Forms.TextBox textBoxPricePerUnit;
        private System.Windows.Forms.TextBox textBoxAdvanceAmount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxVendor;
        private System.Windows.Forms.Label labelDiscountId;
        private System.Windows.Forms.Label labelAdvancePay;
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
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label labelProductType;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxVendor;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.GroupBox groupBoxCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.TextBox textBoxItemTotalPrice;
        private System.Windows.Forms.Label labelItemTotalPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
    }
}