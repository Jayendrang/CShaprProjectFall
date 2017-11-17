namespace ConsignmentCompanyProject
{
    partial class InventoryManagement
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelManufacturerId = new System.Windows.Forms.Label();
            this.textBoxManufactureId = new System.Windows.Forms.TextBox();
            this.labelManufacturerName = new System.Windows.Forms.Label();
            this.textBoxManufacturerName = new System.Windows.Forms.TextBox();
            this.groupBoxManufacturerInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.radioButtonRemoveManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNewManufacturer = new System.Windows.Forms.RadioButton();
            this.textBoxManfacturerDescriptions = new System.Windows.Forms.TextBox();
            this.labelManufacturerDescription = new System.Windows.Forms.Label();
            this.buttonDynamicAction = new System.Windows.Forms.Button();
            this.groupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxNewProductType = new System.Windows.Forms.CheckBox();
            this.labelMinimumCount = new System.Windows.Forms.Label();
            this.textBoxMinimumCount = new System.Windows.Forms.TextBox();
            this.textBoxNewProductType = new System.Windows.Forms.TextBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.radioButtonRemoveProduct = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateProductUnit = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNewProduct = new System.Windows.Forms.RadioButton();
            this.comboBoxManufacturerName = new System.Windows.Forms.ComboBox();
            this.labelProductManufacturereName = new System.Windows.Forms.Label();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.textBoxProductCurrentCount = new System.Windows.Forms.TextBox();
            this.textBoxProductPerUnit = new System.Windows.Forms.TextBox();
            this.labelPricePerUnit = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelProductType = new System.Windows.Forms.Label();
            this.groupBoxProductsLIst = new System.Windows.Forms.GroupBox();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.groupBoxManufacturersList = new System.Windows.Forms.GroupBox();
            this.radioButtonInactiveManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveManufacturers = new System.Windows.Forms.RadioButton();
            this.dataGridViewManufacturers = new System.Windows.Forms.DataGridView();
            this.groupBoxManufacturerInfo.SuspendLayout();
            this.groupBoxProductInfo.SuspendLayout();
            this.groupBoxProductsLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.groupBoxManufacturersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(423, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(248, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "INVENTORY MANAGEMENT";
            // 
            // labelManufacturerId
            // 
            this.labelManufacturerId.AutoSize = true;
            this.labelManufacturerId.Location = new System.Drawing.Point(22, 73);
            this.labelManufacturerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacturerId.Name = "labelManufacturerId";
            this.labelManufacturerId.Size = new System.Drawing.Size(139, 17);
            this.labelManufacturerId.TabIndex = 1;
            this.labelManufacturerId.Text = "MANUFACTURER ID";
            // 
            // textBoxManufactureId
            // 
            this.textBoxManufactureId.Location = new System.Drawing.Point(272, 73);
            this.textBoxManufactureId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManufactureId.Name = "textBoxManufactureId";
            this.textBoxManufactureId.Size = new System.Drawing.Size(132, 22);
            this.textBoxManufactureId.TabIndex = 2;
            // 
            // labelManufacturerName
            // 
            this.labelManufacturerName.AutoSize = true;
            this.labelManufacturerName.Location = new System.Drawing.Point(22, 117);
            this.labelManufacturerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacturerName.Name = "labelManufacturerName";
            this.labelManufacturerName.Size = new System.Drawing.Size(165, 17);
            this.labelManufacturerName.TabIndex = 3;
            this.labelManufacturerName.Text = "MANUFACTURER NAME";
            // 
            // textBoxManufacturerName
            // 
            this.textBoxManufacturerName.Location = new System.Drawing.Point(272, 117);
            this.textBoxManufacturerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManufacturerName.Name = "textBoxManufacturerName";
            this.textBoxManufacturerName.Size = new System.Drawing.Size(132, 22);
            this.textBoxManufacturerName.TabIndex = 4;
            // 
            // groupBoxManufacturerInfo
            // 
            this.groupBoxManufacturerInfo.Controls.Add(this.button1);
            this.groupBoxManufacturerInfo.Controls.Add(this.comboBoxStatus);
            this.groupBoxManufacturerInfo.Controls.Add(this.textBoxStatus);
            this.groupBoxManufacturerInfo.Controls.Add(this.labelStatus);
            this.groupBoxManufacturerInfo.Controls.Add(this.radioButtonRemoveManufacturer);
            this.groupBoxManufacturerInfo.Controls.Add(this.radioButtonAddNewManufacturer);
            this.groupBoxManufacturerInfo.Controls.Add(this.textBoxManfacturerDescriptions);
            this.groupBoxManufacturerInfo.Controls.Add(this.labelManufacturerDescription);
            this.groupBoxManufacturerInfo.Controls.Add(this.buttonDynamicAction);
            this.groupBoxManufacturerInfo.Controls.Add(this.labelManufacturerId);
            this.groupBoxManufacturerInfo.Controls.Add(this.textBoxManufacturerName);
            this.groupBoxManufacturerInfo.Controls.Add(this.labelManufacturerName);
            this.groupBoxManufacturerInfo.Controls.Add(this.textBoxManufactureId);
            this.groupBoxManufacturerInfo.Location = new System.Drawing.Point(124, 56);
            this.groupBoxManufacturerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxManufacturerInfo.Name = "groupBoxManufacturerInfo";
            this.groupBoxManufacturerInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxManufacturerInfo.Size = new System.Drawing.Size(860, 207);
            this.groupBoxManufacturerInfo.TabIndex = 5;
            this.groupBoxManufacturerInfo.TabStop = false;
            this.groupBoxManufacturerInfo.Text = "NEW MANUFACTURER INFO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "&CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.comboBoxStatus.Location = new System.Drawing.Point(630, 71);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(105, 24);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(630, 73);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxStatus.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(516, 76);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 17);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "STATUS";
            // 
            // radioButtonRemoveManufacturer
            // 
            this.radioButtonRemoveManufacturer.AutoSize = true;
            this.radioButtonRemoveManufacturer.Location = new System.Drawing.Point(272, 33);
            this.radioButtonRemoveManufacturer.Name = "radioButtonRemoveManufacturer";
            this.radioButtonRemoveManufacturer.Size = new System.Drawing.Size(258, 21);
            this.radioButtonRemoveManufacturer.TabIndex = 9;
            this.radioButtonRemoveManufacturer.TabStop = true;
            this.radioButtonRemoveManufacturer.Text = "MODIFY MANUFACTURER STATUS";
            this.radioButtonRemoveManufacturer.UseVisualStyleBackColor = true;
            this.radioButtonRemoveManufacturer.CheckedChanged += new System.EventHandler(this.radioButtonRemoveManufacturer_CheckedChanged);
            // 
            // radioButtonAddNewManufacturer
            // 
            this.radioButtonAddNewManufacturer.AutoSize = true;
            this.radioButtonAddNewManufacturer.Location = new System.Drawing.Point(25, 33);
            this.radioButtonAddNewManufacturer.Name = "radioButtonAddNewManufacturer";
            this.radioButtonAddNewManufacturer.Size = new System.Drawing.Size(212, 21);
            this.radioButtonAddNewManufacturer.TabIndex = 8;
            this.radioButtonAddNewManufacturer.TabStop = true;
            this.radioButtonAddNewManufacturer.Text = "ADD NEW MANUFACTURER";
            this.radioButtonAddNewManufacturer.UseVisualStyleBackColor = true;
            this.radioButtonAddNewManufacturer.CheckedChanged += new System.EventHandler(this.radioButtonAddNewManufacturer_CheckedChanged);
            // 
            // textBoxManfacturerDescriptions
            // 
            this.textBoxManfacturerDescriptions.Location = new System.Drawing.Point(272, 155);
            this.textBoxManfacturerDescriptions.Multiline = true;
            this.textBoxManfacturerDescriptions.Name = "textBoxManfacturerDescriptions";
            this.textBoxManfacturerDescriptions.Size = new System.Drawing.Size(250, 45);
            this.textBoxManfacturerDescriptions.TabIndex = 7;
            // 
            // labelManufacturerDescription
            // 
            this.labelManufacturerDescription.AutoSize = true;
            this.labelManufacturerDescription.Location = new System.Drawing.Point(22, 155);
            this.labelManufacturerDescription.Name = "labelManufacturerDescription";
            this.labelManufacturerDescription.Size = new System.Drawing.Size(221, 17);
            this.labelManufacturerDescription.TabIndex = 6;
            this.labelManufacturerDescription.Text = "MANUFACTURER DESCRIPITION";
            // 
            // buttonDynamicAction
            // 
            this.buttonDynamicAction.Location = new System.Drawing.Point(630, 155);
            this.buttonDynamicAction.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDynamicAction.Name = "buttonDynamicAction";
            this.buttonDynamicAction.Size = new System.Drawing.Size(168, 28);
            this.buttonDynamicAction.TabIndex = 5;
            this.buttonDynamicAction.Text = "ADD &MANUFACTURER";
            this.buttonDynamicAction.UseVisualStyleBackColor = true;
            this.buttonDynamicAction.Click += new System.EventHandler(this.buttonAddManufacturer_Click);
            // 
            // groupBoxProductInfo
            // 
            this.groupBoxProductInfo.Controls.Add(this.checkBoxNewProductType);
            this.groupBoxProductInfo.Controls.Add(this.labelMinimumCount);
            this.groupBoxProductInfo.Controls.Add(this.textBoxMinimumCount);
            this.groupBoxProductInfo.Controls.Add(this.comboBoxProductName);
            this.groupBoxProductInfo.Controls.Add(this.textBoxProductId);
            this.groupBoxProductInfo.Controls.Add(this.labelProductId);
            this.groupBoxProductInfo.Controls.Add(this.textBoxProductName);
            this.groupBoxProductInfo.Controls.Add(this.labelProductName);
            this.groupBoxProductInfo.Controls.Add(this.comboBoxProductType);
            this.groupBoxProductInfo.Controls.Add(this.radioButtonRemoveProduct);
            this.groupBoxProductInfo.Controls.Add(this.radioButtonUpdateProductUnit);
            this.groupBoxProductInfo.Controls.Add(this.radioButtonAddNewProduct);
            this.groupBoxProductInfo.Controls.Add(this.comboBoxManufacturerName);
            this.groupBoxProductInfo.Controls.Add(this.labelProductManufacturereName);
            this.groupBoxProductInfo.Controls.Add(this.buttonAddProducts);
            this.groupBoxProductInfo.Controls.Add(this.textBoxProductCurrentCount);
            this.groupBoxProductInfo.Controls.Add(this.textBoxProductPerUnit);
            this.groupBoxProductInfo.Controls.Add(this.labelPricePerUnit);
            this.groupBoxProductInfo.Controls.Add(this.labelProductCount);
            this.groupBoxProductInfo.Controls.Add(this.labelProductType);
            this.groupBoxProductInfo.Controls.Add(this.textBoxNewProductType);
            this.groupBoxProductInfo.Location = new System.Drawing.Point(124, 462);
            this.groupBoxProductInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProductInfo.Name = "groupBoxProductInfo";
            this.groupBoxProductInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProductInfo.Size = new System.Drawing.Size(860, 295);
            this.groupBoxProductInfo.TabIndex = 6;
            this.groupBoxProductInfo.TabStop = false;
            this.groupBoxProductInfo.Text = "NEW PRODUCT INFO";
            // 
            // checkBoxNewProductType
            // 
            this.checkBoxNewProductType.AutoSize = true;
            this.checkBoxNewProductType.Location = new System.Drawing.Point(252, 147);
            this.checkBoxNewProductType.Name = "checkBoxNewProductType";
            this.checkBoxNewProductType.Size = new System.Drawing.Size(174, 21);
            this.checkBoxNewProductType.TabIndex = 0;
            this.checkBoxNewProductType.Text = "NEW PRODUCT TYPE";
            this.checkBoxNewProductType.UseVisualStyleBackColor = true;
            this.checkBoxNewProductType.CheckedChanged += new System.EventHandler(this.checkBoxNewProductType_CheckedChanged);
            // 
            // labelMinimumCount
            // 
            this.labelMinimumCount.AutoSize = true;
            this.labelMinimumCount.Location = new System.Drawing.Point(476, 194);
            this.labelMinimumCount.Name = "labelMinimumCount";
            this.labelMinimumCount.Size = new System.Drawing.Size(120, 17);
            this.labelMinimumCount.TabIndex = 35;
            this.labelMinimumCount.Text = "MINIMUM COUNT";
            // 
            // textBoxMinimumCount
            // 
            this.textBoxMinimumCount.Location = new System.Drawing.Point(673, 194);
            this.textBoxMinimumCount.Name = "textBoxMinimumCount";
            this.textBoxMinimumCount.Size = new System.Drawing.Size(116, 22);
            this.textBoxMinimumCount.TabIndex = 34;
            // 
            // textBoxNewProductType
            // 
            this.textBoxNewProductType.Location = new System.Drawing.Point(253, 175);
            this.textBoxNewProductType.Name = "textBoxNewProductType";
            this.textBoxNewProductType.Size = new System.Drawing.Size(133, 22);
            this.textBoxNewProductType.TabIndex = 32;
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(253, 222);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(133, 24);
            this.comboBoxProductName.TabIndex = 29;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(673, 108);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductId.TabIndex = 28;
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(474, 113);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(93, 17);
            this.labelProductId.TabIndex = 27;
            this.labelProductId.Text = "PRODUCT ID";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(253, 222);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(133, 22);
            this.textBoxProductName.TabIndex = 25;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(16, 222);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(119, 17);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "PRODUCT NAME";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(253, 173);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(134, 24);
            this.comboBoxProductType.TabIndex = 23;
            this.comboBoxProductType.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductType_SelectedIndexChanged);
            // 
            // radioButtonRemoveProduct
            // 
            this.radioButtonRemoveProduct.AutoSize = true;
            this.radioButtonRemoveProduct.Location = new System.Drawing.Point(532, 50);
            this.radioButtonRemoveProduct.Name = "radioButtonRemoveProduct";
            this.radioButtonRemoveProduct.Size = new System.Drawing.Size(160, 21);
            this.radioButtonRemoveProduct.TabIndex = 22;
            this.radioButtonRemoveProduct.TabStop = true;
            this.radioButtonRemoveProduct.Text = "REMOVE PRODUCT";
            this.radioButtonRemoveProduct.UseVisualStyleBackColor = true;
            this.radioButtonRemoveProduct.CheckedChanged += new System.EventHandler(this.radioButtonRemoveProduct_CheckedChanged);
            // 
            // radioButtonUpdateProductUnit
            // 
            this.radioButtonUpdateProductUnit.AutoSize = true;
            this.radioButtonUpdateProductUnit.Location = new System.Drawing.Point(241, 50);
            this.radioButtonUpdateProductUnit.Name = "radioButtonUpdateProductUnit";
            this.radioButtonUpdateProductUnit.Size = new System.Drawing.Size(259, 21);
            this.radioButtonUpdateProductUnit.TabIndex = 21;
            this.radioButtonUpdateProductUnit.TabStop = true;
            this.radioButtonUpdateProductUnit.Text = "UPDATE PRODUCT UNITS && PRICE";
            this.radioButtonUpdateProductUnit.UseVisualStyleBackColor = true;
            this.radioButtonUpdateProductUnit.CheckedChanged += new System.EventHandler(this.radioButtonUpdateProductUnit_CheckedChanged);
            // 
            // radioButtonAddNewProduct
            // 
            this.radioButtonAddNewProduct.AutoSize = true;
            this.radioButtonAddNewProduct.Location = new System.Drawing.Point(27, 50);
            this.radioButtonAddNewProduct.Name = "radioButtonAddNewProduct";
            this.radioButtonAddNewProduct.Size = new System.Drawing.Size(166, 21);
            this.radioButtonAddNewProduct.TabIndex = 20;
            this.radioButtonAddNewProduct.TabStop = true;
            this.radioButtonAddNewProduct.Text = "ADD NEW PRODUCT";
            this.radioButtonAddNewProduct.UseVisualStyleBackColor = true;
            this.radioButtonAddNewProduct.CheckedChanged += new System.EventHandler(this.radioButtonAddNewProduct_CheckedChanged);
            // 
            // comboBoxManufacturerName
            // 
            this.comboBoxManufacturerName.FormattingEnabled = true;
            this.comboBoxManufacturerName.Location = new System.Drawing.Point(252, 110);
            this.comboBoxManufacturerName.Name = "comboBoxManufacturerName";
            this.comboBoxManufacturerName.Size = new System.Drawing.Size(132, 24);
            this.comboBoxManufacturerName.TabIndex = 19;
            this.comboBoxManufacturerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxManufacturerName_SelectedIndexChanged);
            // 
            // labelProductManufacturereName
            // 
            this.labelProductManufacturereName.AutoSize = true;
            this.labelProductManufacturereName.Location = new System.Drawing.Point(15, 110);
            this.labelProductManufacturereName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductManufacturereName.Name = "labelProductManufacturereName";
            this.labelProductManufacturereName.Size = new System.Drawing.Size(165, 17);
            this.labelProductManufacturereName.TabIndex = 18;
            this.labelProductManufacturereName.Text = "MANUFACTURER NAME";
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Location = new System.Drawing.Point(477, 253);
            this.buttonAddProducts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(161, 28);
            this.buttonAddProducts.TabIndex = 16;
            this.buttonAddProducts.Text = "ADD &PRODUCT";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.buttonAddProducts_Click);
            // 
            // textBoxProductCurrentCount
            // 
            this.textBoxProductCurrentCount.Location = new System.Drawing.Point(253, 256);
            this.textBoxProductCurrentCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductCurrentCount.Name = "textBoxProductCurrentCount";
            this.textBoxProductCurrentCount.Size = new System.Drawing.Size(133, 22);
            this.textBoxProductCurrentCount.TabIndex = 15;
            // 
            // textBoxProductPerUnit
            // 
            this.textBoxProductPerUnit.Location = new System.Drawing.Point(673, 151);
            this.textBoxProductPerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPerUnit.Name = "textBoxProductPerUnit";
            this.textBoxProductPerUnit.Size = new System.Drawing.Size(116, 22);
            this.textBoxProductPerUnit.TabIndex = 12;
            // 
            // labelPricePerUnit
            // 
            this.labelPricePerUnit.AutoSize = true;
            this.labelPricePerUnit.Location = new System.Drawing.Point(474, 151);
            this.labelPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPricePerUnit.Name = "labelPricePerUnit";
            this.labelPricePerUnit.Size = new System.Drawing.Size(116, 17);
            this.labelPricePerUnit.TabIndex = 7;
            this.labelPricePerUnit.Text = "PRICE PER UNIT";
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Location = new System.Drawing.Point(16, 261);
            this.labelProductCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(129, 17);
            this.labelProductCount.TabIndex = 6;
            this.labelProductCount.Text = "PRODUCT COUNT";
            // 
            // labelProductType
            // 
            this.labelProductType.AutoSize = true;
            this.labelProductType.Location = new System.Drawing.Point(14, 178);
            this.labelProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductType.Name = "labelProductType";
            this.labelProductType.Size = new System.Drawing.Size(116, 17);
            this.labelProductType.TabIndex = 4;
            this.labelProductType.Text = "PRODUCT TYPE";
            // 
            // groupBoxProductsLIst
            // 
            this.groupBoxProductsLIst.Controls.Add(this.dataGridViewProductList);
            this.groupBoxProductsLIst.Location = new System.Drawing.Point(124, 764);
            this.groupBoxProductsLIst.Name = "groupBoxProductsLIst";
            this.groupBoxProductsLIst.Size = new System.Drawing.Size(860, 243);
            this.groupBoxProductsLIst.TabIndex = 7;
            this.groupBoxProductsLIst.TabStop = false;
            this.groupBoxProductsLIst.Text = "PRODUCT LIST";
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductList.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.RowTemplate.Height = 24;
            this.dataGridViewProductList.Size = new System.Drawing.Size(854, 222);
            this.dataGridViewProductList.TabIndex = 0;
            // 
            // groupBoxManufacturersList
            // 
            this.groupBoxManufacturersList.Controls.Add(this.radioButtonInactiveManufacturer);
            this.groupBoxManufacturersList.Controls.Add(this.radioButtonActiveManufacturers);
            this.groupBoxManufacturersList.Controls.Add(this.dataGridViewManufacturers);
            this.groupBoxManufacturersList.Location = new System.Drawing.Point(124, 280);
            this.groupBoxManufacturersList.Name = "groupBoxManufacturersList";
            this.groupBoxManufacturersList.Size = new System.Drawing.Size(860, 174);
            this.groupBoxManufacturersList.TabIndex = 8;
            this.groupBoxManufacturersList.TabStop = false;
            this.groupBoxManufacturersList.Text = "MANUFACTURER LIST";
            // 
            // radioButtonInactiveManufacturer
            // 
            this.radioButtonInactiveManufacturer.AutoSize = true;
            this.radioButtonInactiveManufacturer.Location = new System.Drawing.Point(658, 55);
            this.radioButtonInactiveManufacturer.Name = "radioButtonInactiveManufacturer";
            this.radioButtonInactiveManufacturer.Size = new System.Drawing.Size(90, 21);
            this.radioButtonInactiveManufacturer.TabIndex = 2;
            this.radioButtonInactiveManufacturer.TabStop = true;
            this.radioButtonInactiveManufacturer.Text = "INACTIVE";
            this.radioButtonInactiveManufacturer.UseVisualStyleBackColor = true;
            this.radioButtonInactiveManufacturer.CheckedChanged += new System.EventHandler(this.radioButtonInactiveManufacturer_CheckedChanged);
            // 
            // radioButtonActiveManufacturers
            // 
            this.radioButtonActiveManufacturers.AutoSize = true;
            this.radioButtonActiveManufacturers.Location = new System.Drawing.Point(658, 18);
            this.radioButtonActiveManufacturers.Name = "radioButtonActiveManufacturers";
            this.radioButtonActiveManufacturers.Size = new System.Drawing.Size(77, 21);
            this.radioButtonActiveManufacturers.TabIndex = 1;
            this.radioButtonActiveManufacturers.TabStop = true;
            this.radioButtonActiveManufacturers.Text = "ACTIVE";
            this.radioButtonActiveManufacturers.UseVisualStyleBackColor = true;
            this.radioButtonActiveManufacturers.CheckedChanged += new System.EventHandler(this.radioButtonActiveManufacturers_CheckedChanged);
            // 
            // dataGridViewManufacturers
            // 
            this.dataGridViewManufacturers.AllowUserToAddRows = false;
            this.dataGridViewManufacturers.AllowUserToDeleteRows = false;
            this.dataGridViewManufacturers.AllowUserToOrderColumns = true;
            this.dataGridViewManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturers.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewManufacturers.Name = "dataGridViewManufacturers";
            this.dataGridViewManufacturers.ReadOnly = true;
            this.dataGridViewManufacturers.RowTemplate.Height = 24;
            this.dataGridViewManufacturers.Size = new System.Drawing.Size(602, 153);
            this.dataGridViewManufacturers.TabIndex = 0;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 1037);
            this.Controls.Add(this.groupBoxManufacturersList);
            this.Controls.Add(this.groupBoxProductsLIst);
            this.Controls.Add(this.groupBoxProductInfo);
            this.Controls.Add(this.groupBoxManufacturerInfo);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryManagement";
            this.Text = "INVENTORY MANAGEMENT";
            this.Load += new System.EventHandler(this.Manufacturer_Load);
            this.groupBoxManufacturerInfo.ResumeLayout(false);
            this.groupBoxManufacturerInfo.PerformLayout();
            this.groupBoxProductInfo.ResumeLayout(false);
            this.groupBoxProductInfo.PerformLayout();
            this.groupBoxProductsLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.groupBoxManufacturersList.ResumeLayout(false);
            this.groupBoxManufacturersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelManufacturerId;
        private System.Windows.Forms.TextBox textBoxManufactureId;
        private System.Windows.Forms.Label labelManufacturerName;
        private System.Windows.Forms.TextBox textBoxManufacturerName;
        private System.Windows.Forms.GroupBox groupBoxManufacturerInfo;
        private System.Windows.Forms.Button buttonDynamicAction;
        private System.Windows.Forms.GroupBox groupBoxProductInfo;
        private System.Windows.Forms.Label labelPricePerUnit;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.Label labelProductType;
        private System.Windows.Forms.TextBox textBoxProductPerUnit;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.TextBox textBoxProductCurrentCount;
        private System.Windows.Forms.RadioButton radioButtonRemoveManufacturer;
        private System.Windows.Forms.RadioButton radioButtonAddNewManufacturer;
        private System.Windows.Forms.TextBox textBoxManfacturerDescriptions;
        private System.Windows.Forms.Label labelManufacturerDescription;
        private System.Windows.Forms.RadioButton radioButtonRemoveProduct;
        private System.Windows.Forms.RadioButton radioButtonUpdateProductUnit;
        private System.Windows.Forms.RadioButton radioButtonAddNewProduct;
        private System.Windows.Forms.ComboBox comboBoxManufacturerName;
        private System.Windows.Forms.Label labelProductManufacturereName;
        private System.Windows.Forms.GroupBox groupBoxProductsLIst;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.GroupBox groupBoxManufacturersList;
        private System.Windows.Forms.DataGridView dataGridViewManufacturers;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.RadioButton radioButtonInactiveManufacturer;
        private System.Windows.Forms.RadioButton radioButtonActiveManufacturers;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxNewProductType;
        private System.Windows.Forms.CheckBox checkBoxNewProductType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMinimumCount;
        private System.Windows.Forms.TextBox textBoxMinimumCount;
    }
}