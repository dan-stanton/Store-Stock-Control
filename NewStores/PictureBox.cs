using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewStores
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"" + GlobalString.SqlDataSource + "");
        SqlCommand command;
        private void PictureBox_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT Picture, Item FROM Products WHERE ProductID = '" + GlobalString.selected_product_id + "'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        byte[] img = (byte[])reader[0];
                        if (img == null)
                        {
                            pictureBox1.Image = Properties.Resources.nopic;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.nopic;
                    }
                    this.Text = reader.GetString(1);
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.nopic;
                pictureBox1.Refresh();
                pictureBox1.Visible = true;

            }
        }
    }
}
