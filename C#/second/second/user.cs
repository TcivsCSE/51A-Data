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
namespace second
{
    public partial class user : Form
    {
        SqlConnection cn = new SqlConnection();
        DataTable personal_infromation = new DataTable();
        public user(SqlConnection connection, DataTable tmp)
        {
            InitializeComponent();
            cn = connection;
            personal_infromation = tmp;
        }

        private void user_Load(object sender, EventArgs e)
        {

        }
    }
}
