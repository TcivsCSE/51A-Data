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
using BarcodeService;
using BarcodeService.Enums;

namespace _51
{
    public partial class user : Form
    {

        DataTable dt_PersonalInformation = new DataTable();
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
            MessageBox.Show(cmdstring);
            cn.Open();
            SqlCommand cmd = new SqlCommand(cmdstring, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public user(DataTable dt,SqlConnection connection)
        {
            InitializeComponent();
            cn = connection;
            dt_PersonalInformation = dt;
            
        }       
        private void user_Load(object sender, EventArgs e)
        {
            dgv_cardBalance.DataSource = GetData("SELECT * FROM card_data WHERE user_id='"+dt_PersonalInformation.Rows[0]["user_id"]+"' AND state=1");
            dgv_bill.DataSource = GetData("SELECT * FROM bill WHERE user_id='"+dt_PersonalInformation.Rows[0]["user_id"]+"' AND state=1");
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

        private void btn_showAllCard_Click(object sender, EventArgs e)
        {
            try
            {
                user_Load(sender, e);
                txbox_cardId.Text = "";
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
                DataTable tmp = GetData("SELECT * FROM card_data WHERE card_id='" + txbox_cardId.Text + "' AND user_id='" + dt_PersonalInformation.Rows[0]["user_id"] + "'");
                dgv_cardBalance.DataSource = tmp;
                MessageBox.Show("The balance of this card is "+tmp.Rows[0]["balance"]+"dollar");
                //TODO
                DataTable tmp_usingPoint = GetData("SELECT servicePoint_id FROM service_point WHERE point_name='"+txbox_usingPointName.Text+"'");
                RunSQLcmd("INSERT into cardTrade_record (card_id,servicePoint_id, serviceType_id,time,amount) VALUES ('" +
                                        txbox_cardId.Text+"','"+
                                        tmp_usingPoint.Rows[0]["servicePoint_id"]+"',1,'" +
                                        DateTime.Now.ToString()+"',0)");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_mainCard = GetData("SELECT * FROM card_data WHERE card_id='"+txbox_hostCardId.Text+"'");
                DataTable tmp_subCard = GetData("SELECT * FROM card_data WHERE card_id='" + txbox_subCardId.Text + "'");
                if (Convert.ToInt32(tmp_mainCard.Rows[0]["balance"]) > Convert.ToInt32(txbox_Amount.Text))
                {
                    if (tmp_mainCard.Rows[0]["user_id"].ToString() == dt_PersonalInformation.Rows[0]["user_id"].ToString())
                    {
                        DataTable tmp_usingPoint = GetData("SELECT servicePoint_id FROM service_point WHERE point_name='" + txbox_usingPointName.Text + "'");
                        if (tmp_usingPoint.Rows.Count > 0)
                        {
                            RunSQLcmd("UPDATE card_data " +
                                                    "SET balance='" + (Convert.ToInt32(tmp_mainCard.Rows[0]["balance"]) - Convert.ToInt32(txbox_Amount.Text)).ToString() + "'" +
                                                    "WHERE card_id='" + txbox_hostCardId.Text + "'");
                            RunSQLcmd("UPDATE card_data " +
                                                    "SET balance='" + (Convert.ToInt32(tmp_subCard.Rows[0]["balance"]) + Convert.ToInt32(txbox_Amount.Text)).ToString() + "'" +
                                                    "WHERE card_id='" + txbox_subCardId.Text + "'");
                            MessageBox.Show("transfer successful",
                                                                "information",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information);
                        
                            //TODO
                        
                            RunSQLcmd("INSERT into cardTrade_record (card_id,servicePoint_id, serviceType_id,time,amount) VALUES ('" +
                                                    txbox_hostCardId.Text + "','" +
                                                    tmp_usingPoint.Rows[0]["servicePoint_id"] + "',4,'" +
                                                    DateTime.Now.ToString() + "','" +
                                                    txbox_Amount.Text+"')");
                            RunSQLcmd("INSERT into cardTrade_record (card_id,servicePoint_id, serviceType_id,time,amount) VALUES ('" +
                                                    txbox_subCardId.Text + "','" +
                                                    tmp_usingPoint.Rows[0]["servicePoint_id"] + "',9,'" +
                                                    DateTime.Now.ToString() + "','" +
                                                    txbox_Amount.Text + "')");
                        
                            txbox_hostCardId.Text = "";
                            txbox_subCardId.Text = "";
                            txbox_Amount.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("point not found",
                                                        "information",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("the card is not yours",
                                                            "information",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient balance",
                                                        "information",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_storeValue_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp_usingPoint = GetData("SELECT servicePoint_id FROM service_point WHERE point_name='" + txbox_usingPointName.Text + "'");
                if (tmp_usingPoint.Rows.Count > 0)
                {
                    DataTable tmp_card = GetData("SELECT * FROM card_data WHERE card_id='" + txbox_mainCardId.Text + "'");
                    RunSQLcmd("UPDATE card_data " +
                                           "SET balance='"+(Convert.ToInt32(tmp_card.Rows[0]["balance"])+Convert.ToInt32(txbox_amountStoreValue.Text)).ToString()+"' "+
                                           "WHERE card_id='"+tmp_card.Rows[0]["card_id"]+"'");
                    MessageBox.Show("please pay " + txbox_amountStoreValue.Text + " dollar using " + cbbox_paymentMrnthod.Text);

                    //TODO
                
                    RunSQLcmd("INSERT into cardTrade_record (card_id,servicePoint_id, serviceType_id,time,amount) VALUES ('" +
                                            txbox_mainCardId.Text + "','" +
                                            tmp_usingPoint.Rows[0]["servicePoint_id"] + "',3,'" +
                                            DateTime.Now.ToString() + "','" +
                                            txbox_amountStoreValue.Text + "')");

                    txbox_amountStoreValue.Text = "";
                    txbox_mainCardId.Text = "";
                    cbbox_paymentMrnthod.Text = "";
                    user_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("point not found",
                                                        "information",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tmp = GetData("SELECT * FROM card_data WHERE card_id='" + txbox_payCard.Text + "'");
                if (tmp.Rows[0]["user_id"].ToString() == dt_PersonalInformation.Rows[0]["user_id"].ToString())
                {
                    DataTable tmp_card = GetData("SELECT * FROM card_data WHERE card_id='" + txbox_payCard.Text + "'");
                    if (Convert.ToInt32(dgv_bill.SelectedRows[0].Cells["amount"].Value) <=Convert.ToInt32(tmp_card.Rows[0]["balance"]))
                    {
                        DataTable tmp_usingPoint = GetData("SELECT servicePoint_id FROM service_point WHERE point_name='" + txbox_usingPointName.Text + "'");
                        if (tmp_usingPoint.Rows.Count > 0)
                        {
                            RunSQLcmd("UPDATE bill " +
                                                   "SET state=0 " +
                                                   "WHERE bill_id='"+dgv_bill.SelectedRows[0].Cells["bill_id"].Value+"'");
                            RunSQLcmd("UPDATE card_data " +
                                                   "SET balance='" + (Convert.ToInt32(tmp_card.Rows[0]["balance"]) - Convert.ToInt32(dgv_bill.SelectedRows[0].Cells["amount"].Value)).ToString() + "' " +
                                                   "WHERE card_id='"+txbox_payCard.Text+"'");
                            MessageBox.Show("pay successful",
                                                             "information",
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Information);

                            //TODO 
                            RunSQLcmd("INSERT into cardTrade_record (card_id,servicePoint_id, serviceType_id,time,amount) VALUES ('" +
                                            txbox_payCard.Text + "','" +
                                            tmp_usingPoint.Rows[0]["servicePoint_id"] + "','" +
                                            (Convert.ToInt32(dgv_bill.SelectedRows[0].Cells["menthod_id"].Value)+6).ToString()+"','" +
                                            DateTime.Now.ToString() + "','" +
                                            dgv_bill.SelectedRows[0].Cells["amount"].Value.ToString() + "')");

                            label_amount.Text = "amount:";
                            txbox_payCard.Text = "";
                            user_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("point not found",
                                                                "information",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance",
                                                         "information",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("the card is not yours",
                                                     "information",
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_selectBill_Click(object sender, EventArgs e)
        {
            try
            {
                label_amount.Text = "amount:" + dgv_bill.SelectedRows[0].Cells["amount"].Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
