using assignment_4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class productcard : UserControl
    {
        public String title
        {
            get { return lbl_title.Text; }
            set { lbl_title.Text +=" "+ value; }
        }
        public String price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text += " "+value; }

        }
        public String date
        {
            get { return lbl_date.Text; }
            set { lbl_date.Text +=" "+ value; }
        }
        public productcard()
        {
            InitializeComponent();
        }

            public productcard(String name,string price,string date)
        {
            InitializeComponent();
            /*InitializeComponent();
            */
            this.title = name;
            this.price = price;
            this.date = date;

        }

        private void productcard_Load(object sender, EventArgs e)
        {
         
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
