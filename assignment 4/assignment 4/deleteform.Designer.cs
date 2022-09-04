namespace assignment_4
{
    partial class deleteform
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
            this.SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.namesearch_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDataGridView
            // 
            this.SearchDataGridView.AllowUserToAddRows = false;
            this.SearchDataGridView.AllowUserToDeleteRows = false;
            this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGridView.Location = new System.Drawing.Point(12, 147);
            this.SearchDataGridView.Name = "SearchDataGridView";
            this.SearchDataGridView.RowHeadersWidth = 51;
            this.SearchDataGridView.RowTemplate.Height = 24;
            this.SearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchDataGridView.Size = new System.Drawing.Size(776, 150);
            this.SearchDataGridView.TabIndex = 21;
            this.SearchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchDataGridView_CellContentClick);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(385, 103);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 24;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // namesearch_txt
            // 
            this.namesearch_txt.Location = new System.Drawing.Point(325, 57);
            this.namesearch_txt.Name = "namesearch_txt";
            this.namesearch_txt.Size = new System.Drawing.Size(175, 22);
            this.namesearch_txt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(310, 333);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(222, 23);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "delete selected item";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // deleteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.namesearch_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteform";
            this.Text = "deleteform";
            this.Load += new System.EventHandler(this.deleteform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox namesearch_txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView SearchDataGridView;
        private System.Windows.Forms.Button delete_btn;
    }
}