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
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;

        private void LogsForm_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        public void searchData(string valueToSearch)
        {
            string query;
            query = "SELECT TOP "+ Limiter.Value +" LogDate, LogType, LogDetails, WVD, monies FROM Logs WHERE CONCAT(LogDate, LogType, LogDetails, WVD) LIKE '%" + valueToSearch + "%' ORDER BY LogID DESC";
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

        private void Search_Click(object sender, EventArgs e)
        {
            string valueToSearch = SearchText.Text.ToString();
            searchData(valueToSearch);
        }

        private void Unlimited_CheckedChanged(object sender, EventArgs e)
        {
            if (Unlimited.Checked)
            {
                Limiter.Enabled = false;
                Limiter.Value = 999999999;
            }
            else
            {
                Limiter.Enabled = true;
                Limiter.Value = 100;
            }
        }

        private void Limiter_ValueChanged(object sender, EventArgs e)
        {
            searchData("");
        }

        private void calc_Click(object sender, EventArgs e)
        {
            int countRow = dataGridView1.Rows.Count;
            decimal value = 0;
            for (int i = 0; i < countRow; i++)
            {
                value = value + (decimal)dataGridView1.Rows[i].Cells[4].Value;
            }
            total.Text = ""+ value + "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
