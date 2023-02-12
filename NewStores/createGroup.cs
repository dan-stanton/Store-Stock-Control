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
    public partial class createGroup : Form
    {
        public createGroup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;

        private void Create_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)))//another double negative
            {
                if (con.State == ConnectionState.Closed) con.Open();
                string query = "INSERT INTO Groups (GroupName, Disabled) VALUES('" + textBox1.Text + "', 0)";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                //reader.Close();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Create', 'Group " + textBox1.Text + " has been created by "+ GlobalString.CurrentUsername+"')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                //con.Close();
                this.Close();
            }
        }

        private void createGroup_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query = "SELECT TOP 1 GroupID FROM Groups ORDER BY GroupID DESC";
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
    }
}
