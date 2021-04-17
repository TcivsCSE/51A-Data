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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public DataTable sqlcommad(String command)
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
            builder.DataSource = "(LocalDB)\\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + "\\51.mdf";
            builder.IntegratedSecurity = true;

            cn.ConnectionString = builder.ConnectionString;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_account = sqlcommad("SELECT * FROM user_data WHERE account='" + tb_account.Text + "' AND password='" + tb_password.Text + "'");
                if (tmp_account.Rows.Count != 0)
                {
                    switch (Convert.ToInt32(tmp_account.Rows[0]["group_id"]))
                    {
                        case 1:
                            admin a = new admin(cn);
                            a.Show();
                            break;
                        case 2:
                            saler s = new saler(cn,tmp_account);
                            s.Show();
                            break;
                        case 3:
                            user u = new user(cn,tmp_account);
                            u.Show();
                            break;

                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("account or password wrong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
