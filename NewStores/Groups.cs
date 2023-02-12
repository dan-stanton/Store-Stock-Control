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
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;


        private void Groups_Load(object sender, EventArgs e)
        {
            searchData("");
            if (GlobalString.IsUserAdmin == 1) groupBox1.Visible = true;
        }

        public void searchData(string valueToSearch)
        {
            string query;
            if (!Deleted.Checked) query = "SELECT GroupID, GroupName FROM Groups WHERE Disabled = 0";
            else query = "SELECT * FROM Groups";
            command = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            searchData("");
        }

        private void Create_Click(object sender, EventArgs e)
        {
            using (createGroup form = new createGroup())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
            }
        }

        private void Deleted_CheckedChanged(object sender, EventArgs e)
        {
            searchData("");
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            using (EditGroup form = new EditGroup())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            using (DelGroup form = new DelGroup())
            {
                form.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                form.ShowDialog();
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
                using (EditGroup form = new EditGroup())
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
