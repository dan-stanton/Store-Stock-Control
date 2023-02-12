using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace NewStores
{
    public partial class NewEntry : Form
    {
        SqlConnection con = new SqlConnection(@""+ GlobalString.SqlDataSource+"");
        SqlCommand command;
        bool dodemostuff;
        int temp2;
        private bool hassomethingbeenlogged;

        int searching;

        public NewEntry()
        {
            InitializeComponent();
        }
        private void NewEntry_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = GlobalString.sqlrtf;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (con.State == ConnectionState.Closed) con.Open();
            string query = string.Empty;
            string addorremove = string.Empty;
            if (con.State == ConnectionState.Closed) con.Open();

            if (checkBox1.Checked && checkBox2.Checked == false)
            {
                //newstock = (int)(temp2 + numericUpDown1.Value);
                addorremove = "Added";
                dodemostuff = false;
            }
            else if (checkBox2.Checked && checkBox1.Checked == false)
            {
                //newstock = (int)(temp2 - numericUpDown1.Value);
                addorremove = "Removed";
                dodemostuff = true;
            }
            else 
            {
                DialogResult msgbox;
                msgbox = MessageBox.Show("Please choose if you're removing or adding the items.", "Record", MessageBoxButtons.OK);
                return;
            }

            if (String.IsNullOrEmpty(Notes.Text))//another double negative
            {
                DialogResult msgbox;
                msgbox = MessageBox.Show("Please insert some notes", "Record", MessageBoxButtons.OK);
                return;
            }

            if (!(String.Equals(Item1.Text, "Nothing Found")))
            {
                if(numericUpDown1.Value == 0)
                {
                    DialogResult msgbox;
                    msgbox = MessageBox.Show("Please add a quantity", "Record", MessageBoxButtons.OK);
                    return;
                }
                query = "SELECT Stock FROM Products WHERE Item = '" + Item1.Text + "'";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        temp2 = Convert.ToInt32(reader.GetInt32(0));
                    }
                }

                decimal monies = GetItemValue(Item1.Text)* numericUpDown1.Value; // devide cus newstock = -value
                if (!dodemostuff)
                {
                    monies = 0;
                    WVD.Text = "";
                }

                string query20;
                if (dodemostuff)
                {
                    query20 = "UPDATE Products SET Stock = Stock - "+ numericUpDown1.Value +" WHERE Item = '" + Item1.Text + "'";
                }
                else
                {
                    query20 = "UPDATE Products SET Stock = Stock + " + numericUpDown1.Value + " WHERE Item = '" + Item1.Text + "'";
                    monies = 0;
                    WVD.Text = "";
                }
                command = new SqlCommand(query20, con);
                SqlDataReader reader0 = command.ExecuteReader();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails, WVD, monies) VALUES('" + System.DateTime.Now + "', '" + addorremove + "', 'x" + numericUpDown1.Value + " " + Item1.Text + " "+ addorremove +" by " + GlobalString.CurrentUsername + " Notes: " + Notes.Text + "', '" + WVD.Text + "', '"+ monies+"')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader1 = command.ExecuteReader();
                hassomethingbeenlogged = true;


            }

            if (!String.Equals(Item2.Text, "Nothing Found"))
            {
                if (numericUpDown2.Value == 0)
                {
                    DialogResult msgbox;
                    msgbox = MessageBox.Show("Please add a quantity", "Record", MessageBoxButtons.OK);
                    return;
                }


                decimal monies = GetItemValue(Item2.Text) * numericUpDown2.Value; // devide cus newstock = -value
                if (!dodemostuff)
                {
                    monies = 0;
                    WVD.Text = "";
                }

                string query20;
                if (dodemostuff)
                {
                    query20 = "UPDATE Products SET Stock = Stock - " + numericUpDown2.Value + " WHERE Item = '" + Item2.Text + "'";
                }
                else
                {
                    query20 = "UPDATE Products SET Stock = Stock + " + numericUpDown2.Value + " WHERE Item = '" + Item2.Text + "'";
                    monies = 0;
                    WVD.Text = "";
                }


                command = new SqlCommand(query20, con);
                SqlDataReader reader2 = command.ExecuteReader();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails, WVD, monies) VALUES('" + System.DateTime.Now + "', '" + addorremove + "', 'x" + numericUpDown2.Value + " " + Item2.Text + " " + addorremove + " by " + GlobalString.CurrentUsername + " Notes: " + Notes2.Text + "', '" + WVD.Text + "', '" + monies + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader3 = command.ExecuteReader();
            }

            if (!String.Equals(Item3.Text, "Nothing Found"))
            {
                if (numericUpDown3.Value == 0)
                {
                    DialogResult msgbox;
                    msgbox = MessageBox.Show("Please add a quantity", "Record", MessageBoxButtons.OK);
                    return;
                }
                decimal monies = GetItemValue(Item3.Text) * numericUpDown3.Value; // devide cus newstock = -value
                if (!dodemostuff)
                {
                    monies = 0;
                    WVD.Text = "";
                }

                string query20;
                if (dodemostuff)
                {
                    query20 = "UPDATE Products SET Stock = Stock - " + numericUpDown3.Value + " WHERE Item = '" + Item3.Text + "'";
                }
                else
                {
                    query20 = "UPDATE Products SET Stock = Stock + " + numericUpDown3.Value + " WHERE Item = '" + Item3.Text + "'";
                    monies = 0;
                    WVD.Text = "";
                }
                command = new SqlCommand(query20, con);
                SqlDataReader reader2 = command.ExecuteReader();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails, WVD, monies) VALUES('" + System.DateTime.Now + "', '" + addorremove + "', 'x" + numericUpDown3.Value + " " + Item3.Text + " " + addorremove + " by " + GlobalString.CurrentUsername + " Notes: " + Notes3.Text + "', '" + WVD.Text + "', '" + monies + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader3 = command.ExecuteReader();
            }

            if (!String.Equals(Item4.Text, "Nothing Found"))
            {
                if (numericUpDown4.Value == 0)
                {
                    DialogResult msgbox;
                    msgbox = MessageBox.Show("Please add a quantity", "Record", MessageBoxButtons.OK);
                    return;
                }
                decimal monies = GetItemValue(Item4.Text) * numericUpDown4.Value; // devide cus newstock = -value
                if (!dodemostuff)
                {
                    monies = 0;
                    WVD.Text = "";
                }

                string query20;
                if (dodemostuff)
                {
                    query20 = "UPDATE Products SET Stock = Stock - " + numericUpDown4.Value + " WHERE Item = '" + Item4.Text + "'";
                }
                else
                {
                    query20 = "UPDATE Products SET Stock = Stock + " + numericUpDown4.Value + " WHERE Item = '" + Item4.Text + "'";
                    monies = 0;
                    WVD.Text = "";
                }
                command = new SqlCommand(query20, con);
                SqlDataReader reader2 = command.ExecuteReader();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails, WVD, monies) VALUES('" + System.DateTime.Now + "', '" + addorremove + "', 'x" + numericUpDown4.Value + " " + Item4.Text + " " + addorremove + " by " + GlobalString.CurrentUsername + " Notes: " + Notes4.Text + "', '" + WVD.Text + "', '" + monies + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader3 = command.ExecuteReader();
            }

            if (!String.Equals(Item5.Text, "Nothing Found"))
            {
                if (numericUpDown5.Value == 0)
                {
                    DialogResult msgbox;
                    msgbox = MessageBox.Show("Please add a quantity", "Record", MessageBoxButtons.OK);
                    return;
                }
                decimal monies = GetItemValue(Item5.Text) * numericUpDown5.Value; // devide cus newstock = -value
                if (!dodemostuff)
                {
                    monies = 0;
                    WVD.Text = "";
                }

                string query20;
                if (dodemostuff)
                {
                    query20 = "UPDATE Products SET Stock = Stock - " + numericUpDown5.Value + " WHERE Item = '" + Item5.Text + "'";
                }
                else
                {
                    query20 = "UPDATE Products SET Stock = Stock + " + numericUpDown5.Value + " WHERE Item = '" + Item5.Text + "'";
                    monies = 0;
                    WVD.Text = "";
                }
                command = new SqlCommand(query20, con);
                SqlDataReader reader2 = command.ExecuteReader();
                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails, WVD, monies) VALUES('" + System.DateTime.Now + "', '" + addorremove + "', 'x" + numericUpDown5.Value + " " + Item5.Text + " " + addorremove + " by " + GlobalString.CurrentUsername + " Notes: " + Notes5.Text + "', '" + WVD.Text + "', '" + monies + "')";
                command = new SqlCommand(query1, con);
                SqlDataReader reader3 = command.ExecuteReader();
            }

            if (hassomethingbeenlogged)
            {
                DialogResult msgbox;
                msgbox = MessageBox.Show("Entry has been logged", "Record", MessageBoxButtons.OK);
                ResetLayout();
            }
            else 
            {
                DialogResult msgbox;
                msgbox = MessageBox.Show("Errors have been found, please review.", "Record", MessageBoxButtons.OK);
                return;
            }
        }

        private decimal GetItemValue(string item)
        {
            decimal rtnvalue = 0;
            string query = "SELECT TOP 1 Price FROM Products WHERE Item = '" + item + "' ORDER BY ProductID DESC";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rtnvalue = reader.GetDecimal(0);
                }
            }
            return rtnvalue;
        }

        private void ResetLayout()
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown4.Enabled = false;
            numericUpDown5.Value = 0;
            Notes.Text = "";
            Notes2.Text = "";
            Notes3.Text = "";
            Notes4.Text = "";
            Notes5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox3.Enabled = false;
            textBox4.Text = "";
            textBox4.Enabled = false;
            textBox5.Text = "";
            textBox5.Enabled = false;
            textBox6.Text = "";
            textBox6.Enabled = false;
            WVD.Text = "";
            Notes4.Enabled = false;

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Notes.Text))
            {
                //e.cancel = true;
                errorProvider.SetError(Notes, "Please enter some notes");
            }
            else
            {
                //e.cancel = false;
                errorProvider.SetError(Notes, null);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Enabled)
            {
                if (numericUpDown1.Value == 0)
                {
                    //e.cancel = true;
                    errorProvider.SetError(numericUpDown1, "Please add a quantity");
                }
                else
                {
                    //e.cancel = false;
                    errorProvider.SetError(numericUpDown1, null);
                }
            }
        }

        private void numericUpDown2_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown2.Enabled)
            {
                if (numericUpDown2.Value == 0)
                {
                    //e.cancel = true;
                    errorProvider.SetError(numericUpDown2, "Please add a quantity");
                }
                else
                {
                    //e.cancel = false;
                    errorProvider.SetError(numericUpDown2, null);
                }
            }
        }

        private void numericUpDown3_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown3.Enabled)
            {
                if (numericUpDown3.Value == 0)
                {
                    //e.cancel = true;
                    errorProvider.SetError(numericUpDown3, "Please add a quantity");
                }
                else
                {
                    //e.cancel = false;
                    errorProvider.SetError(numericUpDown3, null);
                }
            }
        }

        private void numericUpDown4_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown4.Enabled)
            {
                if (numericUpDown4.Value == 0)
                {
                    //e.cancel = true;
                    errorProvider.SetError(numericUpDown4, "Please add a quantity");
                }
                else
                {
                    //e.cancel = false;
                    errorProvider.SetError(numericUpDown4, null);
                }
            }
        }

        private void numericUpDown5_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown5.Enabled)
            {
                if (numericUpDown5.Value == 0)
                {
                    //e.cancel = true;
                    errorProvider.SetError(numericUpDown5, "Please add a quantity");
                }
                else
                {
                    //e.cancel = false;
                    errorProvider.SetError(numericUpDown5, null);
                }
            }
        }

        private void groupBox1_Validating(object sender, CancelEventArgs e)
        {
            if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                //e.cancel = true;
                errorProvider.SetError(groupBox1, "Are you taking our or putting in??");
            }
            else
            {
                //e.cancel = false;
                errorProvider.SetError(groupBox1, null);
            }
        }

        private void checkBox1_Validated(object sender, CancelEventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                //e.cancel = true;
                errorProvider.SetError(groupBox1, "Are you taking our or putting in??");
            }
            else
            {
                //e.cancel = false;
                errorProvider.SetError(groupBox1, null);
            }
        }

        private void checkBox2_Validating(object sender, CancelEventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                //e.cancel = true;
                errorProvider.SetError(groupBox1, "Are you taking our or putting in??");
            }
            else
            {
                //e.cancel = false;
                errorProvider.SetError(groupBox1, null);
            }
        }

        public void searchDataItem1(string valueToSearch)
        {
            similar.Text = "";
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Products WHERE CONCAT(ProductID, Item) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            searching = 1;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Item1.Text = reader.GetString(1);
                    similar.Text += reader.GetString(1) + "\n";
                    numericUpDown1.Enabled = true;
                    Notes.Enabled = true;
                }
            }
            else
            {
                Item1.Text = "Nothing Found";
                numericUpDown1.Enabled = false;
                Notes.Enabled = false;
            }
        }

        public void searchDataItem2(string valueToSearch)
        {
            searching = 2;
            similar.Text = "";
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Products WHERE CONCAT(ProductID, Item) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(1);
                    Item2.Text = temp;
                    numericUpDown2.Enabled = true;
                    Notes2.Enabled = true;
                    similar.Text += reader.GetString(1) + "\n";

                }
            }
            else
            {
                Item2.Text = "Nothing Found";
                numericUpDown2.Enabled = false;
                Notes2.Enabled = false;
            }
        }

        public void searchDataItem3(string valueToSearch)
        {
            searching = 3;
            similar.Text = "";
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Products WHERE CONCAT(ProductID, Item) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(1);
                    Item3.Text = temp;
                    numericUpDown3.Enabled = true;
                    Notes3.Enabled = true;
                    similar.Text += reader.GetString(1) + "\n";

                }
            }
            else
            {
                Item3.Text = "Nothing Found";
                numericUpDown3.Enabled = false;
                Notes3.Enabled = false;
            }
        }

        public void searchDataItem4(string valueToSearch)
        {
            searching = 4;
            similar.Text = "";
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Products WHERE CONCAT(ProductID, Item) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(1);
                    Item4.Text = temp;
                    numericUpDown4.Enabled = true;
                    Notes4.Enabled = true;
                    similar.Text += reader.GetString(1) + "\n";
                }
            }
            else
            {
                Item4.Text = "Nothing Found";
                numericUpDown4.Enabled = true;
                Notes4.Enabled = true;
                if (String.IsNullOrEmpty(textBox5.Text)) textBox6.Enabled = false;
            }
        }

        public void searchDataItem5(string valueToSearch)
        {
            searching = 5;
            similar.Text = "";
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Products WHERE CONCAT(ProductID, Item) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(1);
                    Item5.Text = temp;
                    numericUpDown5.Enabled = true;
                    Notes5.Enabled = true;
                    similar.Text += reader.GetString(1) + "\n";
                }
            }
            else
            {
                Item5.Text = "Nothing Found";
                numericUpDown5.Enabled = false;
                Notes5.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text)) searchDataItem1("THISneedsTOreturnNULL");
            else
            {
                string valueToSearch = textBox2.Text.ToString();
                searchDataItem1(valueToSearch);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text)) searchDataItem2("THISneedsTOreturnNULL");
            else
            {
                string valueToSearch = textBox3.Text.ToString();
                searchDataItem2(valueToSearch);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text)) searchDataItem3("THISneedsTOreturnNULL");
            else
            {
                string valueToSearch = textBox4.Text.ToString();
                searchDataItem3(valueToSearch);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text)) searchDataItem4("THISneedsTOreturnNULL");
            else
            {
                string valueToSearch = textBox5.Text.ToString();
                searchDataItem4(valueToSearch);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox6.Text)) searchDataItem5("THISneedsTOreturnNULL");
            else
            {
                string valueToSearch = textBox6.Text.ToString();
                searchDataItem5(valueToSearch);
            }
        }

        private void Notes_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(Notes.Text)))
            {
                textBox3.Enabled = true;
            }
        }

        private void Notes2_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(Notes2.Text)))
            {
                textBox4.Enabled = true;
            }
        }

        private void Notes3_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(Notes3.Text)))
            {
                textBox5.Enabled = true;
            }
        }

        private void Notes4_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(Notes4.Text)))
            {
                textBox6.Enabled = true;
            }
        }

        private void similar_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int pos = similar.GetCharIndexFromPosition(e.Location);
            int line = similar.GetLineFromCharIndex(pos);
            string text = similar.Lines[line];
            switch(searching)
            {
                case 1:
                    textBox2.Text = text;
                    break;
                case 2:
                    textBox3.Text = text;
                    break;
                case 3:
                    textBox4.Text = text;
                    break;
                case 4:
                    textBox5.Text = text;
                    break;
                case 5:
                    textBox6.Text = text;
                    break;
                default:
                    searching = 0;
                    break;
            }
            searching = 0;
        }

        private void similar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
