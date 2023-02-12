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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
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
            if (!Deleted.Checked) query = "SELECT Products.ProductID, Products.Item, Products.Stock, Products.Price, Groups.GroupName, Suppliers.SupplierName FROM Products LEFT OUTER JOIN Groups ON Products.grpid = Groups.GroupID LEFT OUTER JOIN Suppliers ON Products.Supplier = Suppliers.SupplierID WHERE CONCAT(Products.ProductID, Products.Item, Groups.GroupName, Suppliers.SupplierName) LIKE '%" + valueToSearch + "%' AND Products.Disabled = 0";
            else query = "SELECT Products.ProductID, Products.Item, Products.Stock, Products.Price, Groups.GroupName, Suppliers.SupplierName FROM Products LEFT OUTER JOIN Groups ON Products.grpid = Groups.GroupID LEFT OUTER JOIN Suppliers ON Products.Supplier = Suppliers.SupplierID WHERE CONCAT(Products.ProductID, Products.Item, Groups.GroupName, Suppliers.SupplierName) LIKE '%" + valueToSearch + "%'";
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

        private void Deleted_CheckedChanged(object sender, EventArgs e)
        {
            SearchText.Text = "";
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
            using (EditItm stack = new EditItm())
            {
                stack.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                stack.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalString.IsUserAdmin == 1)
            {
                int selected_index = dataGridView1.CurrentCell.RowIndex + 1;
                dataGridView1.CurrentCell = dataGridView1.Rows[selected_index - 1].Cells[1];
                GlobalString.selected_product_id = (string)dataGridView1.CurrentCell.Value;
                // MessageBox.Show("selected_index = " + selected_index+ " selected_product_id = " + GlobalString.selected_product_id);
                using (EditItm form = new EditItm())
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
