namespace TopKlassSystem
{
    partial class stockOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbParts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecievedDate = new System.Windows.Forms.TextBox();
            this.lblRecievedDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotaltxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Klazz Systemz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frequently Requested Parts: ";
            // 
            // cmbParts
            // 
            this.cmbParts.FormattingEnabled = true;
            this.cmbParts.Items.AddRange(new object[] {
            "LCD",
            "Batteries",
            "Screens",
            "Phone Speakers",
            "Phone Microphones",
            "Charging systems",
            "Headset pods"});
            this.cmbParts.Location = new System.Drawing.Point(260, 95);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(193, 21);
            this.cmbParts.TabIndex = 2;
            this.cmbParts.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecievedDate);
            this.groupBox1.Controls.Add(this.lblRecievedDate);
            this.groupBox1.Controls.Add(this.txtOrderDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSpareName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Description";
            // 
            // txtRecievedDate
            // 
            this.txtRecievedDate.Location = new System.Drawing.Point(199, 117);
            this.txtRecievedDate.Name = "txtRecievedDate";
            this.txtRecievedDate.Size = new System.Drawing.Size(229, 29);
            this.txtRecievedDate.TabIndex = 9;
            // 
            // lblRecievedDate
            // 
            this.lblRecievedDate.AutoSize = true;
            this.lblRecievedDate.Location = new System.Drawing.Point(7, 120);
            this.lblRecievedDate.Name = "lblRecievedDate";
            this.lblRecievedDate.Size = new System.Drawing.Size(197, 24);
            this.lblRecievedDate.TabIndex = 8;
            this.lblRecievedDate.Text = "Order Recieved Date: ";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(491, 70);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(278, 29);
            this.txtOrderDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Order Date: ";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(129, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(219, 29);
            this.txtModel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model: ";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(491, 24);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(278, 29);
            this.txtBrand.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Brand: ";
            // 
            // txtSpareName
            // 
            this.txtSpareName.Location = new System.Drawing.Point(129, 24);
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.Size = new System.Drawing.Size(219, 29);
            this.txtSpareName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Spare Name: ";
            // 
            // lblTotaltxt
            // 
            this.lblTotaltxt.AutoSize = true;
            this.lblTotaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaltxt.Location = new System.Drawing.Point(12, 417);
            this.lblTotaltxt.Name = "lblTotaltxt";
            this.lblTotaltxt.Size = new System.Drawing.Size(139, 24);
            this.lblTotaltxt.TabIndex = 4;
            this.lblTotaltxt.Text = "TOTAL COST: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Supplier: ";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(99, 293);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(195, 21);
            this.cmbSupplier.TabIndex = 6;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(681, 419);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(107, 25);
            this.btnSubmitOrder.TabIndex = 7;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.BtnSubmitOrder_Click);
            // 
            // stockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotaltxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stockOrder";
            this.Text = "stockOrder";
            this.Load += new System.EventHandler(this.StockOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbParts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpareName;
        public System.Windows.Forms.Label lblTotaltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSupplier;
        public System.Windows.Forms.TextBox txtRecievedDate;
        public System.Windows.Forms.Label lblRecievedDate;
        private System.Windows.Forms.Button btnSubmitOrder;
        public System.Windows.Forms.TextBox txtOrderDate;
    }
}