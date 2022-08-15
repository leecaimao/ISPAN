using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace _0530期中作業
{
    public partial class login : Form
    {
        string myDBConnectionString = "";
        string Phone = "";
        string Password = "";

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from member where 電話=@SearchPhone";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            Phone = txt帳號.Text;
            cmd.Parameters.AddWithValue("@SearchPhone", Phone);
            SqlDataReader reader = cmd.ExecuteReader();
            string str帳號 = "";
            string strPassword = "";
            while (reader.Read())
            {
                strPassword = reader["密碼"].ToString();

                str帳號 = Phone;


            }

            reader.Close();
            con.Close();





            if ((txt帳號.Text == str帳號) && (txt密碼.Text == strPassword))
            {
                MessageBox.Show("登入成功");


                GlobalVar.目前使用者 = txt帳號.Text;


                鹽水雞訂購單 form訂購單 = new 鹽水雞訂購單();
                form訂購單.Show();




                GlobalVar.form會員登入 = this;



                GlobalVar.form訂購單 = form訂購單;

                form訂購單.Show();

                this.Hide();




            }
            else
            {
                lbl回應訊息.Text = "輸入帳號密碼錯誤";
            }

            


        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
            //密碼通常從SQL資料庫來
            
        }

        private void btn會員註冊_Click(object sender, EventArgs e)
        {
            register form會員註冊 = new register();
            form會員註冊.Show();




            GlobalVar.form會員登入 = this;



            GlobalVar.form會員註冊 = form會員註冊;

            form會員註冊.Show();

            this.Hide();




        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            Form1 form主頁 = new Form1();
            form主頁.Show();

            GlobalVar.form會員登入 = this;

            GlobalVar.form主頁 = form主頁;

            form主頁.Show();

            this.Hide();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form主頁.Show();
        }
    }
}
