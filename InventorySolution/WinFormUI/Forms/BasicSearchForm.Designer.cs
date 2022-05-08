
namespace WinFormUI.Forms
{
    partial class BasicSearchForm
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpQueryType = new System.Windows.Forms.GroupBox();
            this.rdoStore = new System.Windows.Forms.RadioButton();
            this.rdoBrand = new System.Windows.Forms.RadioButton();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoGpn = new System.Windows.Forms.RadioButton();
            this.rdoGroup = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.grpSearchParameter = new System.Windows.Forms.GroupBox();
            this.rdoBarcode = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpQueryType.SuspendLayout();
            this.grpSearchParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(148, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(184, 32);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(779, 355);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(648, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 42);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpQueryType
            // 
            this.grpQueryType.Controls.Add(this.rdoStore);
            this.grpQueryType.Controls.Add(this.rdoBrand);
            this.grpQueryType.Controls.Add(this.rdoProduct);
            this.grpQueryType.Controls.Add(this.rdoGpn);
            this.grpQueryType.Controls.Add(this.rdoGroup);
            this.grpQueryType.Controls.Add(this.rdoCategory);
            this.grpQueryType.Location = new System.Drawing.Point(431, 24);
            this.grpQueryType.Name = "grpQueryType";
            this.grpQueryType.Size = new System.Drawing.Size(159, 186);
            this.grpQueryType.TabIndex = 5;
            this.grpQueryType.TabStop = false;
            this.grpQueryType.Text = "Query type";
            // 
            // rdoStore
            // 
            this.rdoStore.AutoSize = true;
            this.rdoStore.Location = new System.Drawing.Point(18, 145);
            this.rdoStore.Name = "rdoStore";
            this.rdoStore.Size = new System.Drawing.Size(50, 17);
            this.rdoStore.TabIndex = 0;
            this.rdoStore.TabStop = true;
            this.rdoStore.Text = "Store";
            this.rdoStore.UseVisualStyleBackColor = true;
            // 
            // rdoBrand
            // 
            this.rdoBrand.AutoSize = true;
            this.rdoBrand.Location = new System.Drawing.Point(18, 122);
            this.rdoBrand.Name = "rdoBrand";
            this.rdoBrand.Size = new System.Drawing.Size(53, 17);
            this.rdoBrand.TabIndex = 0;
            this.rdoBrand.TabStop = true;
            this.rdoBrand.Text = "Brand";
            this.rdoBrand.UseVisualStyleBackColor = true;
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(18, 99);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(62, 17);
            this.rdoProduct.TabIndex = 0;
            this.rdoProduct.TabStop = true;
            this.rdoProduct.Text = "Product";
            this.rdoProduct.UseVisualStyleBackColor = true;
            // 
            // rdoGpn
            // 
            this.rdoGpn.AutoSize = true;
            this.rdoGpn.Location = new System.Drawing.Point(18, 76);
            this.rdoGpn.Name = "rdoGpn";
            this.rdoGpn.Size = new System.Drawing.Size(133, 17);
            this.rdoGpn.TabIndex = 0;
            this.rdoGpn.TabStop = true;
            this.rdoGpn.Text = "Generic Product Name";
            this.rdoGpn.UseVisualStyleBackColor = true;
            // 
            // rdoGroup
            // 
            this.rdoGroup.AutoSize = true;
            this.rdoGroup.Location = new System.Drawing.Point(18, 53);
            this.rdoGroup.Name = "rdoGroup";
            this.rdoGroup.Size = new System.Drawing.Size(54, 17);
            this.rdoGroup.TabIndex = 0;
            this.rdoGroup.TabStop = true;
            this.rdoGroup.Text = "Group";
            this.rdoGroup.UseVisualStyleBackColor = true;
            // 
            // rdoCategory
            // 
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.Location = new System.Drawing.Point(18, 30);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(67, 17);
            this.rdoCategory.TabIndex = 0;
            this.rdoCategory.TabStop = true;
            this.rdoCategory.Text = "Category";
            this.rdoCategory.UseVisualStyleBackColor = true;
            // 
            // grpSearchParameter
            // 
            this.grpSearchParameter.Controls.Add(this.rdoAll);
            this.grpSearchParameter.Controls.Add(this.rdoBarcode);
            this.grpSearchParameter.Controls.Add(this.rdoName);
            this.grpSearchParameter.Controls.Add(this.rdoID);
            this.grpSearchParameter.Controls.Add(this.txtBarcode);
            this.grpSearchParameter.Controls.Add(this.txtName);
            this.grpSearchParameter.Controls.Add(this.txtID);
            this.grpSearchParameter.Location = new System.Drawing.Point(12, 24);
            this.grpSearchParameter.Name = "grpSearchParameter";
            this.grpSearchParameter.Size = new System.Drawing.Size(353, 186);
            this.grpSearchParameter.TabIndex = 6;
            this.grpSearchParameter.TabStop = false;
            this.grpSearchParameter.Text = "Search parameter";
            // 
            // rdoBarcode
            // 
            this.rdoBarcode.AutoSize = true;
            this.rdoBarcode.Location = new System.Drawing.Point(17, 116);
            this.rdoBarcode.Name = "rdoBarcode";
            this.rdoBarcode.Size = new System.Drawing.Size(65, 17);
            this.rdoBarcode.TabIndex = 3;
            this.rdoBarcode.TabStop = true;
            this.rdoBarcode.Text = "Barcode";
            this.rdoBarcode.UseVisualStyleBackColor = true;
            this.rdoBarcode.Click += new System.EventHandler(this.rdoBarcode_Click);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(17, 75);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(53, 17);
            this.rdoName.TabIndex = 3;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.Click += new System.EventHandler(this.rdoName_Click);
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Location = new System.Drawing.Point(17, 34);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(36, 17);
            this.rdoID.TabIndex = 3;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "ID";
            this.rdoID.UseVisualStyleBackColor = true;
            this.rdoID.Click += new System.EventHandler(this.rdoID_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(148, 106);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(184, 32);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(148, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 32);
            this.txtName.TabIndex = 2;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(17, 157);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(70, 17);
            this.rdoAll.TabIndex = 3;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Return all";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.Click += new System.EventHandler(this.rdoAll_Click);
            // 
            // BasicSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpSearchParameter);
            this.Controls.Add(this.grpQueryType);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BasicSearchForm";
            this.Text = "Basic search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpQueryType.ResumeLayout(false);
            this.grpQueryType.PerformLayout();
            this.grpSearchParameter.ResumeLayout(false);
            this.grpSearchParameter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpQueryType;
        private System.Windows.Forms.RadioButton rdoStore;
        private System.Windows.Forms.RadioButton rdoBrand;
        private System.Windows.Forms.RadioButton rdoProduct;
        private System.Windows.Forms.RadioButton rdoGpn;
        private System.Windows.Forms.RadioButton rdoGroup;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.GroupBox grpSearchParameter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.RadioButton rdoBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}