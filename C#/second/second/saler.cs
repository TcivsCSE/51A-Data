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
    public partial class saler : Form
    {
        SqlConnection cn = new SqlConnection();
        DataTable point_information = new DataTable();
        public DataTable sqlcommand(string command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command, cn);
            da.Fill(dt);
            return dt;
        }
        public saler(SqlConnection connection, DataTable tmp)
        {
            InitializeComponent();
            cn = connection;
            point_information = sqlcommand("SELECT * FROM service_point WHERE usingAccount_id='" + tmp.Rows[0]["user_id"]+"'");
        }

        private void saler_Load(object sender, EventArgs e)
        {
            dgv_cardTypeButCard.DataSource = sqlcommand("SELECT * FROM card_type");
        }

        private void btn_buycard_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_account = sqlcommand("SELECT * FROM user_data WHERE account='" + tb_accountBuyCard.Text + "'");
                sqlcommand("INSERT into card_data(user_id,cardType_id,balance,state) VALUES('" + tmp_account.Rows[0]["user_id"] + "','" + dgv_cardTypeButCard.Rows[0].Cells["cardType_id"].Value.ToString() + "',0,1)");
                DataTable tmp_card = sqlcommand("SELECT MAX(card_id) AS card_id FROM card_data");
                sqlcommand("INSERT into serviceTrade_record(card_id,servicePoint_id,serviceType_id,time) VALUES('" + tmp_card.Rows[0]["card_id"] + "','" + point_information.Rows[0]["servicePoint_id"] + "',2,'" + DateTime.Now.ToString() + "')");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refundCard_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE card_data SET state=0 WHERE card_id='" + tb_cardIdRefundCard.Text + "'");
                MessageBox.Show("refund "+sqlcommand("SELECT balance FROM card_data WHERE card_id='" + tb_cardIdRefundCard.Text + "'").Rows[0]["balance"].ToString()+" dollar");
                sqlcommand("UPDATE card_data SET balance=0 WHERE card_id='" + tb_cardIdRefundCard.Text + "'");
                sqlcommand("INSERT into serviceTrade_record(card_id,servicePoint_id,serviceType_id,time) VALUES('" + tb_cardIdRefundCard.Text + "','" + point_information.Rows[0]["servicePoint_id"] + "',5,'" + DateTime.Now.ToString() + "')");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_searchCard_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_card = sqlcommand("SELECT * FROM card_data WHERE card_id = '" + tb_cardFixCard.Text+"'");
                if (tmp_card.Rows.Count > 0)
                {
                    tb_userIdFixCard.Text = tmp_card.Rows[0]["user_id"].ToString();
                    tb_cardTypeIdFixCard .Text = tmp_card.Rows[0]["cardType_id"].ToString();
                    tb_stateFixCard.Text = tmp_card.Rows[0]["state"].ToString();
                    tb_balanceFixCard.Text = tmp_card.Rows[0]["balance"].ToString();

                }
                else
                {
                    MessageBox.Show("card not exist");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_applyFixCard_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommand("UPDATE card_data SET user_id='" + tb_userIdFixCard.Text + "',cardType_id='" + tb_cardTypeIdFixCard.Text + "',state='" + tb_stateFixCard.Text + "',balance='" + tb_balanceFixCard.Text + "' WHERE card_id='" + tb_cardFixCard.Text + "'");
                sqlcommand("INSERT into serviceTrade_record(card_id,servicePoint_id,serviceType_id,time) VALUES('" + tb_cardFixCard.Text + "','" + point_information.Rows[0]["servicePoint_id"] + "',6,'" + DateTime.Now.ToString() + "')");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
