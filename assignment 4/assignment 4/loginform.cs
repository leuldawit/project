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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (password_txt.Text == "admin" && username_txt.Text == "admin")
            {
                Form1 screen = new Form1(username_txt.Text);
                screen.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("invalid password");
            }
           
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
