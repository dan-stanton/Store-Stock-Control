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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace NewStores
{
    public partial class EditItm : Form
    {
        public EditItm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource +"");
        SqlCommand command;
        SqlCommand tempcmd;

        string imgLoc = "";


        private void Delete_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Delete.Text))
            {
                text.Text = "Nothing Found";
                Price.Enabled = false;
                Price.Text = "";
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                Description.Enabled = false;
                Description.Text = "";
                checkBox1.Checked = false; 
                comboBox1.SelectedIndex = -1;
                comboBox1.Enabled = false;
                comboBox2.SelectedIndex = -1;
                comboBox2.Enabled = false;
                SelectPic.Enabled = false;
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
            query = "SELECT Item, Stock, Price, Disabled, Supplier, grpid, LowStock, Picture, SupplierRef FROM Products WHERE CONCAT(ProductID, Item) LIKE '%" + valueToSearch + "%' ORDER BY ProductID";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(0);
                    text.Text = temp;
                    Description.Enabled = true;
                    Description.Text = temp;

                    int temp2 = Convert.ToInt32(reader.GetInt32(1));
                    numericUpDown1.Enabled = true;
                    numericUpDown1.Value = temp2;

                    decimal temp3 = reader.GetDecimal(2);
                    Price.Text = temp3.ToString();
                    Price.Enabled = true;

                    int temp4 = Convert.ToInt32(reader.GetInt32(3));
                    checkBox1.Enabled = true;
                    if (temp4 == 1) checkBox1.Checked = true;
                    else checkBox1.Checked = false;

                    comboBox1.Enabled = true;
                    comboBox1.SelectedIndex = reader.GetInt32(4)-1;

                    comboBox2.Enabled = true;
                    comboBox2.SelectedIndex = reader.GetInt32(5)-1;

                    int temp5 = Convert.ToInt32(reader.GetInt32(6));
                    numericUpDown2.Enabled = true;
                    numericUpDown2.Value = temp5;

                    if (!Convert.IsDBNull(reader[7]))
                    {
                        byte[] img = (byte[])reader[7];
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
                    SelectPic.Enabled = true;// load pic!

                    temp = reader.GetString(8);
                    SuppCode.Text = temp;
                    SuppCode.Enabled = true;
                }
            }
            else
            {
                text.Text = "Nothing Found";
                Price.Enabled = false;
                Price.Text = "";
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                Description.Enabled = false;
                Description.Text = "";
                checkBox1.Checked = false;
                comboBox1.SelectedIndex = -1;
                comboBox1.Enabled = false;
                comboBox2.SelectedIndex = -1;
                comboBox2.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
                pictureBox1.Image = Properties.Resources.nopic;
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                SelectPic.Enabled = false;
                SuppCode.Text = "";
                SuppCode.Enabled = false;



            }
            //reader.Close();
            //con.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Delete.Text))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int temp;
                if (checkBox1.Checked) temp = 1;
                else temp = 0;

                string query;
                if (!String.IsNullOrEmpty(imgLoc))
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    query = "UPDATE Products SET Picture = @img, LowStock = '" + numericUpDown2.Value + "', grpid = '" + comboBox2.SelectedValue + "', Supplier = '" + comboBox1.SelectedValue + "', Item = '" + Description.Text + "', Stock = '" + numericUpDown1.Value + "', Price = '" + Price.Text + "', Disabled = '" + temp + "' WHERE Item = '" + text.Text + "'";
                    tempcmd = new SqlCommand(query, con);
                    tempcmd.Parameters.Add(new SqlParameter("@img", img));

                }
                else
                {
                    query = "UPDATE Products SET LowStock = '" + numericUpDown2.Value + "', grpid = '" + comboBox2.SelectedValue + "', Supplier = '" + comboBox1.SelectedValue + "', Item = '" + Description.Text + "', Stock = '" + numericUpDown1.Value + "', Price = '" + Price.Text + "', Disabled = '" + temp + "' WHERE Item = '" + text.Text + "'";
                    tempcmd = new SqlCommand(query, con);
                }
                SqlDataReader reader = tempcmd.ExecuteReader();
                tempcmd.Parameters.Clear();


                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Edit', 'Item " + Description.Text + " has been edited by " + GlobalString.CurrentUsername + "')";
                tempcmd = new SqlCommand(query1, con);
                SqlDataReader reader1 = tempcmd.ExecuteReader();
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EditItm_Load(object sender, EventArgs e)
        {
            imgLoc = "";
            string query2 = "SELECT SupplierName, SupplierID FROM Suppliers ORDER BY SupplierID";
            SqlDataAdapter da = new SqlDataAdapter(query2, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "comboBox1");
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "SupplierID";
            comboBox1.DataSource = ds.Tables["comboBox1"];
            comboBox1.SelectedIndex = -1;

            string query23 = "SELECT GroupName, GroupID FROM Groups ORDER BY GroupID";
            SqlDataAdapter daa = new SqlDataAdapter(query23, con);
            DataSet dss = new DataSet();
            daa.Fill(dss, "comboBox2");
            comboBox2.DisplayMember = "GroupName";
            comboBox2.ValueMember = "GroupID";
            comboBox2.DataSource = dss.Tables["comboBox2"];
            comboBox2.SelectedIndex = -1;

            if (!(String.IsNullOrEmpty(GlobalString.selected_product_id)))
            {
                Delete.Text = GlobalString.selected_product_id;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                pictureBox1.Image = Image.FromFile(path);
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                imgLoc = file.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;

            }
        }
    }
}
