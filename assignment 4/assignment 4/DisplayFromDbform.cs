using assignment_4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class DisplayFromDbform : Form
    {

        public int PID { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        List<product> temp = new List<product>();

        public DisplayFromDbform()
        {
            InitializeComponent();
        }

        private void productcard1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayFromDbform_Load(object sender, EventArgs e)
        {

            
            temp=product.getallproducts();
               display_panel.Controls.Clear();
            foreach (var item in temp)
            {
                productcard pc = new productcard();
                pc.title = item.objectname;
                pc.date = item.date.ToString();
                pc.price = item.price.ToString();
                display_panel.Controls.Add(pc);


            }
        }

    }
}
