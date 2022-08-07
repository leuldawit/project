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
    public partial class updateform : Form
    {
        int selectedRow=0;
        public updateform()
        {
            InitializeComponent();
        }

        private void updateform_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            product p = new product();

            /*double price = Convert.ToDouble(namesearch_txt.Text);
            SearchDataGridView.DataSource = null;
            SearchDataGridView.DataSource = product.findbyPrice(price);

        */
            string name = namesearch_txt.Text;
           // SearchDataGridView.DataSource = null;
            SearchDataGridView.DataSource = product.findbyname(name);
        }

        private void SearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            number_txt.Text = SearchDataGridView.CurrentRow.Cells[0].Value.ToString();
            name_txt.Text = SearchDataGridView.CurrentRow.Cells[3].Value.ToString();
            count_txt.Text = SearchDataGridView.CurrentRow.Cells[4].Value.ToString();
            price_txt.Text = SearchDataGridView.CurrentRow.Cells[5].Value.ToString();
            in_txt.Text = SearchDataGridView.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            product p = new product(); 
            DataGridViewRow newdata = SearchDataGridView.Rows [selectedRow];
            newdata.Cells[0].Value = number_txt.Text;
            newdata.Cells[1].Value = dateTimePicker1.Value;
            newdata.Cells[2].Value = in_txt.Text;
            newdata.Cells[3].Value = name_txt.Text;
            newdata.Cells[4].Value = count_txt.Text;
            newdata.Cells[5].Value = Convert.ToDouble(price_txt.Text);

            /*p.number=number_txt.Text;
            p.date = dateTimePicker1.Value;
            p.inventoryNumber = in_txt.Text;
            p.objectname = name_txt.Text;
            p.count = count_txt.Text;
            p.price = Convert.ToDouble(price_txt.Text);
            p.save();
        */}

        private void price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inventorynum_lbl_Click(object sender, EventArgs e)
        {

        }

        private void price_lbl_Click(object sender, EventArgs e)
        {

        }

        private void objname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void count_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Number_lbl_Click(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void in_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void count_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void namesearch_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
