namespace assignment_4
{
    partial class mdi
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoreyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.productToolStripMenuItem.Text = "product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewProductToolStripMenuItem.Text = "add new product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateToolStripMenuItem.Text = "update ";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // catagoreyToolStripMenuItem
            // 
            this.catagoreyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addToDatabaseToolStripMenuItem,
            this.displayFromDatabaseToolStripMenuItem});
            this.catagoreyToolStripMenuItem.Name = "catagoreyToolStripMenuItem";
            this.catagoreyToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.catagoreyToolStripMenuItem.Text = "Display";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.addToolStripMenuItem.Text = "Display All";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.catagoreyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayFromDatabaseToolStripMenuItem
            // 
            this.displayFromDatabaseToolStripMenuItem.Name = "displayFromDatabaseToolStripMenuItem";
            this.displayFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.displayFromDatabaseToolStripMenuItem.Text = "Display from Database";
            this.displayFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.displayFromDatabaseToolStripMenuItem_Click);
            // 
            // addToDatabaseToolStripMenuItem
            // 
            this.addToDatabaseToolStripMenuItem.Name = "addToDatabaseToolStripMenuItem";
            this.addToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.addToDatabaseToolStripMenuItem.Text = "Add to Database";
            this.addToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addToDatabaseToolStripMenuItem_Click);
            // 
            // mdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1109, 505);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdi";
            this.Load += new System.EventHandler(this.mdi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoreyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToDatabaseToolStripMenuItem;
    }
}