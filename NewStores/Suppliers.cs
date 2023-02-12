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

namespace NewStores
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            searchData("");
            if (GlobalString.IsUserAdmin == 1) groupBox1.Visible = true;
        }




        private void Search_Click(object sender, EventArgs e)
        {
            string valueToSearch = SearchText.Text.ToString();
            searchData(valueToSearch);
        }


        public void searchData(string valueToSearch)
        {
            string query;
            if (!Deleted.Checked) query = "SELECT SupplierID, SupplierName, SupplierAddress, SupplierEmail, SupplierPhone FROM Suppliers WHERE CONCAT(SupplierID, SupplierName, SupplierAddress, SupplierEmail, SupplierPhone) LIKE '%" + valueToSearch + "%' AND Disabled = 0";
            else query = "SELECT * FROM Suppliers WHERE CONCAT(SupplierID, SupplierName, SupplierAddress, SupplierEmail, SupplierPhone) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }


        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchText.Text)) Search.Enabled = false;
            else Search.Enabled = true;
            searchData("");
        }

        private void Create_Click(object sender, EventArgs e)
        {
            using (CreateItem createItem = new CreateItem())
            {
                createItem.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                createItem.ShowDialog();
            }
        }
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            searchData("");
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            using (DelItem delItem = new DelItem())
            {
                delItem.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                delItem.ShowDialog();
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            using (EditItm form = new EditItm())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
            }
        }

        private void Create_Click_1(object sender, EventArgs e)
        {
            using (CreateSup form = new CreateSup())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
            }
        }

        private void Deleted_CheckedChanged_1(object sender, EventArgs e)
        {
            SearchText.Text = "";
            searchData("");
        }

        private void DeleteItem_Click_1(object sender, EventArgs e)
        {
            using (DelSup form = new DelSup())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
            }
        }

        private void EditItem_Click_1(object sender, EventArgs e)
        {
            using (EditSup form = new EditSup())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
            }
        }

        private void SearchText_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchText.Text)) Search.Enabled = false;
            else Search.Enabled = true;
            searchData("");
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            string valueToSearch = SearchText.Text.ToString();
            searchData(valueToSearch);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalString.IsUserAdmin == 1)
            {
                int selected_index = dataGridView1.CurrentCell.RowIndex + 1;
                dataGridView1.CurrentCell = dataGridView1.Rows[selected_index - 1].Cells[1];
                GlobalString.selected_product_id = (string)dataGridView1.CurrentCell.Value;
                // MessageBox.Show("selected_index = " + selected_index+ " selected_product_id = " + GlobalString.selected_product_id);
                using (EditSup form = new EditSup())
                {
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You must be an administrator to use this feature.", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
