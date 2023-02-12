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
    public partial class SendQuery : Form
    {
        public SendQuery()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"" + GlobalString.SqlDataSource + "");
        SqlCommand command;

        private void SendQuery_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = QueryText.Text;
            command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            button6.Enabled = false;
        }
    }
}
