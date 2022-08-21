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

        private void label1_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Lavender;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PaleGoldenrod;
          
        }


        private void label3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
            

        }


        private void Form2_Load(object sender, EventArgs e)
        
        {
           
            display_panel.Controls.Clear();
            foreach (var item in product.getallproducts())
            {

                /* productcard pc = new productcard(item.objectname, item.date.ToString(), item.price.ToString());
                */productcard pc = new productcard();
                pc.title = item.objectname;
                pc.date = item.date.ToString();
                pc.price = item.price.ToString();
                /* pc.Click += productcard_click;
                */
                pc.Click += (object o, EventArgs e2) =>
                {
                    /*MessageBox.Show(pc.title);
                    */
                    DetailPage dp = new DetailPage();
                    dp.title =item.objectname;
                    dp.date = item.date.ToString();
                    dp.price = item.price.ToString();
                    dp.number=item.number.ToString();
                    dp.count=item.count.ToString(); 
                    dp.inventoryNumber=item.inventoryNumber.ToString();
                    dp.Show();
                };

                display_panel.Controls.Add(pc);
            }
        }
        private void productcard_click (object o, EventArgs e)
        {
            MessageBox.Show("custom clicked");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productcard1_Load(object sender, EventArgs e)
        {

        }

        private void display_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
