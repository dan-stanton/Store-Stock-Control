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
    public partial class EditGroup : Form
    {
        public EditGroup()
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
                string query = "UPDATE Groups SET GroupName = '" + SupName.Text + "', Disabled = '" + temp + "' WHERE GroupName = '" + text.Text + "'";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                //reader.Close();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Edit', 'Group " + SupName.Text + " has been edited by " + GlobalString.CurrentUsername + "')";
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
            query = "SELECT * FROM Groups WHERE CONCAT(GroupID, GroupName) LIKE '%" + valueToSearch + "%'";
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


                    int temp5 = reader.GetInt32(2);
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
                checkBox1.Checked = false;
            }
            //reader.Close();
            //con.Close();
        }

        private void EditGroup_Load(object sender, EventArgs e)
        {
            Search.Text = GlobalString.selected_product_id;
        }
    }
}
