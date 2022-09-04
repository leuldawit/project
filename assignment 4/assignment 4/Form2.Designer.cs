namespace assignment_4
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.productcard1 = new assignment_4.productcard();
            this.panel1.SuspendLayout();
            this.display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 457);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // display_panel
            // 
            this.display_panel.AutoScroll = true;
            this.display_panel.Controls.Add(this.productcard1);
            this.display_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.display_panel.Location = new System.Drawing.Point(217, 0);
            this.display_panel.Margin = new System.Windows.Forms.Padding(4);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(712, 457);
            this.display_panel.TabIndex = 4;
            this.display_panel.WrapContents = false;
            this.display_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.display_panel_Paint);
            // 
            // productcard1
            // 
            this.productcard1.date = "$Price $Price $Price $Price $Price DateDateDateDateDateDateDateDateDateDate";
            this.productcard1.Location = new System.Drawing.Point(3, 3);
            this.productcard1.Name = "productcard1";
            this.productcard1.price = "Date Date Date Date Date $Price$Price$Price$Price$Price$Price$Price$Price$Price$P" +
    "rice";
            this.productcard1.Size = new System.Drawing.Size(598, 250);
            this.productcard1.TabIndex = 0;
            this.productcard1.title = "Title Title Title Title Title TitleTitleTitleTitleTitleTitleTitleTitleTitleTitle";
            this.productcard1.Load += new System.EventHandler(this.productcard1_Load_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(929, 457);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.display_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel display_panel;
        private productcard productcard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}