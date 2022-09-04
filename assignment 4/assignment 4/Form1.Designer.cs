namespace assignment_4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.text_number = new System.Windows.Forms.TextBox();
            this.text_IN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_objectname = new System.Windows.Forms.TextBox();
            this.text_count = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.butn_add = new System.Windows.Forms.Button();
            this.butn_canel = new System.Windows.Forms.Button();
            this.butn_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_options = new System.Windows.Forms.CheckedListBox();
            this.eth_rbtn = new System.Windows.Forms.RadioButton();
            this.other_rbtn = new System.Windows.Forms.RadioButton();
            this.cash_rbtn = new System.Windows.Forms.RadioButton();
            this.credit_rbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.logout_butn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 16, 11, 15, 37, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // text_number
            // 
            this.text_number.Location = new System.Drawing.Point(151, 125);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(137, 22);
            this.text_number.TabIndex = 4;
            this.text_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_IN
            // 
            this.text_IN.Location = new System.Drawing.Point(722, 127);
            this.text_IN.Name = "text_IN";
            this.text_IN.Size = new System.Drawing.Size(150, 22);
            this.text_IN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Object Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // text_objectname
            // 
            this.text_objectname.Location = new System.Drawing.Point(373, 215);
            this.text_objectname.Name = "text_objectname";
            this.text_objectname.Size = new System.Drawing.Size(236, 22);
            this.text_objectname.TabIndex = 9;
            this.text_objectname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // text_count
            // 
            this.text_count.Location = new System.Drawing.Point(151, 215);
            this.text_count.Name = "text_count";
            this.text_count.Size = new System.Drawing.Size(137, 22);
            this.text_count.TabIndex = 10;
            // 
            // text_price
            // 
            this.text_price.BackColor = System.Drawing.Color.White;
            this.text_price.Location = new System.Drawing.Point(711, 215);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(161, 22);
            this.text_price.TabIndex = 11;
            // 
            // butn_add
            // 
            this.butn_add.BackColor = System.Drawing.Color.White;
            this.butn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_add.Location = new System.Drawing.Point(259, 398);
            this.butn_add.Name = "butn_add";
            this.butn_add.Size = new System.Drawing.Size(91, 37);
            this.butn_add.TabIndex = 12;
            this.butn_add.Text = "Add";
            this.butn_add.UseVisualStyleBackColor = false;
            this.butn_add.Click += new System.EventHandler(this.butn_add_Click);
            // 
            // butn_canel
            // 
            this.butn_canel.BackColor = System.Drawing.Color.White;
            this.butn_canel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_canel.Location = new System.Drawing.Point(409, 397);
            this.butn_canel.Name = "butn_canel";
            this.butn_canel.Size = new System.Drawing.Size(78, 37);
            this.butn_canel.TabIndex = 13;
            this.butn_canel.Text = "Cancel";
            this.butn_canel.UseVisualStyleBackColor = false;
            this.butn_canel.Click += new System.EventHandler(this.butn_canel_Click);
            // 
            // butn_reset
            // 
            this.butn_reset.BackColor = System.Drawing.Color.White;
            this.butn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_reset.Location = new System.Drawing.Point(540, 398);
            this.butn_reset.Name = "butn_reset";
            this.butn_reset.Size = new System.Drawing.Size(95, 37);
            this.butn_reset.TabIndex = 14;
            this.butn_reset.Text = "Reset";
            this.butn_reset.UseVisualStyleBackColor = false;
            this.butn_reset.Click += new System.EventHandler(this.butn_reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 246);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chk_options
            // 
            this.chk_options.BackColor = System.Drawing.Color.Gray;
            this.chk_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_options.FormattingEnabled = true;
            this.chk_options.Items.AddRange(new object[] {
            "product availability",
            "delivery",
            "Agree"});
            this.chk_options.Location = new System.Drawing.Point(133, 288);
            this.chk_options.Name = "chk_options";
            this.chk_options.Size = new System.Drawing.Size(184, 80);
            this.chk_options.TabIndex = 17;
            // 
            // eth_rbtn
            // 
            this.eth_rbtn.AutoSize = true;
            this.eth_rbtn.Location = new System.Drawing.Point(28, 30);
            this.eth_rbtn.Name = "eth_rbtn";
            this.eth_rbtn.Size = new System.Drawing.Size(90, 20);
            this.eth_rbtn.TabIndex = 18;
            this.eth_rbtn.TabStop = true;
            this.eth_rbtn.Text = "In Ethiopia";
            this.eth_rbtn.UseVisualStyleBackColor = true;
            // 
            // other_rbtn
            // 
            this.other_rbtn.AutoSize = true;
            this.other_rbtn.ForeColor = System.Drawing.Color.Maroon;
            this.other_rbtn.Location = new System.Drawing.Point(28, 56);
            this.other_rbtn.Name = "other_rbtn";
            this.other_rbtn.Size = new System.Drawing.Size(60, 20);
            this.other_rbtn.TabIndex = 19;
            this.other_rbtn.TabStop = true;
            this.other_rbtn.Text = "Other";
            this.other_rbtn.UseVisualStyleBackColor = true;
            // 
            // cash_rbtn
            // 
            this.cash_rbtn.AutoSize = true;
            this.cash_rbtn.Location = new System.Drawing.Point(30, 30);
            this.cash_rbtn.Name = "cash_rbtn";
            this.cash_rbtn.Size = new System.Drawing.Size(57, 20);
            this.cash_rbtn.TabIndex = 20;
            this.cash_rbtn.TabStop = true;
            this.cash_rbtn.Text = "cash";
            this.cash_rbtn.UseVisualStyleBackColor = true;
            // 
            // credit_rbtn
            // 
            this.credit_rbtn.AutoSize = true;
            this.credit_rbtn.Location = new System.Drawing.Point(30, 56);
            this.credit_rbtn.Name = "credit_rbtn";
            this.credit_rbtn.Size = new System.Drawing.Size(93, 20);
            this.credit_rbtn.TabIndex = 21;
            this.credit_rbtn.TabStop = true;
            this.credit_rbtn.Text = "Credit card";
            this.credit_rbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eth_rbtn);
            this.groupBox1.Controls.Add(this.other_rbtn);
            this.groupBox1.Location = new System.Drawing.Point(711, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cash_rbtn);
            this.groupBox2.Controls.Add(this.credit_rbtn);
            this.groupBox2.Location = new System.Drawing.Point(409, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(40, 39);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(100, 25);
            this.welcome_lbl.TabIndex = 24;
            this.welcome_lbl.Text = "Welcome ";
            this.welcome_lbl.Click += new System.EventHandler(this.welcome_lbl_Click);
            // 
            // logout_butn
            // 
            this.logout_butn.Location = new System.Drawing.Point(700, 398);
            this.logout_butn.Name = "logout_butn";
            this.logout_butn.Size = new System.Drawing.Size(89, 36);
            this.logout_butn.TabIndex = 25;
            this.logout_butn.Text = "Logout";
            this.logout_butn.UseVisualStyleBackColor = true;
            this.logout_butn.Click += new System.EventHandler(this.logout_butn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1128, 704);
            this.Controls.Add(this.logout_butn);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_options);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butn_reset);
            this.Controls.Add(this.butn_canel);
            this.Controls.Add(this.butn_add);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_count);
            this.Controls.Add(this.text_objectname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_IN);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.TextBox text_IN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_objectname;
        private System.Windows.Forms.TextBox text_count;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Button butn_add;
        private System.Windows.Forms.Button butn_canel;
        private System.Windows.Forms.Button butn_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chk_options;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cash_rbtn;
        private System.Windows.Forms.RadioButton credit_rbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton eth_rbtn;
        private System.Windows.Forms.RadioButton other_rbtn;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Button logout_butn;
    }
}

