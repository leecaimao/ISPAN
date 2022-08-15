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

namespace _0530期中作業
{
    public partial class membermanage : Form
    {

        SqlConnectionStringBuilder scsb;     
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>();  //進階搜尋結果;


        public membermanage()
        {
            InitializeComponent();
        }


        private void membermanage_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";    
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;                 
            myDBConnectionString = scsb.ToString();         
                     
            產生會員資料列表();
        }


        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select Id as ID,姓名,電話,生日,地址,email,密碼 from member";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) 
            {

                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            reader.Close();
            con.Close();

        }




        private void btn新增會員_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt手機號碼.Text != "")&& (txt密碼.Text != ""))
            {

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into member values( @NewName,@NewPhone,@NewBirthday,@NewAddress,@NewEmail,@NewPassword);";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt手機號碼.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                
                
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料新增成功");


            }
            else
            {
                MessageBox.Show("姓名、電話、密碼 必須填寫");
            }
        }

        private void btn刪除會員_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from member where ID=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                lblID.Text = "";
                txt姓名.Clear();
                txt手機號碼.Clear();
                dtp生日.Value = DateTime.Now;
                txt地址.Clear();
                txtEmail.Clear();
                txt密碼.Clear();
                
                

                MessageBox.Show($"{rows} 筆資料刪除成功");

            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);


            if ((intID > 0) && (txt姓名.Text != "") && (txt手機號碼.Text != "") && (txt密碼.Text != ""))

            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update member set 姓名=@NewName,電話=@NewPhone ,生日=@NewBirthday,地址=@NewAddress,Email=@NewEmail,密碼=@NewPassword  where ID=@SearchID;";                        //ID=@SearchID作為查詢條件用 新增不需要查詢條件 修改才要
                SqlCommand cmd = new SqlCommand(strSQL, con);


                //參數式 和新增資料的一樣
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt手機號碼.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                
                

                //回傳異動的資料筆數  只執行不做查詢
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows} 筆資料修改成功");

            }

        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt手機號碼.Clear();
            dtp生日.Value = DateTime.Now;
            txt地址.Clear();
            txtEmail.Clear();
            txt密碼.Clear();


        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select* from member where 姓名 like @SearchName;"; 
                SqlCommand cmd = new SqlCommand(strSQL, con);               
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");                
                SqlDataReader reader = cmd.ExecuteReader();

           
                if (reader.Read())
                {
                    lblID.Text = string.Format("{0}", reader["Id"]);
                    txt姓名.Text = string.Format("{0}", reader["姓名"]);
                    txt手機號碼.Text = string.Format("{0}", reader["電話"]);
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    txt地址.Text = string.Format("{0}", reader["地址"]);
                    txtEmail.Text = string.Format("{0}", reader["Email"]);
                    txt密碼.Text = string.Format("{0}", reader["密碼"]);
                    
                    

                }
                else
                {
                    MessageBox.Show("查無此人");
                    lblID.Text = "";
                    txt姓名.Clear();
                    txt手機號碼.Clear();
                    dtp生日.Value = DateTime.Now;
                    txt地址.Clear();
                    txtEmail.Clear();
                    txt密碼.Clear();

                }

                reader.Close();
                con.Close(); 

            }
            else
            {
                MessageBox.Show("請輸入姓名關鍵字搜尋");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)    
            {
                string strselID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                int intSelId = 0;
                bool isID = Int32.TryParse(strselID, out intSelId);


                if (isID == true)

                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "select * from member where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = string.Format("{0}", reader["Id"]);
                        txt姓名.Text = string.Format("{0}", reader["姓名"]);
                        txt手機號碼.Text = string.Format("{0}", reader["電話"]);
                        dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                        txt地址.Text = string.Format("{0}", reader["地址"]);
                        txtEmail.Text = string.Format("{0}", reader["email"]);
                        txt密碼.Text = string.Format("{0}", reader["密碼"]);


                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        lblID.Text = "";
                        txt姓名.Clear();
                        txt手機號碼.Clear();
                        dtp生日.Value = DateTime.Now;
                        txt地址.Clear();
                        txtEmail.Clear();
                        txt密碼.Clear();

                    }
                    reader.Close();
                    con.Close();

                }
            }
            }

        private void membermanage_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form主頁.Show();
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            Form1 form主頁 = new Form1();
            form主頁.Show();

            GlobalVar.form會員資料管理 = this;

            GlobalVar.form主頁 = form主頁;

            form主頁.Show();

            this.Hide();
        }
    }
}
