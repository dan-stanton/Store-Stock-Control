using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewStores
{
    public partial class CreateSup : Form
    {
        public CreateSup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;

        private void CreateSup_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query = "SELECT TOP 1 SupplierID FROM Suppliers ORDER BY SupplierID DESC";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int sum = reader.GetInt32(0) + 1;
                    this.Text = "Creating supplier number - " + sum + "";
                }
            }
            else
            {
                this.Text = "Creating supplier number - error";
            }
            //reader.Close();
            //con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(SupName.Text)))//another double negative
            {
                if (con.State == ConnectionState.Closed) con.Open();
                string query = "INSERT INTO Suppliers (SupplierName, SupplierAddress, SupplierEmail, SupplierPhone, Disabled) VALUES('" + SupName.Text + "', '" + Address.Text + "', '" + Email.Text + "', '" + Phone.Text + "', 0)";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                //reader.Close();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Create', 'Supplier " + SupName.Text + " has been created by " + GlobalString.CurrentUsername + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                //con.Close();
                this.Close();
            }
        }

    }
}
