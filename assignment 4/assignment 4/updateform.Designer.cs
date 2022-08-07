namespace assignment_4
{
    partial class updateform
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.namesearch_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.count_txt = new System.Windows.Forms.TextBox();
            this.in_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.Number_lbl = new System.Windows.Forms.Label();
            this.count_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.objname_lbl = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.price_lbl = new System.Windows.Forms.Label();
            this.Inventorynum_lbl = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(33, 65);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(44, 16);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Name";
            this.name_lbl.Click += new System.EventHandler(this.name_lbl_Click);
            // 
            // namesearch_txt
            // 
            this.namesearch_txt.Location = new System.Drawing.Point(127, 62);
            this.namesearch_txt.Name = "namesearch_txt";
            this.namesearch_txt.Size = new System.Drawing.Size(175, 22);
            this.namesearch_txt.TabIndex = 1;
            this.namesearch_txt.TextChanged += new System.EventHandler(this.namesearch_txt_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(159, 109);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // SearchDataGridView
            // 
            this.SearchDataGridView.AllowUserToAddRows = false;
            this.SearchDataGridView.AllowUserToDeleteRows = false;
            this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGridView.Location = new System.Drawing.Point(58, 324);
            this.SearchDataGridView.Name = "SearchDataGridView";
            this.SearchDataGridView.ReadOnly = true;
            this.SearchDataGridView.RowHeadersWidth = 51;
            this.SearchDataGridView.RowTemplate.Height = 24;
            this.SearchDataGridView.Size = new System.Drawing.Size(776, 150);
            this.SearchDataGridView.TabIndex = 3;
            this.SearchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchDataGridView_CellContentClick);
            // 
            // number_txt
            // 
            this.number_txt.Location = new System.Drawing.Point(471, 65);
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(100, 22);
            this.number_txt.TabIndex = 4;
            this.number_txt.TextChanged += new System.EventHandler(this.number_txt_TextChanged);
            // 
            // count_txt
            // 
            this.count_txt.Location = new System.Drawing.Point(471, 110);
            this.count_txt.Name = "count_txt";
            this.count_txt.Size = new System.Drawing.Size(100, 22);
            this.count_txt.TabIndex = 5;
            this.count_txt.TextChanged += new System.EventHandler(this.count_txt_TextChanged);
            // 
            // in_txt
            // 
            this.in_txt.Location = new System.Drawing.Point(704, 156);
            this.in_txt.Name = "in_txt";
            this.in_txt.Size = new System.Drawing.Size(100, 22);
            this.in_txt.TabIndex = 6;
            this.in_txt.TextChanged += new System.EventHandler(this.in_txt_TextChanged);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(704, 65);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 7;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // Number_lbl
            // 
            this.Number_lbl.AutoSize = true;
            this.Number_lbl.Location = new System.Drawing.Point(366, 65);
            this.Number_lbl.Name = "Number_lbl";
            this.Number_lbl.Size = new System.Drawing.Size(55, 16);
            this.Number_lbl.TabIndex = 9;
            this.Number_lbl.Text = "Number";
            this.Number_lbl.Click += new System.EventHandler(this.Number_lbl_Click);
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Location = new System.Drawing.Point(380, 112);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(41, 16);
            this.count_lbl.TabIndex = 10;
            this.count_lbl.Text = "Count";
            this.count_lbl.Click += new System.EventHandler(this.count_lbl_Click);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(257, 163);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(36, 16);
            this.date_lbl.TabIndex = 11;
            this.date_lbl.Text = "Date";
            this.date_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // objname_lbl
            // 
            this.objname_lbl.AutoSize = true;
            this.objname_lbl.Location = new System.Drawing.Point(634, 68);
            this.objname_lbl.Name = "objname_lbl";
            this.objname_lbl.Size = new System.Drawing.Size(44, 16);
            this.objname_lbl.TabIndex = 12;
            this.objname_lbl.Text = "Name";
            this.objname_lbl.Click += new System.EventHandler(this.objname_lbl_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(511, 228);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 30);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(649, 116);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(38, 16);
            this.price_lbl.TabIndex = 14;
            this.price_lbl.Text = "Price";
            this.price_lbl.Click += new System.EventHandler(this.price_lbl_Click);
            // 
            // Inventorynum_lbl
            // 
            this.Inventorynum_lbl.AutoSize = true;
            this.Inventorynum_lbl.Location = new System.Drawing.Point(578, 159);
            this.Inventorynum_lbl.Name = "Inventorynum_lbl";
            this.Inventorynum_lbl.Size = new System.Drawing.Size(109, 16);
            this.Inventorynum_lbl.TabIndex = 15;
            this.Inventorynum_lbl.Text = "inventory number";
            this.Inventorynum_lbl.Click += new System.EventHandler(this.Inventorynum_lbl_Click);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(704, 113);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 22);
            this.price_txt.TabIndex = 16;
            this.price_txt.TextChanged += new System.EventHandler(this.price_txt_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // updateform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(896, 519);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.Inventorynum_lbl);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.objname_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.Number_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.in_txt);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.number_txt);
            this.Controls.Add(this.SearchDataGridView);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.namesearch_txt);
            this.Controls.Add(this.name_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateform";
            this.Text = "updateform";
            this.Load += new System.EventHandler(this.updateform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox namesearch_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView SearchDataGridView;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.TextBox count_txt;
        private System.Windows.Forms.TextBox in_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label Number_lbl;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label objname_lbl;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label Inventorynum_lbl;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}