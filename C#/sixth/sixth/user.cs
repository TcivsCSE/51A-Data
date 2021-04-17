using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sixth
{
    public partial class user : Form
    {
        SqlConnection cn = new SqlConnection();
        DataTable personalInformation = new DataTable();
        public DataTable sqlcommad(String command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, cn);
            da.Fill(dt);
            return dt;
        }
        public user(SqlConnection connection, DataTable tmp_account)
        {
            InitializeComponent();
            cn = connection;
            personalInformation = tmp_account;
        }

        private void user_Load(object sender, EventArgs e)
        {

        }
    }
}
