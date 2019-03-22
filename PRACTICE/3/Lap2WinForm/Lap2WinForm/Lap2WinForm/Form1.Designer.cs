namespace Lap2WinForm
{
    partial class Form1
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
            this.lblCategory = new System.Windows.Forms.LinkLabel();
            this.lblSupplier = new System.Windows.Forms.LinkLabel();
            this.lblProduct = new System.Windows.Forms.LinkLabel();
            this.lblOrder = new System.Windows.Forms.LinkLabel();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.LinkColor = System.Drawing.Color.Red;
            this.lblCategory.Location = new System.Drawing.Point(28, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.TabStop = true;
            this.lblCategory.Text = "Category";
            this.lblCategory.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.lblCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.LinkColor = System.Drawing.Color.Red;
            this.lblSupplier.Location = new System.Drawing.Point(234, 26);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(84, 25);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.TabStop = true;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.LinkColor = System.Drawing.Color.Red;
            this.lblProduct.LinkVisited = true;
            this.lblProduct.Location = new System.Drawing.Point(433, 26);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(86, 25);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.TabStop = true;
            this.lblProduct.Text = "Product";
            this.lblProduct.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.LinkColor = System.Drawing.Color.Red;
            this.lblOrder.Location = new System.Drawing.Point(681, 26);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(62, 25);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.TabStop = true;
            this.lblOrder.Text = "Order";
            this.lblOrder.VisitedLinkColor = System.Drawing.Color.White;
            this.lblOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // dtGridView
            // 
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(31, 68);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(1343, 654);
            this.dtGridView.TabIndex = 4;
            this.dtGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellClick);
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 807);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblCategory);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblCategory;
        private System.Windows.Forms.LinkLabel lblSupplier;
        private System.Windows.Forms.LinkLabel lblProduct;
        private System.Windows.Forms.LinkLabel lblOrder;
        private System.Windows.Forms.DataGridView dtGridView;
    }
}

