namespace Presentation
{
    partial class frmReports
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Search By Item");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Search By Date");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sales", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Search By Item");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Search By Date");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Purchases", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Stock");
            this.spc = new System.Windows.Forms.SplitContainer();
            this.tv = new System.Windows.Forms.TreeView();
            this.spc.Panel1.SuspendLayout();
            this.spc.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc
            // 
            this.spc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc.IsSplitterFixed = true;
            this.spc.Location = new System.Drawing.Point(0, 0);
            this.spc.Name = "spc";
            // 
            // spc.Panel1
            // 
            this.spc.Panel1.Controls.Add(this.tv);
            // 
            // spc.Panel2
            // 
            this.spc.Panel2.BackgroundImage = global::Presentation.Properties.Resources.Vista__241_;
            this.spc.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spc.Size = new System.Drawing.Size(853, 464);
            this.spc.SplitterDistance = 167;
            this.spc.TabIndex = 0;
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            treeNode1.Name = "nSaleByItem";
            treeNode1.Text = "Search By Item";
            treeNode2.Name = "nSaleByDate";
            treeNode2.Text = "Search By Date";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Sales";
            treeNode4.Name = "nPurchaseByItem";
            treeNode4.Text = "Search By Item";
            treeNode5.Name = "nPurchaseByDate";
            treeNode5.Text = "Search By Date";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Purchases";
            treeNode7.Name = "nStock";
            treeNode7.Text = "Stock";
            this.tv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7});
            this.tv.Size = new System.Drawing.Size(167, 464);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 464);
            this.Controls.Add(this.spc);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searching and Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.spc.Panel1.ResumeLayout(false);
            this.spc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc;
        private System.Windows.Forms.TreeView tv;
    }
}