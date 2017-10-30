namespace ConsignmentCompanyProject
{
    partial class Manufacturer
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
            this.labelManufacturerId = new System.Windows.Forms.Label();
            this.textBoxManufactureId = new System.Windows.Forms.TextBox();
            this.labelManufacturerName = new System.Windows.Forms.Label();
            this.textBoxManufacturerName = new System.Windows.Forms.TextBox();
            this.groupBoxManufacturerInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoveManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNewManufacturer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelManufacturerDescription = new System.Windows.Forms.Label();
            this.buttonAddManufacturer = new System.Windows.Forms.Button();
            this.groupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonProductSearch = new System.Windows.Forms.RadioButton();
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductPerUnit = new System.Windows.Forms.TextBox();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.labelPricePerUnit = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelProductType = new System.Windows.Forms.Label();
            this.groupBoxProductsLIst = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxManufacturerInfo.SuspendLayout();
            this.groupBoxProductInfo.SuspendLayout();
            this.groupBoxProductsLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT";
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
            this.groupBoxManufacturerInfo.Controls.Add(this.radioButtonSearchManufacturer);
            this.groupBoxManufacturerInfo.Controls.Add(this.radioButtonRemoveManufacturer);
            this.groupBoxManufacturerInfo.Controls.Add(this.radioButtonAddNewManufacturer);
            this.groupBoxManufacturerInfo.Controls.Add(this.textBox1);
            this.groupBoxManufacturerInfo.Controls.Add(this.labelManufacturerDescription);
            this.groupBoxManufacturerInfo.Controls.Add(this.buttonAddManufacturer);
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
            // radioButtonSearchManufacturer
            // 
            this.radioButtonSearchManufacturer.AutoSize = true;
            this.radioButtonSearchManufacturer.Location = new System.Drawing.Point(519, 33);
            this.radioButtonSearchManufacturer.Name = "radioButtonSearchManufacturer";
            this.radioButtonSearchManufacturer.Size = new System.Drawing.Size(203, 21);
            this.radioButtonSearchManufacturer.TabIndex = 10;
            this.radioButtonSearchManufacturer.TabStop = true;
            this.radioButtonSearchManufacturer.Text = "SEARCH MANUFACTURER";
            this.radioButtonSearchManufacturer.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemoveManufacturer
            // 
            this.radioButtonRemoveManufacturer.AutoSize = true;
            this.radioButtonRemoveManufacturer.Location = new System.Drawing.Point(272, 33);
            this.radioButtonRemoveManufacturer.Name = "radioButtonRemoveManufacturer";
            this.radioButtonRemoveManufacturer.Size = new System.Drawing.Size(206, 21);
            this.radioButtonRemoveManufacturer.TabIndex = 9;
            this.radioButtonRemoveManufacturer.TabStop = true;
            this.radioButtonRemoveManufacturer.Text = "REMOVE MANUFACTURER";
            this.radioButtonRemoveManufacturer.UseVisualStyleBackColor = true;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 45);
            this.textBox1.TabIndex = 7;
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
            // buttonAddManufacturer
            // 
            this.buttonAddManufacturer.Location = new System.Drawing.Point(681, 155);
            this.buttonAddManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddManufacturer.Name = "buttonAddManufacturer";
            this.buttonAddManufacturer.Size = new System.Drawing.Size(168, 28);
            this.buttonAddManufacturer.TabIndex = 5;
            this.buttonAddManufacturer.Text = "ADD &MANUFACTURER";
            this.buttonAddManufacturer.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductInfo
            // 
            this.groupBoxProductInfo.Controls.Add(this.radioButtonProductSearch);
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
            this.groupBoxProductInfo.Controls.Add(this.textBoxDescription);
            this.groupBoxProductInfo.Controls.Add(this.textBoxProductPerUnit);
            this.groupBoxProductInfo.Controls.Add(this.labelProductDescription);
            this.groupBoxProductInfo.Controls.Add(this.labelPricePerUnit);
            this.groupBoxProductInfo.Controls.Add(this.labelProductCount);
            this.groupBoxProductInfo.Controls.Add(this.labelProductType);
            this.groupBoxProductInfo.Location = new System.Drawing.Point(124, 271);
            this.groupBoxProductInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProductInfo.Name = "groupBoxProductInfo";
            this.groupBoxProductInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProductInfo.Size = new System.Drawing.Size(860, 280);
            this.groupBoxProductInfo.TabIndex = 6;
            this.groupBoxProductInfo.TabStop = false;
            this.groupBoxProductInfo.Text = "NEW PRODUCT INFO";
            // 
            // radioButtonProductSearch
            // 
            this.radioButtonProductSearch.AutoSize = true;
            this.radioButtonProductSearch.Location = new System.Drawing.Point(729, 50);
            this.radioButtonProductSearch.Name = "radioButtonProductSearch";
            this.radioButtonProductSearch.Size = new System.Drawing.Size(85, 21);
            this.radioButtonProductSearch.TabIndex = 26;
            this.radioButtonProductSearch.TabStop = true;
            this.radioButtonProductSearch.Text = "SEARCH";
            this.radioButtonProductSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(253, 185);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(131, 22);
            this.textBoxProductName.TabIndex = 25;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(15, 190);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(119, 17);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "PRODUCT NAME";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(253, 148);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(132, 24);
            this.comboBoxProductType.TabIndex = 23;
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
            // 
            // radioButtonUpdateProductUnit
            // 
            this.radioButtonUpdateProductUnit.AutoSize = true;
            this.radioButtonUpdateProductUnit.Location = new System.Drawing.Point(274, 50);
            this.radioButtonUpdateProductUnit.Name = "radioButtonUpdateProductUnit";
            this.radioButtonUpdateProductUnit.Size = new System.Drawing.Size(202, 21);
            this.radioButtonUpdateProductUnit.TabIndex = 21;
            this.radioButtonUpdateProductUnit.TabStop = true;
            this.radioButtonUpdateProductUnit.Text = "UPDATE PRODCUT UNITS";
            this.radioButtonUpdateProductUnit.UseVisualStyleBackColor = true;
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
            // 
            // comboBoxManufacturerName
            // 
            this.comboBoxManufacturerName.FormattingEnabled = true;
            this.comboBoxManufacturerName.Location = new System.Drawing.Point(252, 110);
            this.comboBoxManufacturerName.Name = "comboBoxManufacturerName";
            this.comboBoxManufacturerName.Size = new System.Drawing.Size(132, 24);
            this.comboBoxManufacturerName.TabIndex = 19;
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
            this.buttonAddProducts.Location = new System.Drawing.Point(682, 223);
            this.buttonAddProducts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(161, 28);
            this.buttonAddProducts.TabIndex = 16;
            this.buttonAddProducts.Text = "ADD &PRODUCT";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            // 
            // textBoxProductCurrentCount
            // 
            this.textBoxProductCurrentCount.Location = new System.Drawing.Point(252, 229);
            this.textBoxProductCurrentCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductCurrentCount.Name = "textBoxProductCurrentCount";
            this.textBoxProductCurrentCount.Size = new System.Drawing.Size(132, 22);
            this.textBoxProductCurrentCount.TabIndex = 15;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(682, 157);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(161, 50);
            this.textBoxDescription.TabIndex = 14;
            // 
            // textBoxProductPerUnit
            // 
            this.textBoxProductPerUnit.Location = new System.Drawing.Point(682, 112);
            this.textBoxProductPerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPerUnit.Name = "textBoxProductPerUnit";
            this.textBoxProductPerUnit.Size = new System.Drawing.Size(132, 22);
            this.textBoxProductPerUnit.TabIndex = 12;
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Location = new System.Drawing.Point(469, 157);
            this.labelProductDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(169, 17);
            this.labelProductDescription.TabIndex = 8;
            this.labelProductDescription.Text = "PRODUCT DESCRIPTON";
            // 
            // labelPricePerUnit
            // 
            this.labelPricePerUnit.AutoSize = true;
            this.labelPricePerUnit.Location = new System.Drawing.Point(469, 112);
            this.labelPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPricePerUnit.Name = "labelPricePerUnit";
            this.labelPricePerUnit.Size = new System.Drawing.Size(116, 17);
            this.labelPricePerUnit.TabIndex = 7;
            this.labelPricePerUnit.Text = "PRICE PER UNIT";
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Location = new System.Drawing.Point(15, 229);
            this.labelProductCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(129, 17);
            this.labelProductCount.TabIndex = 6;
            this.labelProductCount.Text = "PRODUCT COUNT";
            // 
            // labelProductType
            // 
            this.labelProductType.AutoSize = true;
            this.labelProductType.Location = new System.Drawing.Point(15, 148);
            this.labelProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductType.Name = "labelProductType";
            this.labelProductType.Size = new System.Drawing.Size(116, 17);
            this.labelProductType.TabIndex = 4;
            this.labelProductType.Text = "PRODUCT TYPE";
            // 
            // groupBoxProductsLIst
            // 
            this.groupBoxProductsLIst.Controls.Add(this.dataGridView1);
            this.groupBoxProductsLIst.Location = new System.Drawing.Point(124, 570);
            this.groupBoxProductsLIst.Name = "groupBoxProductsLIst";
            this.groupBoxProductsLIst.Size = new System.Drawing.Size(852, 164);
            this.groupBoxProductsLIst.TabIndex = 7;
            this.groupBoxProductsLIst.TabStop = false;
            this.groupBoxProductsLIst.Text = "PRODUCT LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 746);
            this.Controls.Add(this.groupBoxProductsLIst);
            this.Controls.Add(this.groupBoxProductInfo);
            this.Controls.Add(this.groupBoxManufacturerInfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manufacturer";
            this.Text = "INVENTORY MANAGEMENT";
            this.Load += new System.EventHandler(this.Manufacturer_Load);
            this.groupBoxManufacturerInfo.ResumeLayout(false);
            this.groupBoxManufacturerInfo.PerformLayout();
            this.groupBoxProductInfo.ResumeLayout(false);
            this.groupBoxProductInfo.PerformLayout();
            this.groupBoxProductsLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelManufacturerId;
        private System.Windows.Forms.TextBox textBoxManufactureId;
        private System.Windows.Forms.Label labelManufacturerName;
        private System.Windows.Forms.TextBox textBoxManufacturerName;
        private System.Windows.Forms.GroupBox groupBoxManufacturerInfo;
        private System.Windows.Forms.Button buttonAddManufacturer;
        private System.Windows.Forms.GroupBox groupBoxProductInfo;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Label labelPricePerUnit;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.Label labelProductType;
        private System.Windows.Forms.TextBox textBoxProductPerUnit;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.TextBox textBoxProductCurrentCount;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.RadioButton radioButtonRemoveManufacturer;
        private System.Windows.Forms.RadioButton radioButtonAddNewManufacturer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelManufacturerDescription;
        private System.Windows.Forms.RadioButton radioButtonRemoveProduct;
        private System.Windows.Forms.RadioButton radioButtonUpdateProductUnit;
        private System.Windows.Forms.RadioButton radioButtonAddNewProduct;
        private System.Windows.Forms.ComboBox comboBoxManufacturerName;
        private System.Windows.Forms.Label labelProductManufacturereName;
        private System.Windows.Forms.GroupBox groupBoxProductsLIst;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.RadioButton radioButtonSearchManufacturer;
        private System.Windows.Forms.RadioButton radioButtonProductSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}