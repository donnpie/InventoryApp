
namespace WinFormUI.Forms
{
    partial class MainForm
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
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genericProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genericProductNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockCheckinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.genericProductNameToolStripMenuItem,
            this.brandToolStripMenuItem,
            this.storeToolStripMenuItem});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // genericProductNameToolStripMenuItem
            // 
            this.genericProductNameToolStripMenuItem.Name = "genericProductNameToolStripMenuItem";
            this.genericProductNameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.genericProductNameToolStripMenuItem.Text = "Generic Product Name";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem1,
            this.groupToolStripMenuItem1,
            this.genericProductNameToolStripMenuItem1,
            this.brandToolStripMenuItem1,
            this.storeToolStripMenuItem1});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.categoryToolStripMenuItem1.Text = "Category";
            // 
            // groupToolStripMenuItem1
            // 
            this.groupToolStripMenuItem1.Name = "groupToolStripMenuItem1";
            this.groupToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.groupToolStripMenuItem1.Text = "Group";
            // 
            // genericProductNameToolStripMenuItem1
            // 
            this.genericProductNameToolStripMenuItem1.Name = "genericProductNameToolStripMenuItem1";
            this.genericProductNameToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.genericProductNameToolStripMenuItem1.Text = "Generic Product Name";
            // 
            // brandToolStripMenuItem1
            // 
            this.brandToolStripMenuItem1.Name = "brandToolStripMenuItem1";
            this.brandToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.brandToolStripMenuItem1.Text = "Brand";
            // 
            // storeToolStripMenuItem1
            // 
            this.storeToolStripMenuItem1.Name = "storeToolStripMenuItem1";
            this.storeToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.storeToolStripMenuItem1.Text = "Store";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockCheckinToolStripMenuItem,
            this.stockCheckoutToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // stockCheckinToolStripMenuItem
            // 
            this.stockCheckinToolStripMenuItem.Name = "stockCheckinToolStripMenuItem";
            this.stockCheckinToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stockCheckinToolStripMenuItem.Text = "Stock checkin";
            // 
            // stockCheckoutToolStripMenuItem
            // 
            this.stockCheckoutToolStripMenuItem.Name = "stockCheckoutToolStripMenuItem";
            this.stockCheckoutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stockCheckoutToolStripMenuItem.Text = "Stock checkout";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Inventory App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genericProductNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genericProductNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockCheckinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockCheckoutToolStripMenuItem;
    }
}