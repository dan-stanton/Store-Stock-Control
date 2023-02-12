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
    public partial class CreateItem : Form
    {
        public CreateItem()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;

        private void CreateItem_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();

            string query2 = "SELECT SupplierName, SupplierID FROM Suppliers";
            SqlDataAdapter da = new SqlDataAdapter(query2, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "comboBox1");
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "SupplierID";
            comboBox1.DataSource = ds.Tables["comboBox1"];
            comboBox1.SelectedIndex = -1;

            string query3 = "SELECT GroupName, GroupID FROM Groups";
            SqlDataAdapter daa = new SqlDataAdapter(query3, con);
            DataSet dss = new DataSet();
            daa.Fill(dss, "comboBox2");
            comboBox2.DisplayMember = "GroupName";
            comboBox2.ValueMember = "GroupID";
            comboBox2.DataSource = dss.Tables["comboBox2"];
            comboBox2.SelectedIndex = -1;


            string query = "SELECT TOP 1 ProductID FROM Products ORDER BY ProductID DESC";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int sum = reader.GetInt32(0)+1;
                    this.Text = "Creating item number - " + sum + "";
                }
            }
            else
            {
                this.Text = "Creating item number - error";
            }
            //reader.Close();
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(Description.Text) || String.IsNullOrEmpty(Price.Text)))//another double negative
            {
                if (con.State == ConnectionState.Closed) con.Open();
                string query = "INSERT INTO Products (Item, Stock, Price, Supplier, grpid, LowStock, Disabled, SupplierRef) VALUES('" + Description.Text + "', '" + numericUpDown1.Value + "', '" + Price.Text + "', '"+comboBox1.SelectedValue + "', '" + comboBox2.SelectedValue+"', '"+LowWarn.Value+"', 0, '"+ SuppCode.Text+"')";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                //reader.Close();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Create', 'Product " + Description.Text + " has been created by " + GlobalString.CurrentUsername + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                //con.Close();
                this.Close();

            }
        }

        private void Description_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(Description.Text))
            {
                e.Cancel = true;
                Description.Focus();
                errorProvider.SetError(Description, "Please enter a description");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(Description, null);
            }
        }

        public bool ValidateCurrency(string price, string cultureCode)
        {
            decimal test;
            return decimal.TryParse
               (price, NumberStyles.Currency, new CultureInfo(cultureCode), out test);
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateCurrency(Price.Text, "en-GB"))
            {
                e.Cancel = true;
                Price.Focus();
                errorProvider.SetError(Price, "Please enter a valid currency");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(Price, null);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
