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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public DataTable sqlcommand(string command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, cn);
            da.Fill(dt);
            return dt;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            builder.AttachDBFilename = Application.StartupPath + "\\51.mdf";
            builder.DataSource = "(LocalDB)\\MSSQLLocalDB";
            builder.IntegratedSecurity = true;
            cn.ConnectionString = builder.ConnectionString;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = sqlcommand("SELECT * FROM user_data WHERE account='" + tb_account.Text + "' AND password='" + tb_password.Text + "'");

                if (tmp.Rows.Count != 0)
                {
                    switch (Convert.ToInt32(tmp.Rows[0]["group_id"]))
                    {
                        case 1:
                            admin a = new admin(cn);
                            a.Show();
                            break;
                        case 2:
                            saler s = new saler(cn,tmp);
                            s.Show();
                            break;
                        case 3:
                            user u = new user(cn,tmp);
                            u.Show();
                            break;

                    }
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
