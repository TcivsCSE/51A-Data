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
        //SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
        //                                                                            "AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.IWLYF\\MSSQL\\DATA\\51 - 複製.mdf;" +
        //                                                                            "Integrated Security=True;" +
        //                                                                            "Connect Timeout=30;");
        SqlConnection cn = new SqlConnection("Server=LAPTOP-T4HKALLM\\IWLYF;" +
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
        public user(DataTable dt)
        {
            InitializeComponent();
            dt_PersonalInformation = dt;
        }       
        private void user_Load(object sender, EventArgs e)
        {
            dgv_cardBalance.DataSource = GetData("SELECT * FROM card_data WHERE user_id='"+dt_PersonalInformation.Rows[0]["user_id"]+"'");
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
                dgv_cardBalance.DataSource = GetData("SELECT * FROM card_data WHERE card_id='"+txbox_cardId.Text+"' AND user_id='"+dt_PersonalInformation.Rows[0]["user_id"]+"'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_generateQRcode_Click(object sender, EventArgs e)
        {
            Bitmap qrcode = BarcodeService.QRCode.Generate(DateTime.Now.ToString(), 400, 400, errorCorrectionLevel: ErrorCorrectionLevel.M);
            pb_qrcode.Image = qrcode;
        }
    }
}
