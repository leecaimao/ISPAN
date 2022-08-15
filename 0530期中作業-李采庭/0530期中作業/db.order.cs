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
    public partial class 鹽水雞訂購單 : Form

    {
        string 訂購人資訊 = "";
        string myDBConnectionString = "";
        

            


        List<int> listID = new List<int>();
        List<string> listfenlei = new List<string>();
        List<string> listname = new List<string>();
        List<int> listPrice = new List<int>();

   
        List<allinfo> listallinfo = new List<allinfo>();
        

        int ID = 0;
        string fenlei = "";
        string name = "";
        int Price = 0;
        int pcs = 0;

        int Total = 0;
        int sum = 0;
        




        public 鹽水雞訂購單()
        {
            InitializeComponent();
        }

        void SQL()
        {
            
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from item";
            SqlCommand cmd = new SqlCommand(strSQL, con);           
            SqlDataReader reader = cmd.ExecuteReader();
            allinfo A;
            int i = 0;
            while (reader.Read())
            {
                try
                {
                   
            
                lBox品項.Items.Add(reader.GetValue(0) +" "+ reader.GetValue(1) + " " + reader.GetValue(2)+" "+ reader.GetValue(3));

                    listID.Add((int)reader["產品編號"]);
                    listfenlei.Add((string)reader["產品類別"]);
                    listname.Add((string)reader["產品名"]);
                    listPrice.Add((int)reader["產品價格"]);


                
               
                i += 1;
                }
                catch (Exception e)
                {

                }
            }
            Console.WriteLine("讀取{0}筆資料",listID.Count);
            reader.Close();
            con.Close();
        }

      


        private void order_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();


      
            SQL();

            lbl訂購人手機號碼.Text = "訂購人手機號碼:" + GlobalVar.目前使用者;



           

        }


        

        private void lBox品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selIndex = lBox品項.SelectedIndex;
                ID = listID[selIndex];
                fenlei = listfenlei[selIndex];
                name = listname[selIndex];
                Price = listPrice[selIndex];
            }
            catch
            { }



           


        }



        private void btn加入訂購單_Click(object sender, EventArgs e)
        {


            allinfo add = new allinfo(ID, fenlei, name, Price,pcs);
            GlobalVar.list訂購品項列表.Add(add);
            MessageBox.Show("已加入訂購單");


           

        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            GlobalVar.form訂購單 = this;    


            orderitem form結帳單 = new orderitem();
            GlobalVar.form結帳單 = form結帳單;

            form結帳單.Show();
          
            this.Hide();    

        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            Form1 form主頁 = new Form1();
            form主頁.Show();

            GlobalVar.form訂購單 = this;

            GlobalVar.form主頁 = form主頁;

            form主頁.Show();

            this.Hide();
        }
    }
}
