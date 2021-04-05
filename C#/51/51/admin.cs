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
    public partial class admin : Form
    {
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
        public admin()
        {
            InitializeComponent();

        }
        private void admin_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = GetData("SELECT * FROM user_data WHERE  state='1'");
            dgv_salers.DataSource = GetData("SELECT * FROM saler");
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT account FROM user_data WHERE" +
                                                                " account='" + txbox_account.Text + "'");

                if (tmp.Rows.Count == 0)
                {
                    RunSQLcmd("INSERT INTO dbo.user_data(account,password,name,group_id,state)  VALUES('" +
                                            txbox_account.Text.ToString() + "','" +
                                            txbox_password.Text.ToString() + "','" +
                                            txbox_name.Text.ToString() + "','" +
                                            (cbbox_group.SelectedIndex + 1).ToString() + "','1')");
                    MessageBox.Show("add user successfully",
                                                        "Remind",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                    dgv_users.Update();
                    admin_Load(sender, e);
                    txbox_account.Text = "";
                    txbox_password.Text = "";
                    txbox_name.Text = "";
                    cbbox_group.Text = "";

                }
                else
                {
                    MessageBox.Show("account has already been used");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_seartchUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT * FROM user_data WHERE account='" +
                                                                 txbox_user.Text + "'");
                if (tmp.Rows.Count == 1)
                {
                    dgv_users.DataSource = tmp;
                }
                else
                {
                    MessageBox.Show("user not found",
                                                        "Warning",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Warning);
                    txbox_user.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_showAllUsers_Click(object sender, EventArgs e)
        {
            try
            {
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                RunSQLcmd("UPDATE user_data" +
                                        " SET state='0'" +
                                        " WHERE user_id='" +
                                        dgv_users.SelectedRows[0].Cells["user_id"].Value.ToString()+"'");
                admin_Load(sender, e);
                MessageBox.Show("delete user succesfully",
                                                    "Information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btn_applyChange_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT * FROM service_point WHERE point_name='" + txbox_pointName.Text + "'");
                RunSQLcmd("UPDATE service_point " +
                                        "SET point_name='"+txbox_pointName.Text+"'," + "saler_ineed='"+txbox_salerIneed.Text+"' "+
                                        "WHERE servicePoint_id='"+tmp.Rows[0]["servicePoint_id"]+"'");
                MessageBox.Show("change successfully apply",
                                                 "Information",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_seartch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT * FROM service_point WHERE point_name='" +
                                                                txbox_servicePoint.Text + "'");
                if (tmp.Rows.Count != 0)
                {
                    txbox_pointName.Text = tmp.Rows[0]["point_name"].ToString();
                    txbox_salerIneed.Text = tmp.Rows[0]["saler_ineed"].ToString();
                    dgv_salers.DataSource = GetData("SELECT * FROM saler WHERE workSpace_id='"+
                                                                                    tmp.Rows[0]["servicePoint_id"]+"'");
                }
                else
                {
                    MessageBox.Show("point not found",
                                                        "warning",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addSaler_Click(object sender, EventArgs e)
        {
            try
            {
                RunSQLcmd("");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_searchSaler_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT * FROM user_data WHERE account='"+
                                                                txbox_salerAccount.Text+"'");
                dgv_salers.DataSource = GetData("SELECT * FROM saler WHERE workAccount_id ='"+
                                                            tmp.Rows[0]["user_id"]+"'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_showUsers_Click(object sender, EventArgs e)
        {
            try
            {
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_useradd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_account = GetData("SELECT * FROM user_data WHERE account='" +
                                                            txbox_saleAccountAdd.Text + "'");
                DataTable tmp_workPoint = GetData("SELECT * FROM service_point WHERE point_name ='" +
                                                            txbox_workpoint.Text+"'");
                RunSQLcmd("INSERT into saler (workAccount_id,workSpace_id,state) VALUES('" +
                                        tmp_account.Rows[0]["user_id"]+"','" +
                                        tmp_workPoint.Rows[0]["servicePoint_id"]+"','1')");
                MessageBox.Show("saler successfully add",
                                                    "Informatioin",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
