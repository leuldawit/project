using assignment_4.Model;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            display_panel.Controls.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Lavender;
            panel1.Top = 140;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Red;
            panel1.Top = 170;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Teal;
          
            display_panel.Controls.Clear();
            foreach (var item in product.getallproducts())
            {
                productcard pc = new productcard();


                pc.title = item.objectname;
                pc.date = item.date.ToString();
                pc.price = item.price.ToString();

                display_panel.Controls.Add(pc);
            }
            


        }
       

            private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productcard1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productcard pc = new productcard();
            display_panel.Controls.Clear();
            foreach (var item in product.getallproducts())
            {


                pc.title = item.objectname;
                pc.date = item.date.ToString();
                pc.price = item.price.ToString();

                display_panel.Controls.Add(pc);
            }
        }
    }
}
