namespace ConsignmentCompanyProject
{
    partial class ManagerMainWindow
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.menuStripManager = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYMANAGEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERMANAGEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlDashBoard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewNewOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrdersInProcess = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrderCompleted = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrderReturns = new System.Windows.Forms.DataGridView();
            this.buttonRefersh = new System.Windows.Forms.Button();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripManager.SuspendLayout();
            this.tabControlDashBoard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersInProcess)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderCompleted)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderReturns)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(970, 52);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 25);
            this.labelUserName.TabIndex = 0;
            // 
            // menuStripManager
            // 
            this.menuStripManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStripManager.Location = new System.Drawing.Point(0, 0);
            this.menuStripManager.Name = "menuStripManager";
            this.menuStripManager.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripManager.Size = new System.Drawing.Size(1133, 28);
            this.menuStripManager.TabIndex = 1;
            this.menuStripManager.Text = "menuStripManager";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.eXITToolStripMenuItem1});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.orderToolStripMenuItem.Text = "&FILE";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.eXITToolStripMenuItem.Text = "&USER PROFILE";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click_1);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNVENTORYMANAGEMENTToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.inventoryToolStripMenuItem.Text = "&INVENTORY";
            // 
            // iNVENTORYMANAGEMENTToolStripMenuItem
            // 
            this.iNVENTORYMANAGEMENTToolStripMenuItem.Name = "iNVENTORYMANAGEMENTToolStripMenuItem";
            this.iNVENTORYMANAGEMENTToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.iNVENTORYMANAGEMENTToolStripMenuItem.Text = "INVENTORY &MANAGEMENT";
            this.iNVENTORYMANAGEMENTToolStripMenuItem.Click += new System.EventHandler(this.iNVENTORYMANAGEMENTToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUSTOMERMANAGEMENTToolStripMenuItem});
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.vendorToolStripMenuItem.Text = "&CUSTOMER";
            // 
            // cUSTOMERMANAGEMENTToolStripMenuItem
            // 
            this.cUSTOMERMANAGEMENTToolStripMenuItem.Name = "cUSTOMERMANAGEMENTToolStripMenuItem";
            this.cUSTOMERMANAGEMENTToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.cUSTOMERMANAGEMENTToolStripMenuItem.Text = "CUSTOMER MA&NAGEMENT";
            this.cUSTOMERMANAGEMENTToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERMANAGEMENTToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWUSERToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.reportsToolStripMenuItem.Text = "&USER";
            // 
            // aDDNEWUSERToolStripMenuItem
            // 
            this.aDDNEWUSERToolStripMenuItem.Name = "aDDNEWUSERToolStripMenuItem";
            this.aDDNEWUSERToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.aDDNEWUSERToolStripMenuItem.Text = "&ADD NEWUSER";
            this.aDDNEWUSERToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWUSERToolStripMenuItem_Click);
            // 
            // tabControlDashBoard
            // 
            this.tabControlDashBoard.Controls.Add(this.tabPage1);
            this.tabControlDashBoard.Controls.Add(this.tabPage2);
            this.tabControlDashBoard.Controls.Add(this.tabPage3);
            this.tabControlDashBoard.Controls.Add(this.tabPage4);
            this.tabControlDashBoard.Location = new System.Drawing.Point(12, 215);
            this.tabControlDashBoard.Name = "tabControlDashBoard";
            this.tabControlDashBoard.SelectedIndex = 0;
            this.tabControlDashBoard.Size = new System.Drawing.Size(1067, 403);
            this.tabControlDashBoard.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewNewOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNewOrders
            // 
            this.dataGridViewNewOrders.AllowUserToAddRows = false;
            this.dataGridViewNewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewNewOrders.AllowUserToOrderColumns = true;
            this.dataGridViewNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNewOrders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewNewOrders.Name = "dataGridViewNewOrders";
            this.dataGridViewNewOrders.ReadOnly = true;
            this.dataGridViewNewOrders.RowTemplate.Height = 24;
            this.dataGridViewNewOrders.Size = new System.Drawing.Size(1053, 366);
            this.dataGridViewNewOrders.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewOrdersInProcess);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrdersInProcess
            // 
            this.dataGridViewOrdersInProcess.AllowUserToAddRows = false;
            this.dataGridViewOrdersInProcess.AllowUserToDeleteRows = false;
            this.dataGridViewOrdersInProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersInProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrdersInProcess.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrdersInProcess.Name = "dataGridViewOrdersInProcess";
            this.dataGridViewOrdersInProcess.ReadOnly = true;
            this.dataGridViewOrdersInProcess.RowTemplate.Height = 24;
            this.dataGridViewOrdersInProcess.Size = new System.Drawing.Size(1053, 366);
            this.dataGridViewOrdersInProcess.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewOrderCompleted);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1059, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrderCompleted
            // 
            this.dataGridViewOrderCompleted.AllowUserToAddRows = false;
            this.dataGridViewOrderCompleted.AllowUserToDeleteRows = false;
            this.dataGridViewOrderCompleted.AllowUserToOrderColumns = true;
            this.dataGridViewOrderCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderCompleted.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrderCompleted.Name = "dataGridViewOrderCompleted";
            this.dataGridViewOrderCompleted.ReadOnly = true;
            this.dataGridViewOrderCompleted.RowTemplate.Height = 24;
            this.dataGridViewOrderCompleted.Size = new System.Drawing.Size(1053, 366);
            this.dataGridViewOrderCompleted.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewOrderReturns);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1059, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrderReturns
            // 
            this.dataGridViewOrderReturns.AllowUserToAddRows = false;
            this.dataGridViewOrderReturns.AllowUserToDeleteRows = false;
            this.dataGridViewOrderReturns.AllowUserToOrderColumns = true;
            this.dataGridViewOrderReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderReturns.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrderReturns.Name = "dataGridViewOrderReturns";
            this.dataGridViewOrderReturns.ReadOnly = true;
            this.dataGridViewOrderReturns.RowTemplate.Height = 24;
            this.dataGridViewOrderReturns.Size = new System.Drawing.Size(1053, 366);
            this.dataGridViewOrderReturns.TabIndex = 0;
            // 
            // buttonRefersh
            // 
            this.buttonRefersh.Location = new System.Drawing.Point(958, 191);
            this.buttonRefersh.Name = "buttonRefersh";
            this.buttonRefersh.Size = new System.Drawing.Size(117, 28);
            this.buttonRefersh.TabIndex = 3;
            this.buttonRefersh.Text = "RE&FERSH";
            this.buttonRefersh.UseVisualStyleBackColor = true;
            this.buttonRefersh.Click += new System.EventHandler(this.buttonRefersh_Click);
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.eXITToolStripMenuItem1.Text = "E&XIT";
            // 
            // ManagerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 630);
            this.Controls.Add(this.buttonRefersh);
            this.Controls.Add(this.tabControlDashBoard);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.menuStripManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripManager;
            this.Name = "ManagerMainWindow";
            this.Text = "DASHBOARD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerMainWindow_FormClosed);
            this.Load += new System.EventHandler(this.ManagerMainWindow_Load);
            this.menuStripManager.ResumeLayout(false);
            this.menuStripManager.PerformLayout();
            this.tabControlDashBoard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersInProcess)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderCompleted)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderReturns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MenuStrip menuStripManager;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYMANAGEMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERMANAGEMENTToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDashBoard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewNewOrders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewOrdersInProcess;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewOrderCompleted;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewOrderReturns;
        private System.Windows.Forms.Button buttonRefersh;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem1;
    }
}