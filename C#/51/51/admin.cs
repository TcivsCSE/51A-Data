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
        SqlConnection cn = new SqlConnection();

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
        public admin(SqlConnection connection)
        {
            InitializeComponent();
            cn = connection;
            

        }
        private void admin_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = GetData("SELECT * FROM user_data WHERE  state='1'");
            dgv_salers.DataSource = GetData("SELECT * FROM saler WHERE state='1'");
            DataTable descriptioin = GetData("SELECT * FROM Description WHERE description_id='1'");
            txbox_companyDescription.Text = descriptioin.Rows[0]["company_description"].ToString();
            txbox_cardDescription.Text = descriptioin.Rows[0]["card_description"].ToString();
            txbox_toKnow.Text = descriptioin.Rows[0]["toKnow"].ToString();
            txbox_news.Text = descriptioin.Rows[0]["news"].ToString();
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
                DataTable tmp_account = GetData("SELECT * FROM user_data WHERE account='"+txbox_usingAccount.Text+"'");
                RunSQLcmd("UPDATE service_point " +
                                        "SET point_name='" + txbox_pointName.Text + "'," + "saler_ineed='" + txbox_salerIneed.Text + "'," + "usingAccount_id='" + tmp_account.Rows[0]["user_id"]+"' "+
                                        "WHERE servicePoint_id='" + tmp.Rows[0]["servicePoint_id"] + "'");
                txbox_servicePoint.Text = tmp.Rows[0]["point_name"].ToString();
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
                DataTable tmp_account = GetData("SELECT * FROM user_data WHERE user_id='" + tmp.Rows[0]["usingAccount_id"] + "'");
                if (tmp.Rows.Count != 0)
                {
                    txbox_pointName.Text = tmp.Rows[0]["point_name"].ToString();
                    txbox_salerIneed.Text = tmp.Rows[0]["saler_ineed"].ToString();
                    txbox_usingAccount.Text =tmp_account .Rows[0]["account"].ToString();
                    dgv_salers.DataSource = GetData("SELECT * FROM saler WHERE workPoint_id='"+
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
                dgv_salers.DataSource = GetData("SELECT * FROM saler WHERE saler_name='"+
                                                            txbox_salerName.Text+"'");
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
                DataTable tmp = GetData("SELECT * FROM service_point WHERE point_name ='" + txbox_workpoint.Text + "'");
                RunSQLcmd("INSERT into saler (saler_name,workPoint_id,state) VALUES('" + txbox_saleNameAdd.Text + "','" + tmp.Rows[0]["servicePoint_id"] + "','1')");
                MessageBox.Show("saler successfully add",
                                                    "information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delUser_Click(object sender, EventArgs e)
        {
            try
            {
                RunSQLcmd("UPDATE saler" +
                                        " SET state='0'" +
                                        "WHERE saler_id='"+dgv_salers.SelectedRows[0].Cells["saler_id"].Value+"'");
                MessageBox.Show("saler successfully deleted",
                                                    "information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_applySalerChange_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_workPoint = GetData("SELECT * FROM service_point WHERE point_name='" + txbox_workpoint.Text + "'");
                RunSQLcmd("UPDATE saler " +
                                        "SET saler_name='"+ txbox_saleNameAdd.Text + "', workPoint_id='"+tmp_workPoint.Rows[0]["servicePoint_id"]+"' "+
                                        "WHERE saler_id = '"+dgv_salers.SelectedRows[0].Cells["saler_id"].Value+"'");
                MessageBox.Show("change successfully apply",
                                                    "informatioin",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                RunSQLcmd("UPDATE Description " +
                                        "SET company_description='" + txbox_companyDescription.Text + "'," +
                                                "card_description='" + txbox_cardDescription.Text + "'," +
                                                "toKnow='" + txbox_toKnow.Text + "'," +
                                                "news='"+txbox_news.Text+"' "+
                                                "WHERE description_id=1");
                MessageBox.Show("apply successful",
                                                    "information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_salers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_workPoint = GetData("SELECT * FROM service_point WHERE servicePoint_id ='" + dgv_salers.SelectedRows[0].Cells["workPoint_id"].Value + "'");
                txbox_saleNameAdd.Text = dgv_salers.SelectedRows[0].Cells["saler_name"].Value.ToString();
                txbox_workpoint.Text = tmp_workPoint.Rows[0]["point_name"].ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
