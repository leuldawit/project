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
    public partial class AddToDBform : Form
    {
        
        public AddToDBform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product p=new product();

            p.PID = Convert.ToInt32(textBox1.Text);;
            p.date = dateTimePicker1.Value;
            p.objectname=textBox2.Text;
            p.price = Convert.ToInt32(textBox3.Text);    
            p.save(); 
           
        }

        private void AddToDBform_Load(object sender, EventArgs e)
        {

        }
    }
}
