using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace NewStores
{
    public partial class MainMenu : Form
    {
        int retCode;
        int hCard;
        int hContext;
        int Protocol;
        public bool connActive = false;
        string readername = "ACS ACR122U PICC Interface 0";      // change depending on reader
        public byte[] SendBuff = new byte[263];
        public byte[] RecvBuff = new byte[263];
        public int SendLen, RecvLen, nBytesRet, reqType, Aprotocol, dwProtocol, cbPciLength;
        public Card.SCARD_READERSTATE RdrState;
        public Card.SCARD_IO_REQUEST pioSendRequest;

        static int buttonclicked;
        SqlConnection con = new SqlConnection(@"" + GlobalString.SqlDataSource + "");
        SqlCommand command;

        public MainMenu()
        {
            InitializeComponent();
            AddDrag(panel1);
            SelectDevice();
            establishContext();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            updatestats();
            RefreshStats.Enabled = true;// refresh stats every 60 secs
            if (con.State == ConnectionState.Closed) con.Open();
            currentuser.Text = GlobalString.CurrentUsername;
            if (GlobalString.IsUserAdmin == 1)
            {
                groupBox1.Enabled = true;
                richTextBox1.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                groupBox1.Hide();
                richTextBox1.Hide();
                button3.Hide();
                label1.Hide();
                label2.Hide();
                richTextBox1.Hide();
                button3.Hide();
                button1.Hide();
                label5.Hide();
                label4.Hide();
                button4.Hide();
                button5.Hide();
                label6.Hide();
                button6.Hide();
                label10.Hide();

            }
            string query = "SELECT Notes FROM Settings";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                richTextBox1.Text = RtfToPlainText(reader.GetString(0));
                GlobalString.sqlrtf = richTextBox1.Text;
            }
            else
            {
                MessageBox.Show("Error? Admin admin to INSERT INTO SETTINGS NOTES", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
            }


            query = "SELECT UserName FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "comboBox1");
            comboBox1.DisplayMember = "UserName";
            comboBox1.ValueMember = "UserName";
            comboBox1.DataSource = ds.Tables["comboBox1"];
            comboBox1.SelectedIndex = -1;


            timer1.Enabled = true;

        }

        public void updatestats()
        {
            string query;
            Stats.Rows.Clear();
            Stats.Columns.Clear();
            Stats.ColumnCount = 2;
            Stats.Columns[0].Name = "Statistics";
            Stats.Columns[1].Name = "";

            if (con.State == ConnectionState.Closed) con.Open();


            query = "SELECT SUM(Price*Stock) AS total_price FROM Products WHERE Stock > 0 AND Disabled = 0";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            string temp;
            if (reader.Read())
            {
                if (!Convert.IsDBNull(reader[0]))
                {
                    decimal tempdec = reader.GetDecimal(0);
                    string[] row = new string[] { "Stock Balance", "£" + tempdec.ToString() + "" };
                    Stats.Rows.Add(row);
                }
            }


            query = "SELECT COUNT(*) FROM Products WHERE Disabled = 0";
            command = new SqlCommand(query, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                temp = Convert.ToString(reader.GetInt32(0));
                string[] row = new string[] { "Product Count", temp };
                Stats.Rows.Add(row);
            }

            query = "SELECT COUNT(*) FROM Suppliers WHERE Disabled = 0";
            command = new SqlCommand(query, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                temp = Convert.ToString(reader.GetInt32(0));
                string[] row = new string[] { "Supplier Count", temp };
                Stats.Rows.Add(row);
            }

            query = "SELECT COUNT(*) FROM Groups WHERE Disabled = 0";
            command = new SqlCommand(query, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                temp = Convert.ToString(reader.GetInt32(0));
                string[] row = new string[] { "Group Count", temp };
                Stats.Rows.Add(row);
            }
        }
        public string RtfToPlainText(string rtf)
        {
            var flowDocument = new FlowDocument();
            var textRange = new TextRange(flowDocument.ContentStart, flowDocument.ContentEnd);

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(rtf ?? string.Empty)))
            {
                textRange.Load(stream, DataFormats.Rtf);
            }

            return textRange.Text;
        }

        private void resetcolors()
        {
            Products.BackColor = Color.Black;
            Suppliers.BackColor = Color.Black;
            Groups.BackColor = Color.Black;
            Logs.BackColor = Color.Black;
            Products.BackColor = Color.Black;
            NewEntry.BackColor = Color.Black;
        }

        private void Products_Click(object sender, EventArgs e)
        {
            resetcolors();
            Products.BackColor = Color.FromArgb(94, 148, 255);
            openChildForm(new ProductsForm());
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            resetcolors();
            Suppliers.BackColor = Color.FromArgb(94, 148, 255);
            openChildForm(new Suppliers());
        }

        private void Groups_Click(object sender, EventArgs e)
        {
            resetcolors();
            Groups.BackColor = Color.FromArgb(94, 148, 255);
            openChildForm(new Groups());
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            if (GlobalString.IsUserAdmin == 1)
            {
                resetcolors();
                Logs.BackColor = Color.FromArgb(94, 148, 255);
                openChildForm(new LogsForm());
            }
            else
            {
                MessageBox.Show("You must be an administrator to view this section.", "Error", MessageBoxButtons.OK);
            }
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            resetcolors();
            NewEntry.BackColor = Color.FromArgb(94, 148, 255);
            openChildForm(new NewEntry());
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            GotoLogin();
        }

        private Form activeForm = null;

        private void GotoLogin()
        {
            GlobalString.CurrentUsername = "";
            GlobalString.IsUserAdmin = 0;
            timer1.Stop();
            timer1.Enabled = false;
            var Login = new Login();
            //Login.Closed += (s, args) => this.Close();
            Login.Show();
            this.Hide();
        }

        private void openChildForm(Form childForm)//Open New Forms in 'MainForm'
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainForm.Controls.Add(childForm);
            MainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(out LASTINPUTINFO plii);

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            public static readonly int SizeOf =
                   Marshal.SizeOf(typeof(LASTINPUTINFO));

            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public int dwTime;
        }


        private void timer1_Tick(object sender, System.EventArgs e)
        {
            int idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            int envTicks = Environment.TickCount;

            if (GetLastInputInfo(out lastInputInfo))
            {
                int lastInputTick = lastInputInfo.dwTime;
                idleTime = envTicks - lastInputTick;
            }

            int a;

            if (idleTime > 0)
                a = idleTime / 1000;
            else
                a = idleTime;

            if (a > 300)
            {
                GotoLogin();
                return;
            }
        }

        // This adds the event handler for the control
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            resetcolors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonclicked = 1;
            ProcessData();

            if (con.State == ConnectionState.Closed) con.Open();
            string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Admin', 'Low stock email forced by: " + GlobalString.CurrentUsername + "')";
            command = new SqlCommand(query1, con);
            SqlDataReader reader1 = command.ExecuteReader();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonclicked = 2;
            ProcessData();
            if (con.State == ConnectionState.Closed) con.Open();
            string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Admin', 'Negative stock email forced by: " + GlobalString.CurrentUsername + "')";
            command = new SqlCommand(query1, con);
            SqlDataReader reader1 = command.ExecuteReader();
        }

        static DataSet QueryDatabase()
        {
            SqlConnection connection = new SqlConnection(@"" + GlobalString.SqlDataSource + "");
            string query2;
            if (buttonclicked == 1) query2 = "SELECT ProductID, Item, Stock FROM Products WHERE LowStock >= Stock";
            switch (buttonclicked)
            {
                case 1:
                    query2 = "SELECT Products.ProductID, Products.Item, Products.Stock, Suppliers.SupplierName FROM Products INNER JOIN Suppliers ON Products.Supplier = Suppliers.SupplierID AND LowStock >= Stock";
                    break;
                case 2:
                    query2 = "SELECT ProductID, Item, Stock FROM Products WHERE Stock < 0";
                    break;
                default:
                    query2 = "SELECT * FROM Products WHERE LowStock = 9999";// 0 results because error?
                    break;
            }

            SqlDataAdapter da = new SqlDataAdapter(query2, connection);
            DataSet ds = new DataSet();

            connection.Open();
            da.Fill(ds);
            connection.Close();
            da.Dispose();
            da.Dispose();
            connection.Dispose();
            return ds;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query = "UPDATE Products SET Stock = 0 WHERE Stock < 0";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Admin', 'Negative stock reset by: " + GlobalString.CurrentUsername + "')";
            command = new SqlCommand(query1, con);
            SqlDataReader reader1 = command.ExecuteReader();
            MessageBox.Show("Stock reset", "Admin", MessageBoxButtons.OK);
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            UserPassValidate();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            UserPassValidate();
        }

        private void UserPassValidate()
        {
            if (!String.IsNullOrEmpty(Username.Text) && !String.IsNullOrEmpty(Password.Text))
                NewUserBtn.Enabled = true;
            else
                NewUserBtn.Enabled = false;
        }

        static void ProcessData()
        {
            DataSet ds = new DataSet();
            StringBuilder table = new StringBuilder();
            ds = QueryDatabase();
            if (ds.Tables.Count > 0)
            {
                table.Append("<table style=\"text-align:center\"><thead><tr style=\"background - color: black\">");
                foreach (DataColumn col in ds.Tables[0].Columns)
                {
                    table.Append("<td style=\"border: 1px solid black\">" + col.ColumnName + "</td>");
                }
                table.Append("</tr></thead>");
            }
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table.Append("<tr>");
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    table.Append("<td style=\"border: 1px solid black\">");
                    table.Append(row[dc.ColumnName]);
                    table.Append("</td>");
                }
                table.Append("</tr>");
            }

            table.Append("</table>");

            Console.WriteLine(table.ToString());

            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(GlobalString.EmailTO));
            msg.From = new MailAddress(GlobalString.EmailUsername);
            string subjectosend;
            switch (buttonclicked)
            {
                case 1:
                    subjectosend = "Stores - Low Stock Warning";
                    break;
                case 2:
                    subjectosend = "Stores - Negative Stock Warning";
                    break;
                default:
                    subjectosend = "ERROOOOOOOOOOOOR";// 0 results because error?
                    break;
            }
            msg.Subject = subjectosend;
            string bodytosend;

            switch (buttonclicked)
            {
                case 1:
                    bodytosend = "The following items are low on stock:\n\n" + table.ToString() + "";
                    break;
                case 2:
                    bodytosend = "The following items are negative stock:\n\n" + table.ToString() + "";
                    break;
                default:
                    bodytosend = "ERROOOOOOOOOOOOR";// 0 results because error?
                    break;
            }


            msg.Body = bodytosend;
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.office365.com";
            client.Credentials = new System.Net.NetworkCredential(GlobalString.EmailUsername, GlobalString.EmailPassword);
            client.Port = 587;
            client.EnableSsl = true;
            client.Send(msg);
            MessageBox.Show("Email sent.", "Admin", MessageBoxButtons.OK);
        }

        private string getcardUID()//only for mifare 1k cards
        {
            string cardUID = "";
            byte[] receivedUID = new byte[256];
            Card.SCARD_IO_REQUEST request = new Card.SCARD_IO_REQUEST();
            request.dwProtocol = Card.SCARD_PROTOCOL_T1;
            request.cbPciLength = System.Runtime.InteropServices.Marshal.SizeOf(typeof(Card.SCARD_IO_REQUEST));
            byte[] sendBytes = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 }; //get UID command      for Mifare cards
            int outBytes = receivedUID.Length;
            int status = Card.SCardTransmit(hCard, ref request, ref sendBytes[0], sendBytes.Length, ref request, ref receivedUID[0], ref outBytes);

            if (status != Card.SCARD_S_SUCCESS)
            {
                cardUID = "Error";
            }
            else
            {
                cardUID = BitConverter.ToString(receivedUID.Take(4).ToArray()).Replace("-", string.Empty).ToLower();
            }

            return cardUID;
        }

        private bool DoesAccountExist(string username)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT * FROM Users WHERE UserName = '" + username + "'";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) return true;
            return false;
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult msgbox;
            if (String.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show("Enter a username", "Error", MessageBoxButtons.OK);
                return;
            }

            if (String.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Enter a password", "Error", MessageBoxButtons.OK);
                return;
            }

            if(DoesAccountExist(Username.Text))
            {
                msgbox = MessageBox.Show("A user already exists with that name", "Error", MessageBoxButtons.OK);
                return;
            }

            if (connectCard())
            {
                string cardUID = getcardUID();
                //textBlock1.Text = cardUID; //displaying on text block
                if (con.State == ConnectionState.Closed) con.Open();
                string query;
                query = "SELECT * FROM Users WHERE RFID = '" + cardUID + "'";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    msgbox = MessageBox.Show("Tag already registered, delete it first", "Error", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
                else
                {
                    int check;
                    if (Admin.Checked) check = 1;
                    else check = 0;
                    query = "INSERT INTO Users (UserName, RFID, Password, Admin) VALUES('" + Username.Text + "', '" + cardUID + "', '" + Password.Text + "', '" + check + "')";
                    command = new SqlCommand(query, con);
                    reader = command.ExecuteReader();
                    string msgstr = "Username: " + Username.Text + " has been registered with RFID: " + cardUID + "";
                    msgbox = MessageBox.Show(msgstr, "Registered", MessageBoxButtons.OK);

                    string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Admin', 'Username: " + Username.Text + " has been registered with RFID: " + cardUID + "')";
                    command = new SqlCommand(query1, con);
                    SqlDataReader reader1 = command.ExecuteReader();
                }
            }
            else
            {
                msgbox = MessageBox.Show("Place tag on reader", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text))
                DeleteByRFID();
            else
                DeleteByUsername();
        }

        private void DeleteByRFID()
        {
            DialogResult msgbox;
            if (connectCard())
            {
                string cardUID = getcardUID();
                if (con.State == ConnectionState.Closed) con.Open();
                string query;
                query = "SELECT UserName, RFID FROM Users WHERE RFID = '" + cardUID + "'";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                string Username = reader.GetString(0);
                if (String.Equals(Username, "Admin"))
                {
                    msgbox = MessageBox.Show("You can't delete the Admin account.", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (String.Equals(Username, GlobalString.CurrentUsername))
                {
                    DialogResult result = MessageBox.Show("You are about to delete your own account, this will log you out.", "Are you sure?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                    else if (result == DialogResult.Yes) { }
                    else return;
                }
                if (reader.HasRows)
                {
                    //query = "UPDATE Users SET RFID = 'Deregistered (old key = " + cardUID + ")' WHERE RFID = '" + cardUID + "'";
                    query = "DELETE FROM Users WHERE RFID = '" + cardUID + "'";
                    command = new SqlCommand(query, con);
                    reader = command.ExecuteReader();
                    string msgstr = "User: "+ Username + " with RFID tag: " + cardUID + " has been deleted";
                    msgbox = MessageBox.Show(msgstr, "Deregister", MessageBoxButtons.OK);


                    string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Admin', 'User: " + Username + " with RFID tag: " + cardUID + " has been deleted by " + GlobalString.CurrentUsername + "')";
                    command = new SqlCommand(query1, con);
                    SqlDataReader reader1 = command.ExecuteReader();

                    if (String.Equals(Username, GlobalString.CurrentUsername))
                    {
                        GotoLogin();
                    }

                }
                else
                {
                    msgbox = MessageBox.Show("This tag is not registered", "Error", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SendQuery form = new SendQuery())
            {
                form.ShowDialog();
            }
        }

        private void RefreshStats_Tick(object sender, EventArgs e)
        {
            updatestats();
        }

        private void DeleteByUsername()
        {
            DialogResult msgbox;
            if (String.Equals(comboBox1.Text, "Admin"))
            {
                msgbox = MessageBox.Show("You can't delete the Admin account.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (String.Equals(comboBox1.Text, GlobalString.CurrentUsername))
            {
                DialogResult result = MessageBox.Show("You are about to delete your own account, this will log you out.", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                else if (result == DialogResult.Yes) { }
                else return;
            }
            if (con.State == ConnectionState.Closed) con.Open();
            string query;
            query = "SELECT RFID FROM Users WHERE UserName = '" + comboBox1.Text + "'";
            Console.WriteLine(query);
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string RFID = reader.GetString(0);
                query = "DELETE FROM Users WHERE UserName = '" + comboBox1.Text + "'";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                string msgstr = "User: " + comboBox1.Text + " with RFID tag: " + RFID + " has been deleted";
                msgbox = MessageBox.Show(msgstr, "Deregister", MessageBoxButtons.OK);


                string query1 = "INSERT INTO Logs (LogDate, LogType, LogDetails) VALUES('" + System.DateTime.Now + "', 'Admin', 'User: " + comboBox1.Text + " with RFID tag: " + RFID + " has been deleted by " + GlobalString.CurrentUsername + "')";
                command = new SqlCommand(query1, con);
                command.ExecuteNonQuery();
                reader.Close();

                if (String.Equals(comboBox1.Text, GlobalString.CurrentUsername))
                {
                    GotoLogin();
                }

            }
            else
            {
                msgbox = MessageBox.Show("Nobody with this name?", "Error", MessageBoxButtons.OK);
                reader.Close();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            DialogResult msgbox;
            string s = WebUtility.HtmlEncode(richTextBox1.Rtf);
            SqlCommand command2 = con.CreateCommand();
            command2.Parameters.AddWithValue("@s", s);
            command2.CommandText = "UPDATE Settings SET Notes = @s";
            command2.ExecuteNonQuery();
            msgbox = MessageBox.Show("Updated", "RTF", MessageBoxButtons.OK);
        }



        

        internal void establishContext()
        {
            retCode = Card.SCardEstablishContext(Card.SCARD_SCOPE_SYSTEM, 0, 0, ref hContext);
            if (retCode != Card.SCARD_S_SUCCESS)
            {
                MessageBox.Show("Check your device and please restart again", "Reader not connected", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                connActive = false;
                return;
            }
        }



        public bool connectCard()
        {
            connActive = true;

            retCode = Card.SCardConnect(hContext, readername, Card.SCARD_SHARE_SHARED,
                      Card.SCARD_PROTOCOL_T0 | Card.SCARD_PROTOCOL_T1, ref hCard, ref Protocol);

            if (retCode != Card.SCARD_S_SUCCESS)
            {
                // MessageBox2.Show(Card.GetScardErrMsg(retCode), "Card not available", MessageBoxButton.OK, MessageBoxImage.Error);
                connActive = false;
                return false;
            }
            return true;
        }

        public void SelectDevice()
        {
            List<string> availableReaders = this.ListReaders();
            //this.RdrState = new Card.SCARD_READERSTATE();
            readername = availableReaders[0].ToString();//selecting first device
            this.RdrState.RdrName = readername;
        }

        public List<string> ListReaders()
        {
            int ReaderCount = 0;
            List<string> AvailableReaderList = new List<string>();

            //Make sure a context has been established before 
            //retrieving the list of smartcard readers.
            retCode = Card.SCardListReaders(hContext, null, null, ref ReaderCount);
            if (retCode != Card.SCARD_S_SUCCESS)
            {
                MessageBox.Show(Card.GetScardErrMsg(retCode));
                //connActive = false;
            }

            byte[] ReadersList = new byte[ReaderCount];

            //Get the list of reader present again but this time add sReaderGroup, retData as 2rd & 3rd parameter respectively.
            retCode = Card.SCardListReaders(hContext, null, ReadersList, ref ReaderCount);
            if (retCode != Card.SCARD_S_SUCCESS)
            {
                MessageBox.Show(Card.GetScardErrMsg(retCode));
            }

            string rName = "";
            int indx = 0;
            if (ReaderCount > 0)
            {
                // Convert reader buffer to string
                while (ReadersList[indx] != 0)
                {

                    while (ReadersList[indx] != 0)
                    {
                        rName = rName + (char)ReadersList[indx];
                        indx = indx + 1;
                    }

                    //Add reader name to list
                    AvailableReaderList.Add(rName);
                    rName = "";
                    indx = indx + 1;

                }
            }
            return AvailableReaderList;

        }
    }

}
