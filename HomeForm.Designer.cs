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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeRepairOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeInventoryOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // placeRepairOrderToolStripMenuItem
            // 
            this.placeRepairOrderToolStripMenuItem.Name = "placeRepairOrderToolStripMenuItem";
            this.placeRepairOrderToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.placeRepairOrderToolStripMenuItem.Text = "Place Repair Order";
            // 
            // placeInventoryOrderToolStripMenuItem
            // 
            this.placeInventoryOrderToolStripMenuItem.Name = "placeInventoryOrderToolStripMenuItem";
            this.placeInventoryOrderToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.placeInventoryOrderToolStripMenuItem.Text = "Place Inventory Order";
            // 
            // contactClientsToolStripMenuItem
            // 
            this.contactClientsToolStripMenuItem.Name = "contactClientsToolStripMenuItem";
            this.contactClientsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.contactClientsToolStripMenuItem.Text = "Contact Clients";
            // 
            // viewDatabaseToolStripMenuItem
            // 
            this.viewDatabaseToolStripMenuItem.Name = "viewDatabaseToolStripMenuItem";
            this.viewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.viewDatabaseToolStripMenuItem.Text = "View Database";
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
    }
}