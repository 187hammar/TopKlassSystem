namespace TopKlassSystem
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.placeRepairOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRepairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairLineupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeInventoryOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeRepairOrderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.placeInventoryOrderToolStripMenuItem,
            this.contactClientsToolStripMenuItem,
            this.viewDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // placeRepairOrderToolStripMenuItem
            // 
            this.placeRepairOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRepairToolStripMenuItem,
            this.updateRepairsToolStripMenuItem,
            this.repairLineupToolStripMenuItem});
            this.placeRepairOrderToolStripMenuItem.Name = "placeRepairOrderToolStripMenuItem";
            this.placeRepairOrderToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.placeRepairOrderToolStripMenuItem.Text = "Place Repair Order";
            // 
            // addRepairToolStripMenuItem
            // 
            this.addRepairToolStripMenuItem.Name = "addRepairToolStripMenuItem";
            this.addRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRepairToolStripMenuItem.Text = "Add Repair";
            this.addRepairToolStripMenuItem.Click += new System.EventHandler(this.AddRepairToolStripMenuItem_Click);
            // 
            // updateRepairsToolStripMenuItem
            // 
            this.updateRepairsToolStripMenuItem.Name = "updateRepairsToolStripMenuItem";
            this.updateRepairsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateRepairsToolStripMenuItem.Text = "Update Repairs";
            this.updateRepairsToolStripMenuItem.Click += new System.EventHandler(this.UpdateRepairsToolStripMenuItem_Click);
            // 
            // repairLineupToolStripMenuItem
            // 
            this.repairLineupToolStripMenuItem.Name = "repairLineupToolStripMenuItem";
            this.repairLineupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repairLineupToolStripMenuItem.Text = "Repair line-up";
            this.repairLineupToolStripMenuItem.Click += new System.EventHandler(this.RepairLineupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // placeInventoryOrderToolStripMenuItem
            // 
            this.placeInventoryOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem,
            this.updateStockOrderToolStripMenuItem});
            this.placeInventoryOrderToolStripMenuItem.Name = "placeInventoryOrderToolStripMenuItem";
            this.placeInventoryOrderToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.placeInventoryOrderToolStripMenuItem.Text = "Place Inventory Order";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.AddOrderToolStripMenuItem_Click);
            // 
            // updateStockOrderToolStripMenuItem
            // 
            this.updateStockOrderToolStripMenuItem.Name = "updateStockOrderToolStripMenuItem";
            this.updateStockOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateStockOrderToolStripMenuItem.Text = "Edit Stock Orders";
            this.updateStockOrderToolStripMenuItem.Click += new System.EventHandler(this.UpdateStockOrderToolStripMenuItem_Click);
            // 
            // contactClientsToolStripMenuItem
            // 
            this.contactClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateClientsInfoToolStripMenuItem});
            this.contactClientsToolStripMenuItem.Name = "contactClientsToolStripMenuItem";
            this.contactClientsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.contactClientsToolStripMenuItem.Text = "Contact Clients";
            // 
            // updateClientsInfoToolStripMenuItem
            // 
            this.updateClientsInfoToolStripMenuItem.Name = "updateClientsInfoToolStripMenuItem";
            this.updateClientsInfoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateClientsInfoToolStripMenuItem.Text = "Update Clients Info\'";
            // 
            // viewDatabaseToolStripMenuItem
            // 
            this.viewDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneDatabaseToolStripMenuItem,
            this.clientsDatabaseToolStripMenuItem,
            this.stockDatabaseToolStripMenuItem,
            this.repairDatabaseToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.viewDatabaseToolStripMenuItem.Name = "viewDatabaseToolStripMenuItem";
            this.viewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.viewDatabaseToolStripMenuItem.Text = "View Database";
            // 
            // phoneDatabaseToolStripMenuItem
            // 
            this.phoneDatabaseToolStripMenuItem.Name = "phoneDatabaseToolStripMenuItem";
            this.phoneDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneDatabaseToolStripMenuItem.Text = "Phone Database";
            // 
            // clientsDatabaseToolStripMenuItem
            // 
            this.clientsDatabaseToolStripMenuItem.Name = "clientsDatabaseToolStripMenuItem";
            this.clientsDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clientsDatabaseToolStripMenuItem.Text = "Clients Database";
            // 
            // stockDatabaseToolStripMenuItem
            // 
            this.stockDatabaseToolStripMenuItem.Name = "stockDatabaseToolStripMenuItem";
            this.stockDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.stockDatabaseToolStripMenuItem.Text = "Stock Database";
            // 
            // repairDatabaseToolStripMenuItem
            // 
            this.repairDatabaseToolStripMenuItem.Name = "repairDatabaseToolStripMenuItem";
            this.repairDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.repairDatabaseToolStripMenuItem.Text = "In-Line Database";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TopKlassSystem.Properties.Resources.zzzz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(793, 631);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem placeRepairOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeInventoryOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRepairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairLineupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    }
}