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
        DataTable dt_personalInfo = new DataTable();
        DataTable dt_card_information = new DataTable();
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
        public saler()
        {
            InitializeComponent();
            dgv_cardId.DataSource = GetData("SELECT * FROM card_type");
        }
        private void saler_Load(object sender, EventArgs e)
        {

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
                int balance = Convert.ToInt32(GetData("SELECT balance FROM card_data WHERE card_id='" + txbox_cardIdRefund.Text + "'").Rows[0]["balance"]);
                RunSQLcmd("UPDATE card_data " +
                                        "SET state=0" +
                                        "WHERE card_id='" + txbox_cardIdRefund.Text + "'");
                MessageBox.Show("The card has been Deactivate\nPlease refund"+balance.ToString()+"dollar",
                                                    "Information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                txbox_cardIdRefund.Text = "";
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
                dt_personalInfo = GetData("SELECT * FROM user_data WHERE account='" +
                                                                     txbox_userAccountBuy.Text + "'");
                DataTable dt_cardTypeId = new DataTable();
                RunSQLcmd("INSERT INTO card_data(user_id,cardType_id,balance,state) VALUES('" +
                                        dt_personalInfo.Rows[0]["user_id"] + "','" +
                                        txbox_cardTypeIdBuy.Text + "','0','1')");
                MessageBox.Show("trade done",
                                                    "Information",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                txbox_cardTypeIdBuy.Text = "";
                txbox_userAccountBuy.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
