namespace assignment_4
{
    partial class DisplayFromDbform
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
            this.display_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.productcard1 = new assignment_4.productcard();
            this.display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // display_panel
            // 
            this.display_panel.AutoScroll = true;
            this.display_panel.Controls.Add(this.productcard1);
            this.display_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.display_panel.Location = new System.Drawing.Point(0, 0);
            this.display_panel.Margin = new System.Windows.Forms.Padding(4);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(800, 450);
            this.display_panel.TabIndex = 5;
            this.display_panel.WrapContents = false;
            // 
            // productcard1
            // 
            this.productcard1.date = "$Price $Price $Price $Price $Price $Price $Price $Price $Price $Price $Price $Pri" +
    "ce $Price $Price DateDateDateDateDateDateDateDateDateDate";
            this.productcard1.Location = new System.Drawing.Point(3, 3);
            this.productcard1.Name = "productcard1";
            this.productcard1.price = "Date Date Date Date Date Date Date Date Date Date Date Date Date Date $Price$Pric" +
    "e$Price$Price$Price$Price$Price$Price$Price$Price";
            this.productcard1.Size = new System.Drawing.Size(598, 250);
            this.productcard1.TabIndex = 0;
            this.productcard1.title = "Title Title Title Title Title Title Title Title Title Title Title Title Title Tit" +
    "le TitleTitleTitleTitleTitleTitleTitleTitleTitleTitle";
            // 
            // DisplayFromDbform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayFromDbform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DisplayFromDbform";
            this.Load += new System.EventHandler(this.DisplayFromDbform_Load);
            this.display_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel display_panel;
        private productcard productcard1;
    }
}