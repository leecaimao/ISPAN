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
    public partial class register : Form
    {


        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
       


        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn建立會員_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt手機號碼.Text != ""))
            {

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into member values( @NewName,@NewPhone,@NewBirthday,@NewAddress,@NewEmail,@NewPasword);";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt手機號碼.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPasword", txt密碼.Text);


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("會員建立成功");


                Form1 form主頁 = new Form1();
                form主頁.Show();

                GlobalVar.form會員註冊 = this;

                GlobalVar.form主頁 = form主頁;

                form主頁.Show();

                this.Hide();



            }
            else
            {
                MessageBox.Show("姓名、電話必須填寫");
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

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form主頁.Show();
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            Form1 form主頁 = new Form1();
            form主頁.Show();

            GlobalVar.form會員註冊 = this;

            GlobalVar.form主頁 = form主頁;

            form主頁.Show();

            this.Hide();
        }
    }
}
