
namespace WinFormUI.Forms
{
    partial class GpnForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpGpn = new System.Windows.Forms.GroupBox();
            this.txtGpnDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtGpnName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGpnID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroupName = new System.Windows.Forms.ComboBox();
            this.grpCategory.SuspendLayout();
            this.grpGpn.SuspendLayout();
            this.grpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.lblCategoryName);
            this.grpCategory.Controls.Add(this.cmbCategoryName);
            this.grpCategory.Location = new System.Drawing.Point(26, 27);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(295, 61);
            this.grpCategory.TabIndex = 18;
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
            this.btnClose.Location = new System.Drawing.Point(225, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Add and close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpGpn
            // 
            this.grpGpn.Controls.Add(this.txtGpnDescription);
            this.grpGpn.Controls.Add(this.lblDescription);
            this.grpGpn.Controls.Add(this.txtGpnName);
            this.grpGpn.Controls.Add(this.lblGroupName);
            this.grpGpn.Controls.Add(this.txtGpnID);
            this.grpGpn.Controls.Add(this.lblID);
            this.grpGpn.Location = new System.Drawing.Point(23, 183);
            this.grpGpn.Name = "grpGpn";
            this.grpGpn.Size = new System.Drawing.Size(296, 181);
            this.grpGpn.TabIndex = 17;
            this.grpGpn.TabStop = false;
            this.grpGpn.Text = "Generic Product Name";
            // 
            // txtGpnDescription
            // 
            this.txtGpnDescription.Location = new System.Drawing.Point(90, 95);
            this.txtGpnDescription.Multiline = true;
            this.txtGpnDescription.Name = "txtGpnDescription";
            this.txtGpnDescription.Size = new System.Drawing.Size(174, 67);
            this.txtGpnDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtGpnName
            // 
            this.txtGpnName.Location = new System.Drawing.Point(90, 59);
            this.txtGpnName.Name = "txtGpnName";
            this.txtGpnName.Size = new System.Drawing.Size(174, 20);
            this.txtGpnName.TabIndex = 8;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(14, 62);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(35, 13);
            this.lblGroupName.TabIndex = 5;
            this.lblGroupName.Text = "Name";
            // 
            // txtGpnID
            // 
            this.txtGpnID.Location = new System.Drawing.Point(90, 23);
            this.txtGpnID.Name = "txtGpnID";
            this.txtGpnID.Size = new System.Drawing.Size(174, 20);
            this.txtGpnID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // grpGroup
            // 
            this.grpGroup.Controls.Add(this.label1);
            this.grpGroup.Controls.Add(this.cmbGroupName);
            this.grpGroup.Location = new System.Drawing.Point(24, 104);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(295, 61);
            this.grpGroup.TabIndex = 19;
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
            // 
            // GpnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.grpGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpGpn);
            this.Name = "GpnForm";
            this.Text = "Generic Product Name";
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpGpn.ResumeLayout(false);
            this.grpGpn.PerformLayout();
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpGpn;
        private System.Windows.Forms.TextBox txtGpnDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtGpnName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGpnID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroupName;
    }
}