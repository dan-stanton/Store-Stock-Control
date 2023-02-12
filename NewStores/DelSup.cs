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
    public partial class DelSup : Form
    {
        public DelSup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;

        private void Description_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Delete.Text))
            {
                text.Text = "Nothing Found";
            }
            else
            {
                string valueToSearch = Delete.Text.ToString();
                searchData(valueToSearch);
            }
        }


        public void searchData(string valueToSearch)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT SupplierName FROM Suppliers WHERE CONCAT(SupplierName, SupplierID) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(0);
                    text.Text = temp;
                }
            }
            else
            {
                text.Text = "Nothing Found";
            }
            //reader.Close();
            //con.Close();
        }

        private void Delete_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Delete.Text) || Delete.Equals("Nothing Found"))
            {
                e.Cancel = true;
                Delete.Focus();
                errorProvider.SetError(Delete, "Please enter a description");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(Delete, null);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Delete.Text))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                string query = "UPDATE Suppliers SET Disabled = 1 WHERE SupplierName = '" + text.Text + "'";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                //reader.Close();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Delete', 'Supplier " + text.Text + " has been deleted by " + GlobalString.CurrentUsername + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                //con.Close();
                this.Close();
            }
        }
    }
}
