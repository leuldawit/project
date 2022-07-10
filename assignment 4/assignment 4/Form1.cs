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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butn_add_Click(object sender, EventArgs e)
        {
           product p = new product();
            p.number = text_number.Text;
            p.date = dateTimePicker1.Value;
            p.inventoryNumber =text_IN.Text;
            p.objectname = text_objectname.Text;
            p.count = text_count.Text;
            p.price = text_price.Text;

            p.save(p);
            MessageBox.Show($"Item Has been Added! \n Item number: " +
                $"{p.number}\n " +
                $"Item date: {p.date}\n " +
                $"Inventory number: {p.inventoryNumber}\n " +
                $"Item name: {p.objectname}\n " +
                $"Quantity: {p.count}\n " +
                $"Price: {p.price} ");


        }

        private void butn_canel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butn_reset_Click(object sender, EventArgs e)
        {
              text_number.Text="";
            dateTimePicker1.Value =DateTime.Now;
           text_IN.Text = "";
            text_objectname.Text =  "";
          text_count.Text = "";
           text_price.Text = "";
        }
    }
}
