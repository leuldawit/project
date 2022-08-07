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
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
            if(ActiveMdiChild != null)
            {
               ActiveMdiChild.Close();  
            }

            else {
                Form1 form = new Form1();
                form.MdiParent = this;
                form.Show();
            }

            /* loginform loginform = new loginform();
             loginform.Show();*/

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            else
            {
                updateform update = new updateform();
                update.MdiParent = this;
                update.Show();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            else
            {
                deleteform delete = new deleteform();
                delete.MdiParent = this;
                delete.Show();
            }
        }
    }
}
