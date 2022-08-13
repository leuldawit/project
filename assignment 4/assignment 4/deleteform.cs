using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment_4.Model;

namespace assignment_4
{
    public partial class deleteform : Form
    {
        int selectedRow=0;
        public deleteform()
        {
            InitializeComponent();
        }

      

        private void SearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SearchDataGridView.DataSource = product.findbyname(namesearch_txt.Text);
        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {
          
            product p = new product();
            DataGridViewRow newdata = SearchDataGridView.Rows[selectedRow];
            newdata.Cells[0].Value = "";
            newdata.Cells[1].Value = "";
            newdata.Cells[2].Value = "";
            newdata.Cells[3].Value = "";
            newdata.Cells[4].Value = "";
            newdata.Cells[5].Value = "";
        }
    }
}
