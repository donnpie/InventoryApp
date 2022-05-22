
namespace WinFormUI.Forms
{
    partial class ViewProductForm
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
            this.components = new System.ComponentModel.Container();
            this.grpBrand = new System.Windows.Forms.GroupBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGpnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.pctProductImage = new System.Windows.Forms.PictureBox();
            this.txtProductComments = new System.Windows.Forms.TextBox();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductComments = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.grpBrand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGroup.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBrand
            // 
            this.grpBrand.Controls.Add(this.txtBrandName);
            this.grpBrand.Controls.Add(this.lblBrand);
            this.grpBrand.Location = new System.Drawing.Point(12, 256);
            this.grpBrand.Name = "grpBrand";
            this.grpBrand.Size = new System.Drawing.Size(295, 61);
            this.grpBrand.TabIndex = 43;
            this.grpBrand.TabStop = false;
            this.grpBrand.Text = "Brand";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(90, 20);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(174, 20);
            this.txtBrandName.TabIndex = 12;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(14, 23);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 14;
            this.lblBrand.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGpnName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 61);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generic Product Name";
            // 
            // txtGpnName
            // 
            this.txtGpnName.Location = new System.Drawing.Point(90, 20);
            this.txtGpnName.Name = "txtGpnName";
            this.txtGpnName.Size = new System.Drawing.Size(174, 20);
            this.txtGpnName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // grpGroup
            // 
            this.grpGroup.Controls.Add(this.txtGroupName);
            this.grpGroup.Controls.Add(this.label1);
            this.grpGroup.Location = new System.Drawing.Point(12, 93);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(295, 61);
            this.grpGroup.TabIndex = 42;
            this.grpGroup.TabStop = false;
            this.grpGroup.Text = "Group";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(90, 20);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(174, 20);
            this.txtGroupName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.txtCategoryName);
            this.grpCategory.Controls.Add(this.lblCategoryName);
            this.grpCategory.Location = new System.Drawing.Point(12, 12);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(295, 61);
            this.grpCategory.TabIndex = 41;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(90, 20);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(174, 20);
            this.txtCategoryName.TabIndex = 12;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(14, 23);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(35, 13);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.pctProductImage);
            this.grpProduct.Controls.Add(this.txtProductComments);
            this.grpProduct.Controls.Add(this.lblProductImage);
            this.grpProduct.Controls.Add(this.lblProductComments);
            this.grpProduct.Controls.Add(this.txtProductName);
            this.grpProduct.Controls.Add(this.lblProductName);
            this.grpProduct.Controls.Add(this.txtBarcode);
            this.grpProduct.Controls.Add(this.txtProductID);
            this.grpProduct.Controls.Add(this.lblBarcode);
            this.grpProduct.Controls.Add(this.lblProductID);
            this.grpProduct.Location = new System.Drawing.Point(333, 21);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(288, 409);
            this.grpProduct.TabIndex = 40;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // pctProductImage
            // 
            this.pctProductImage.Location = new System.Drawing.Point(90, 186);
            this.pctProductImage.Name = "pctProductImage";
            this.pctProductImage.Size = new System.Drawing.Size(174, 203);
            this.pctProductImage.TabIndex = 10;
            this.pctProductImage.TabStop = false;
            // 
            // txtProductComments
            // 
            this.txtProductComments.Location = new System.Drawing.Point(90, 132);
            this.txtProductComments.Multiline = true;
            this.txtProductComments.Name = "txtProductComments";
            this.txtProductComments.Size = new System.Drawing.Size(174, 44);
            this.txtProductComments.TabIndex = 7;
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(14, 186);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(36, 13);
            this.lblProductImage.TabIndex = 4;
            this.lblProductImage.Text = "Image";
            // 
            // lblProductComments
            // 
            this.lblProductComments.AutoSize = true;
            this.lblProductComments.Location = new System.Drawing.Point(14, 135);
            this.lblProductComments.Name = "lblProductComments";
            this.lblProductComments.Size = new System.Drawing.Size(56, 13);
            this.lblProductComments.TabIndex = 4;
            this.lblProductComments.Text = "Comments";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(90, 96);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(174, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(14, 99);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(35, 13);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Name";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(90, 60);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(174, 20);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(90, 23);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(174, 20);
            this.txtProductID.TabIndex = 9;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(14, 63);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 6;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(14, 26);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "ID";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(12, 333);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(112, 23);
            this.btnAddNewProduct.TabIndex = 45;
            this.btnAddNewProduct.Text = "Add new product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // ViewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 474);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.grpBrand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGroup);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpProduct);
            this.Name = "ViewProductForm";
            this.Text = "View product";
            this.grpBrand.ResumeLayout(false);
            this.grpBrand.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBrand;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGpnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.PictureBox pctProductImage;
        private System.Windows.Forms.TextBox txtProductComments;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.Label lblProductComments;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddNewProduct;
    }
}