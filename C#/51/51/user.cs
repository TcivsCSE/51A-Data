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

namespace _51
{
    public partial class user : Form
    {

        DataTable dt_PersonalInformation = new DataTable();
        //SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
        //                                                                            "AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.IWLYF\\MSSQL\\DATA\\51 - 複製.mdf;" +
        //                                                                            "Integrated Security=True;" +
        //                                                                            "Connect Timeout=30;");
        SqlConnection cn1 = new SqlConnection("Server=LAPTOP-T4HKALLM\\IWLYF;" +
                                                                                    "Database=51;" +
                                                                                    "Integrated Security=true;" +
                                                                                    "Max Pool Size=10000");
        SqlConnection cn = new SqlConnection("Server=DESKTOP-B4U5A7I;" +
                                                                                    "Database=51;" +
                                                                                    "Integrated Security=true;" +
                                                                                    "Max Pool Size=10000");


        private DataTable GetData(string cnString)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cnString, cn);
            da.Fill(dt);
            return dt;
        }
        private void RunSQLcmd(string cmdstring)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(cmdstring, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public user(DataTable dt)
        {
            InitializeComponent();
            dt_PersonalInformation = dt;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
