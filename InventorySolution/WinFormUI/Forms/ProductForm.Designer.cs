
namespace WinFormUI.Forms
{
    partial class ProductForm
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
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroupName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.btnBrowseFileName = new System.Windows.Forms.Button();
            this.pctProductImage = new System.Windows.Forms.PictureBox();
            this.txtProductComments = new System.Windows.Forms.TextBox();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductComments = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGpnName = new System.Windows.Forms.ComboBox();
            this.grpBrand = new System.Windows.Forms.GroupBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrandName = new System.Windows.Forms.ComboBox();
            this.grpGroup.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGroup
            // 
            this.grpGroup.Controls.Add(this.label1);
            this.grpGroup.Controls.Add(this.cmbGroupName);
            this.grpGroup.Location = new System.Drawing.Point(26, 103);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(295, 61);
            this.grpGroup.TabIndex = 25;
            this.grpGroup.TabStop = false;
            this.grpGroup.Text = "Group";
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
            // cmbGroupName
            // 
            this.cmbGroupName.FormattingEnabled = true;
            this.cmbGroupName.Location = new System.Drawing.Point(90, 20);
            this.cmbGroupName.Name = "cmbGroupName";
            this.cmbGroupName.Size = new System.Drawing.Size(174, 21);
            this.cmbGroupName.TabIndex = 0;
            this.cmbGroupName.SelectionChangeCommitted += new System.EventHandler(this.cmbGroupName_SelectionChangeCommitted);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(348, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.lblCategoryName);
            this.grpCategory.Controls.Add(this.cmbCategoryName);
            this.grpCategory.Location = new System.Drawing.Point(26, 22);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(295, 61);
            this.grpCategory.TabIndex = 24;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category";
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
            // cmbCategoryName
            // 
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(90, 20);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(174, 21);
            this.cmbCategoryName.TabIndex = 0;
            this.cmbCategoryName.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoryName_SelectionChangeCommitted);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(551, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Add and close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(447, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.btnBrowseFileName);
            this.grpProduct.Controls.Add(this.pctProductImage);
            this.grpProduct.Controls.Add(this.txtProductComments);
            this.grpProduct.Controls.Add(this.lblProductImage);
            this.grpProduct.Controls.Add(this.lblProductComments);
            this.grpProduct.Controls.Add(this.txtProductName);
            this.grpProduct.Controls.Add(this.lblProductName);
            this.grpProduct.Controls.Add(this.txtFilePath);
            this.grpProduct.Controls.Add(this.txtBarcode);
            this.grpProduct.Controls.Add(this.txtProductID);
            this.grpProduct.Controls.Add(this.lblBarcode);
            this.grpProduct.Controls.Add(this.lblFilePath);
            this.grpProduct.Controls.Add(this.lblProductID);
            this.grpProduct.Location = new System.Drawing.Point(347, 31);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(288, 366);
            this.grpProduct.TabIndex = 23;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // btnBrowseFileName
            // 
            this.btnBrowseFileName.Location = new System.Drawing.Point(230, 328);
            this.btnBrowseFileName.Name = "btnBrowseFileName";
            this.btnBrowseFileName.Size = new System.Drawing.Size(29, 20);
            this.btnBrowseFileName.TabIndex = 11;
            this.btnBrowseFileName.Text = "...";
            this.btnBrowseFileName.UseVisualStyleBackColor = true;
            // 
            // pctProductImage
            // 
            this.pctProductImage.Location = new System.Drawing.Point(90, 216);
            this.pctProductImage.Name = "pctProductImage";
            this.pctProductImage.Size = new System.Drawing.Size(169, 97);
            this.pctProductImage.TabIndex = 10;
            this.pctProductImage.TabStop = false;
            // 
            // txtProductComments
            // 
            this.txtProductComments.Location = new System.Drawing.Point(90, 132);
            this.txtProductComments.Multiline = true;
            this.txtProductComments.Name = "txtProductComments";
            this.txtProductComments.Size = new System.Drawing.Size(174, 67);
            this.txtProductComments.TabIndex = 7;
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(14, 216);
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
            this.txtProductName.TabIndex = 8;
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
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(90, 328);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(142, 20);
            this.txtFilePath.TabIndex = 9;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(90, 60);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(174, 20);
            this.txtBarcode.TabIndex = 9;
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
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(14, 331);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(47, 13);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "File path";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGpnName);
            this.groupBox1.Location = new System.Drawing.Point(26, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 61);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generic Product Name";
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
            // cmbGpnName
            // 
            this.cmbGpnName.FormattingEnabled = true;
            this.cmbGpnName.Location = new System.Drawing.Point(90, 20);
            this.cmbGpnName.Name = "cmbGpnName";
            this.cmbGpnName.Size = new System.Drawing.Size(174, 21);
            this.cmbGpnName.TabIndex = 0;
            // 
            // grpBrand
            // 
            this.grpBrand.Controls.Add(this.lblBrand);
            this.grpBrand.Controls.Add(this.cmbBrandName);
            this.grpBrand.Location = new System.Drawing.Point(26, 266);
            this.grpBrand.Name = "grpBrand";
            this.grpBrand.Size = new System.Drawing.Size(295, 61);
            this.grpBrand.TabIndex = 26;
            this.grpBrand.TabStop = false;
            this.grpBrand.Text = "Brand";
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
            // cmbBrandName
            // 
            this.cmbBrandName.FormattingEnabled = true;
            this.cmbBrandName.Location = new System.Drawing.Point(90, 20);
            this.cmbBrandName.Name = "cmbBrandName";
            this.cmbBrandName.Size = new System.Drawing.Size(174, 21);
            this.cmbBrandName.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.grpBrand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpProduct);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBrand.ResumeLayout(false);
            this.grpBrand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroupName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.TextBox txtProductComments;
        private System.Windows.Forms.Label lblProductComments;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGpnName;
        private System.Windows.Forms.PictureBox pctProductImage;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.GroupBox grpBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrandName;
        private System.Windows.Forms.Button btnBrowseFileName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
    }
}