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
    public partial class saler : Form
    {
        SqlConnection cn = new SqlConnection();
        DataTable pointInformation = new DataTable();
        public DataTable sqlcommad(String command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, cn);
            da.Fill(dt);
            return dt;
        }
        public saler(SqlConnection connection, DataTable salerInformation)
        {
            InitializeComponent();
            cn = connection;
            pointInformation = sqlcommad("SELECT * FROM service_point WHERE usingAccount_id='" + salerInformation.Rows[0]["user_id"] + "'");
        }

        private void saler_Load(object sender, EventArgs e)
        {

        }
    }
}
