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
    public partial class admin : Form
    {
        SqlConnection cn = new SqlConnection();
        public DataTable sqlcommad(String command)
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
            dgv_userUserControl.DataSource = sqlcommad("SELECT * FROM user_data WHERE state =1");

            DataTable tmp_description = sqlcommad("SELECT * FROM Description");
            tb_companyDescription.Text = tmp_description.Rows[0]["company_description"].ToString();
            tb_cardDescription.Text = tmp_description.Rows[0]["card_description"].ToString();
            tb_toKnow.Text = tmp_description.Rows[0]["toKnow"].ToString();
            tb_news.Text = tmp_description.Rows[0]["news"].ToString();

        }

        private void btn_showAllUserControl_Click(object sender, EventArgs e)
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

        private void btn_searchUserControl_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_userUserControl.DataSource = sqlcommad("SELECT * FROM user_data WHERE user_id ='" + tb_userIdUserControl.Text + "' AND state=1");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_userUserControl_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_accountUserControl.Text = dgv_userUserControl.SelectedRows[0].Cells["account"].Value.ToString();
                tb_passwordUserControl.Text = dgv_userUserControl.SelectedRows[0].Cells["password"].Value.ToString();
                tb_nameUserControl.Text = dgv_userUserControl.SelectedRows[0].Cells["name"].Value.ToString();
                tb_groupIdUserControl.Text = dgv_userUserControl.SelectedRows[0].Cells["group_id"].Value.ToString();
                tb_stateUserControl.Text = dgv_userUserControl.SelectedRows[0].Cells["state"].Value.ToString();

            }
            catch(Exception ex)
            {

            }
        }

        private void btn_applyUserControl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommad("UPDATE user_data SET password='" + tb_passwordUserControl.Text + "', name ='" + tb_nameUserControl.Text + "',group_id='" + tb_groupIdUserControl.Text + "',state='" + tb_stateUserControl.Text + "' WHERE user_id='" + dgv_userUserControl.SelectedRows[0].Cells["user_id"].Value.ToString() + "'");
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
                DataTable tmp_account = sqlcommad("SELECT * FROM user_data WHERE account='" + tb_accountUserControl.Text + "'");
                if(tmp_account.Rows.Count == 0)
                {
                    sqlcommad("INSERT into user_data (account,password,name,group_id,state) VALUES('" + tb_accountUserControl.Text + "','" + tb_passwordUserControl.Text + "','" + tb_nameUserControl.Text + "','" + tb_groupIdUserControl.Text + "','" + tb_stateUserControl.Text + "')");
                    admin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("account already exist");
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
                sqlcommad("UPDATE user_data SET state =0 WHERE user_id='" + dgv_userUserControl.SelectedRows[0].Cells["user_id"].Value.ToString() + "'");
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_applyDescription_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommad("UPDATE Description SET company_description='" + tb_companyDescription.Text + "',card_description='" + tb_cardDescription.Text + "',toKnow='" + tb_toKnow.Text + "',news='" + tb_news.Text + "' WHERE description_id =1");
                admin_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
