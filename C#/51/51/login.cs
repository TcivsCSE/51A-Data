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
    public partial class login : Form
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        SqlConnection cn = new SqlConnection();
        SqlConnection cn2 = new SqlConnection("Server=LAPTOP-T4HKALLM\\IWLYF;" +
                                                                                    "Database=51;" +
                                                                                    "Integrated Security=true;" +
                                                                                    "Max Pool Size=10000");
        SqlConnection cn1 = new SqlConnection("Server=DESKTOP-B4U5A7I;" +
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
        public login()
        {
            InitializeComponent();            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT * FROM user_data WHERE " +
                                                                 "account='" + txbox_account.Text.ToString() +
                                                                 "' AND password='" + txbox_password.Text.ToString()+"'");
                if (tmp.Rows.Count == 1)
                {
                    switch (Convert.ToInt32(tmp.Rows[0]["group_id"]))
                    {
                        case 1:
                            admin a = new admin(cn);
                            a.Show();
                            this.Hide();
                            break;
                        case 2:
                            saler s = new saler(cn);
                            s.Show();
                            this.Hide();
                            break;
                        case 3:
                            user u = new user(tmp,cn);
                            u.Show();
                            this.Hide();
                            break;
                    }
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

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT account FROM user_data WHERE" +
                                                                " account='" + txbox_account.Text+"'");
                if (tmp.Rows.Count==0)
                {
                    RunSQLcmd("INSERT INTO dbo.user_data(group_id,account,password,state)  VALUES(3,'"+
                                            txbox_account.Text.ToString() + "','" +
                                            txbox_password.Text.ToString() + "','1')");
                    MessageBox.Show("sign up successfully",
                                                        "Remind",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                    txbox_account.Text = "";
                    txbox_password.Text = "";

                }
                else
                {
                    MessageBox.Show("account has already been used");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            builder.DataSource = "(LocalDB)\\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + "\\login_db.mdf";
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 30;
            cn.ConnectionString = builder.ConnectionString;
        }
    }
}









