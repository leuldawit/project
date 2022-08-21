using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class DetailPage : Form
    {
        public String title
        {
            get { return lbl_title.Text; }
            set { lbl_title.Text =  value; }
        }
        public String price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }

        }
        public String date
        {
            get { return lbl_date.Text; }
            set { lbl_date.Text = value; }
        }
        public string number 
        { 
            get { return lbl_number.Text; }
            set { lbl_number.Text = value; }
                }
        public string inventoryNumber 
        {
            get { return lbl_in.Text; }
            set { lbl_in.Text = value; }
        }
        public string count 
        {
            get { return lbl_count.Text; }
            set { lbl_count.Text = value; }
        }

        public DetailPage()
        {
            InitializeComponent();
        }
       
        private void DetailPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
