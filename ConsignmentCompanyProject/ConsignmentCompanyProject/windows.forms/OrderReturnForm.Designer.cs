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
            this.button2 = new System.Windows.Forms.Button();
            this.labelReturnOrderHeading = new System.Windows.Forms.Label();
            this.textBoxReturnReason = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.listBoxReturnProduct = new System.Windows.Forms.ListBox();
            this.textBoxVendor = new System.Windows.Forms.TextBox();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelReturnStatus = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.labelProductReturn = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.textBoxReturnTotal = new System.Windows.Forms.TextBox();
            this.textBoxReturnStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelReturnOrder.SuspendLayout();
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
            this.panelReturnOrder.Controls.Add(this.button2);
            this.panelReturnOrder.Controls.Add(this.labelReturnOrderHeading);
            this.panelReturnOrder.Controls.Add(this.textBoxReturnReason);
            this.panelReturnOrder.Controls.Add(this.textBoxCount);
            this.panelReturnOrder.Controls.Add(this.listBoxReturnProduct);
            this.panelReturnOrder.Controls.Add(this.textBoxVendor);
            this.panelReturnOrder.Controls.Add(this.textBoxOrderNumber);
            this.panelReturnOrder.Controls.Add(this.button1);
            this.panelReturnOrder.Controls.Add(this.labelReturnStatus);
            this.panelReturnOrder.Controls.Add(this.labelTotal);
            this.panelReturnOrder.Controls.Add(this.labelCount);
            this.panelReturnOrder.Controls.Add(this.labelReason);
            this.panelReturnOrder.Controls.Add(this.labelProductReturn);
            this.panelReturnOrder.Controls.Add(this.labelVendorName);
            this.panelReturnOrder.Controls.Add(this.labelOrder);
            this.panelReturnOrder.Controls.Add(this.textBoxReturnTotal);
            this.panelReturnOrder.Controls.Add(this.textBoxReturnStatus);
            this.panelReturnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReturnOrder.Location = new System.Drawing.Point(3, 18);
            this.panelReturnOrder.Name = "panelReturnOrder";
            this.panelReturnOrder.Size = new System.Drawing.Size(1071, 537);
            this.panelReturnOrder.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 34;
            this.button2.Text = "&CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelReturnOrderHeading
            // 
            this.labelReturnOrderHeading.AutoSize = true;
            this.labelReturnOrderHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnOrderHeading.Location = new System.Drawing.Point(433, 35);
            this.labelReturnOrderHeading.Name = "labelReturnOrderHeading";
            this.labelReturnOrderHeading.Size = new System.Drawing.Size(221, 29);
            this.labelReturnOrderHeading.TabIndex = 35;
            this.labelReturnOrderHeading.Text = "ORDER RETURN ";
            // 
            // textBoxReturnReason
            // 
            this.textBoxReturnReason.Location = new System.Drawing.Point(394, 323);
            this.textBoxReturnReason.Multiline = true;
            this.textBoxReturnReason.Name = "textBoxReturnReason";
            this.textBoxReturnReason.Size = new System.Drawing.Size(232, 62);
            this.textBoxReturnReason.TabIndex = 31;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(394, 271);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 30;
            // 
            // listBoxReturnProduct
            // 
            this.listBoxReturnProduct.FormattingEnabled = true;
            this.listBoxReturnProduct.ItemHeight = 16;
            this.listBoxReturnProduct.Location = new System.Drawing.Point(394, 198);
            this.listBoxReturnProduct.Name = "listBoxReturnProduct";
            this.listBoxReturnProduct.Size = new System.Drawing.Size(120, 68);
            this.listBoxReturnProduct.TabIndex = 29;
            // 
            // textBoxVendor
            // 
            this.textBoxVendor.Location = new System.Drawing.Point(394, 156);
            this.textBoxVendor.Name = "textBoxVendor";
            this.textBoxVendor.ReadOnly = true;
            this.textBoxVendor.Size = new System.Drawing.Size(100, 22);
            this.textBoxVendor.TabIndex = 28;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(394, 105);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderNumber.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "CREATE &RETURN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelReturnStatus
            // 
            this.labelReturnStatus.AutoSize = true;
            this.labelReturnStatus.Location = new System.Drawing.Point(641, 105);
            this.labelReturnStatus.Name = "labelReturnStatus";
            this.labelReturnStatus.Size = new System.Drawing.Size(125, 17);
            this.labelReturnStatus.TabIndex = 25;
            this.labelReturnStatus.Text = "RETURN STATUS";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(641, 156);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 17);
            this.labelTotal.TabIndex = 24;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(173, 271);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 17);
            this.labelCount.TabIndex = 23;
            this.labelCount.Text = "COUNT";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(173, 323);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(161, 17);
            this.labelReason.TabIndex = 22;
            this.labelReason.Text = "REASON FOR RETURN";
            // 
            // labelProductReturn
            // 
            this.labelProductReturn.AutoSize = true;
            this.labelProductReturn.Location = new System.Drawing.Point(172, 198);
            this.labelProductReturn.Name = "labelProductReturn";
            this.labelProductReturn.Size = new System.Drawing.Size(162, 17);
            this.labelProductReturn.TabIndex = 21;
            this.labelProductReturn.Text = "RETURNING PRODUCT";
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(172, 156);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(110, 17);
            this.labelVendorName.TabIndex = 20;
            this.labelVendorName.Text = "VENDOR NAME";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(172, 111);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(66, 17);
            this.labelOrder.TabIndex = 19;
            this.labelOrder.Text = "ORDER#";
            // 
            // textBoxReturnTotal
            // 
            this.textBoxReturnTotal.Location = new System.Drawing.Point(815, 155);
            this.textBoxReturnTotal.Name = "textBoxReturnTotal";
            this.textBoxReturnTotal.ReadOnly = true;
            this.textBoxReturnTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxReturnTotal.TabIndex = 33;
            // 
            // textBoxReturnStatus
            // 
            this.textBoxReturnStatus.Location = new System.Drawing.Point(815, 99);
            this.textBoxReturnStatus.Name = "textBoxReturnStatus";
            this.textBoxReturnStatus.ReadOnly = true;
            this.textBoxReturnStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxReturnStatus.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelReturnOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 558);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // OrderReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1077, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Name = "OrderReturnForm";
            this.Text = "ORDER RETURN";
            this.panelReturnOrder.ResumeLayout(false);
            this.panelReturnOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelReturnOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelReturnOrderHeading;
        private System.Windows.Forms.TextBox textBoxReturnReason;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.ListBox listBoxReturnProduct;
        private System.Windows.Forms.TextBox textBoxVendor;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Button button1;
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
    }
}