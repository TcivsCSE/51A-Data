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
    public partial class admin : Form
    {
        SqlConnection cn = new SqlConnection();
        public DataTable sqlcommand(string command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, cn);
            da.Fill(dt);
            return dt;
        }
        public admin(SqlConnection connection)
        {
            InitializeComponent();
            cn = connection;
        }


        private void admin_Load(object sender, EventArgs e)
        {
            dgv_usersUserControl.DataSource = sqlcommand("SELECT * FROM user_data WHERE state =1");
            DataTable tmp_description = sqlcommand("SELECT * FROM Description");
            tb_companyDescription.Text = tmp_description.Rows[0]["company_description"].ToString();
            tb_cardDescription.Text= tmp_description.Rows[0]["card_description"].ToString();
            tb_toKnow.Text= tmp_description.Rows[0]["toKnow"].ToString();
            tb_news.Text = tmp_description.Rows[0]["news"].ToString();
            dgv_salers.DataSource = sqlcommand("SELECT * FROM saler WHERE state= 1");
        }

        private void dgv_usersUserControl_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_accountUserControl.Text = dgv_usersUserControl.SelectedRows[0].Cells["account"].Value.ToString();
                tb_passwordUserControl.Text = dgv_usersUserControl.SelectedRows[0].Cells["password"].Value.ToString();
                tb_groupUserControl.Text = dgv_usersUserControl.SelectedRows[0].Cells["group_id"].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            admin_Load(sender, e);
        }

        private void btn_searchUserUserControl_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_usersUserControl.DataSource = sqlcommand("SELECT * FROM user_data WHERE account = '" + tb_accountSearchUser.Text + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_applychangeUserControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE user_data SET account='" + tb_accountUserControl.Text + "',password='" + tb_passwordUserControl.Text + "',group_id='" + tb_groupUserControl.Text + "' WHERE user_id='" + dgv_usersUserControl.SelectedRows[0].Cells["user_id"].Value.ToString() + "'");
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addUserUserControl_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_account = sqlcommand("SELECT * FROM user_data WHERE account = '" + tb_accountUserControl.Text + "'"); ;
                if (tmp_account.Rows.Count == 0)
                {
                    sqlcommand("INSERT into user_data(account,password,group_id,state) VALUES('" + tb_accountUserControl.Text + "','" + tb_passwordUserControl.Text + "','" + tb_groupUserControl.Text + "',1)");
                    admin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("account is exist");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_deleteUserUserControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE user_data SET state=0 WHERE user_id='" + dgv_usersUserControl.SelectedRows[0].Cells["user_id"].Value + "'");
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_applyInformationControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE Description SET company_description='" + tb_companyDescription.Text + "',card_description='" + tb_cardDescription.Text + "',toKnow='" + tb_toKnow.Text + "',news='" + tb_news.Text + "' WHERE description_id=1");
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_searchPointPointControl_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_salers.DataSource = sqlcommand("SELECT * FROM saler WHERE workPoint_id='" + tb_pointId.Text + "' AND state=1");
                DataTable tmp_point = sqlcommand("SELECT * FROM service_point WHERE servicePoint_id='" + tb_pointId.Text + "'");
                tb_pointNamePointControl.Text = tmp_point.Rows[0]["point_name"].ToString();
                tb_addressIdPointControl.Text = tmp_point.Rows[0]["address_id"].ToString();
                tb_usingAccountIdPointControl.Text = tmp_point.Rows[0]["usingAccount_id"].ToString();
                tb_salerIneedPointControl .Text = tmp_point.Rows[0]["saler_ineed"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_applyChangePointControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE service_point SET point_name='" + tb_pointNamePointControl.Text + "',address_id='" + tb_addressIdPointControl.Text + "',usingAccount_id='" + tb_usingAccountIdPointControl.Text + "',saler_ineed='" + tb_salerIneedPointControl.Text + "' WHERE servicePoint_id='" + tb_pointId.Text + "'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addPointPointControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("INSERT into service_point(point_name,address_id,usingAccount_id,saler_ineed) VALUES('" + tb_pointNamePointControl.Text + "','" + tb_addressIdPointControl.Text + "','" + tb_usingAccountIdPointControl.Text + "','" + tb_salerIneedPointControl.Text + "')");
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deletePointPointControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE service_point SET state=0 WHERE servicePoint_id='" + tb_pointId.Text + "'");
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
                tb_salerNamePointControl.Text = dgv_salers.SelectedRows[0].Cells["saler_name"].Value.ToString();
                tb_workPointIdPointControl.Text = dgv_salers.SelectedRows[0].Cells["workPoint_id"].Value.ToString();
                tb_statePointControl.Text = dgv_salers.SelectedRows[0].Cells["state"].Value.ToString();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void btn_applySalerChangeSalerControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE saler SET saler_name='" + tb_salerNamePointControl.Text + "',workPoint_id='" + tb_workPointIdPointControl.Text + "',state='" + tb_statePointControl.Text + "' WHERE saler_id = '" + dgv_salers.SelectedRows[0].Cells["saler_id"].Value.ToString() + "'");
                admin_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addSalerSalerControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("INSERT into saler(saler_name,workPoint_id,state) VALUES ('"+tb_salerNamePointControl.Text+"','"+tbwork)
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
