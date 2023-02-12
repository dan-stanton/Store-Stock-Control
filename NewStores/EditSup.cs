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
    public partial class EditSup : Form
    {
        public EditSup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Search.Text))
            {
                text.Text = "Nothing Found";
                SupName.Enabled = false;
                SupName.Text = "";
                Address.Enabled = false;
                Address.Text = "";
                Email.Enabled = false;
                Email.Text = "";
                Phone.Enabled = false;
                Phone.Text = "";
                checkBox1.Checked = false;
            }
            else
            {
                string valueToSearch = Search.Text.ToString();
                searchData(valueToSearch);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Search.Text))
            {
                int temp;
                if (checkBox1.Checked) temp = 1;
                else temp = 0;
                if (con.State == ConnectionState.Closed) con.Open();
                string query = "UPDATE Suppliers SET SupplierName = '" + SupName.Text + "', SupplierAddress = '" + Address.Text + "', SupplierEmail = '" + Email.Text + "', Disabled = '" + temp + "', SupplierPhone = '"+Phone.Text+"' WHERE SupplierName = '" + text.Text + "'";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                //reader.Close();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Edit', 'Supplier " + SupName.Text + " has been edited by " + GlobalString.CurrentUsername + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                //con.Close();
                this.Close();
            }
        }






        public void searchData(string valueToSearch)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Suppliers WHERE CONCAT(SupplierName, SupplierAddress, SupplierID, SupplierPhone, SupplierEmail) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(1);
                    text.Text = temp;
                    SupName.Enabled = true;
                    SupName.Text = temp;

                    string temp2 = reader.GetString(2);
                    Address.Enabled = true;
                    Address.Text = temp2;

                    string temp3 = reader.GetString(3);
                    Email.Enabled = true;
                    Email.Text = temp3;

                    string temp4 = reader.GetString(4);
                    Phone.Enabled = true;
                    Phone.Text = temp4;

                    int temp5 = Convert.ToInt32(reader.GetInt32(5));
                    checkBox1.Enabled = true;
                    if (temp5 == 1) checkBox1.Checked = true;
                    else checkBox1.Checked = false;

                }
            }
            else
            {
                text.Text = "Nothing Found";
                SupName.Enabled = false;
                SupName.Text = "";
                Address.Enabled = false;
                Address.Text = "";
                Email.Enabled = false;
                Email.Text = "";
                Phone.Enabled = false;
                Phone.Text = "";
                checkBox1.Checked = false;
            }
            //reader.Close();
            //con.Close();
        }

        private void EditSup_Load(object sender, EventArgs e)
        {
            Search.Text = GlobalString.selected_product_id;
        }
    }
}
