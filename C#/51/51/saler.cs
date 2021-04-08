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
    public partial class saler : Form
    {
        DataTable dt_pointInfo = new DataTable();
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
        public saler(DataTable dt,SqlConnection connection)
        {
            InitializeComponent();
            cn = connection;
            dt_pointInfo = GetData("SELECT * FROM service_point  WHERE usingAccount_id='" + dt.Rows[0]["user_id"] + "'");
        }
        private void saler_Load(object sender, EventArgs e)
        {
            dgv_cardId.DataSource = GetData("SELECT * FROM card_type");
            DataTable descriptioin = GetData("SELECT * FROM Description WHERE description_id='1'");
            label_companyDescription.Text = descriptioin.Rows[0]["company_description"].ToString();
            label_cardDescription.Text = descriptioin.Rows[0]["card_description"].ToString();
            label_toKnow.Text = descriptioin.Rows[0]["toKnow"].ToString();
            label_news.Text = descriptioin.Rows[0]["news"].ToString();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        
        private void btn_refundCard_Click(object sender, EventArgs e)
        {
            try
            {
                int balance = Convert.ToInt32(GetData("SELECT balance FROM card_data WHERE card_id='" + txbox_cardIdRefund.Text + "' AND state=1").Rows[0]["balance"]);
                MessageBox.Show("The card has been Deactivate\nPlease refund "+balance.ToString()+" dollar",
                                                    "Information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                RunSQLcmd("UPDATE card_data " +
                                        "SET state=0,balance=0 " +
                                        "WHERE card_id='" + txbox_cardIdRefund.Text + "'");


                //TODO
                RunSQLcmd("INSERT into serviceTrade_record (card_id,servicePoint_id, serviceType_id,time) VALUES ('" +
                                        txbox_cardIdRefund.Text + "','" +
                                        dt_pointInfo.Rows[0]["servicePoint_id"] + "',5,'" +
                                        DateTime.Now.ToString() + "')");

                txbox_cardIdRefund.Text = "";
                MessageBox.Show("refund done",
                                                    "information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_buyCard_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_personalInfo = GetData("SELECT * FROM user_data WHERE account='" +
                                                                     txbox_userAccountBuy.Text + "'");
                RunSQLcmd("INSERT INTO card_data(user_id,cardType_id,balance,state) VALUES('" +
                                        dt_personalInfo.Rows[0]["user_id"] + "','" +
                                        dgv_cardId.SelectedRows[0].Cells["cardType_id"].Value + "','0','1')");
                MessageBox.Show("trade done",
                                                    "Information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                //TODO
                DataTable dt_newCard = GetData("SELECT MAX(card_id) AS card_id  FROM card_data");
                RunSQLcmd("INSERT into serviceTrade_record (card_id,servicePoint_id, serviceType_id,time) VALUES ('" +
                                         dt_newCard.Rows[0]["card_id"]+ "','" +
                                        dt_pointInfo.Rows[0]["servicePoint_id"] + "',2,'" +
                                        DateTime.Now.ToString() + "')");
                
                txbox_userAccountBuy.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_cardFixing_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO
                RunSQLcmd("INSERT into serviceTrade_record (card_id,servicePoint_id, serviceType_id,time) VALUES ('" +
                                         txbox_cardIdfix.Text + "','" +
                                        dt_pointInfo.Rows[0]["servicePoint_id"] + "',6,'" +
                                        DateTime.Now.ToString() + "')");
                txbox_cardIdfix.Text = "";
                MessageBox.Show("fix done",
                                                    "information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
