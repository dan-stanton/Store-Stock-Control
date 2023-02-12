using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NewStores
{
    class GlobalString
    {
        public static string CurrentUsername = "Name Not Set";
        public static string EmailUsername = "redacted";
        public static string EmailPassword = "redacted";
        public static string EmailTO = "redacted";
        public static string SqlDataSource = "Data Source=.;Initial Catalog=Stores;Persist Security Info=True;User ID=redacted;Password=redacted;MultipleActiveResultSets=true";
        public static string sqlrtf;
        public static string selected_product_id;
        public static int IsUserAdmin;

    }
}
