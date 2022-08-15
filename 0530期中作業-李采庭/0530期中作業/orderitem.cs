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
    public partial class orderitem : Form
    {

        string myDBConnectionString = "";

        

        List<string> listsalt = new List<string>();
        List<string> listpepper = new List<string>();
        List<string> listspicy = new List<string>();
        List<string> listsour = new List<string>();
        List<string> listoil = new List<string>();
        List<string> listADD = new List<string>();
        List<allinfo> listallinfo = new List<allinfo>();

        int ID = 0;
        string fenlei = "";
        string Item = "";
        int ItemPrice = 0;
        string salt = "";
        string pepper = "";
        string spicy = "";
        string sour = "";
        string oil = "";
        string ADD = "";


        int int總價 = 0;
        int sum = 0;

        public orderitem()
        {
            InitializeComponent();
        }

        


        private void orderitem_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();




            foreach (allinfo 訂購品項 in GlobalVar.list訂購品項列表 )
            {

                int id = (int)(訂購品項.ID);   
                string fenlei = (string)(訂購品項.類別);
                string name = (string)(訂購品項.名稱);
                int price = (int)(訂購品項.價格);


                string str單品資訊 = string.Format("{0} {1} {2} {3}元 ", id, fenlei, name, price);

                lBoxALL.Items.Add(str單品資訊);   

            }




            計算訂單總價();//這
            lbl訂單總價.Text = "總計" + sum.ToString() + "元";//這






            listsalt.Add("正常");
            listsalt.Add("少鹽");
            listsalt.Add("不加");

            foreach (string itemName in listsalt)
            {
                cBox鹹度.Items.Add(itemName);
            }

            listpepper.Add("正常");
            listpepper.Add("少胡椒");
            listpepper.Add("不加");

            foreach (string itemName in listpepper)
            {
                cBox胡椒粉.Items.Add(itemName);
            }


            listspicy.Add("大辣");
            listspicy.Add("中辣");
            listspicy.Add("小辣");
            listspicy.Add("微辣");
            listspicy.Add("不加");

            foreach (string itemName in listspicy)
            {
                cBox辣度.Items.Add(itemName);
            }


            listsour.Add("正常");
            listsour.Add("少量");
            listsour.Add("不加");

            foreach (string itemName in listsour)
            {
                cBox酸度.Items.Add(itemName);
            }


            listoil.Add("正常");
            listoil.Add("少量");
            listoil.Add("不加");

            foreach (string itemName in listoil)
            {
                cBox香油.Items.Add(itemName);
            }

            listADD.Add("全加");
            listADD.Add("+蔥");
            listADD.Add("+蒜");
            listADD.Add("+洋蔥");
            listADD.Add("蔥+蒜");
            listADD.Add("蔥+洋蔥");
            listADD.Add("蒜+洋蔥");
            listADD.Add("全不加");

            foreach (string itemName in listADD)
            {
                cBox配料.Items.Add(itemName);
            }
            


            lbl訂購人手機號碼.Text = "訂購人手機號碼:" + GlobalVar.目前使用者;



        }



        void 計算訂單總價()
        {
            sum = 0;


            foreach (allinfo a in GlobalVar.list訂購品項列表)
            {
                int total = a.價格;

                sum += total;
            }






        }


            private void lBoxALL_SelectedIndexChanged(object sender, EventArgs e)
        {
                


        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lBoxALL.SelectedIndex >= 0)
            {
                int selIndex = lBoxALL.SelectedIndex;
                lBoxALL.Items.RemoveAt(selIndex);
                GlobalVar.list訂購品項列表.RemoveAt(selIndex);
                計算訂單總價();//這
                lbl訂單總價.Text = "總計" + sum.ToString() + "元";//這
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btn移除所有品項_Click(object sender, EventArgs e)
        {
            lBoxALL.Items.Clear();
            GlobalVar.list訂購品項列表.Clear();
            計算訂單總價();//這
            lbl訂單總價.Text = "總計" + sum.ToString() + "元";//這
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {
            GlobalVar.form主頁.Show();

            this.Close();
        }

        private void btn結帳_Click(object sender, EventArgs e)    //txt檔
        {
            string str檔案路徑 = @"D:\C#.net\WindowsFormsApp3"; 
                                                        
            System.Random mRnd = new Random();
            int myNum = mRnd.Next(1000, 9999); 
            
            string str檔名 = DateTime.Now.ToString("yy年MM月dd日HH時mm分ss秒") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*txt"; 


            
            DialogResult R = sfd.ShowDialog();  

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;

            }
            else
            {
                return; 

            }


            List<string> listOrderInfo = new List<string>();
            listOrderInfo.Add("****************鹽水雞訂購單****************");
            listOrderInfo.Add("--------------------------------------");
            listOrderInfo.Add("訂購時間：" + DateTime.Now.ToString() );
            listOrderInfo.Add("訂購人：" + GlobalVar.目前使用者);
            listOrderInfo.Add("--------------------------------------");

            foreach (allinfo 訂購品項 in GlobalVar.list訂購品項列表)
            {

                int id = (int)(訂購品項.ID);
                string fenlei = (string)(訂購品項.類別);
                string name = (string)(訂購品項.名稱);
                int price = (int)(訂購品項.價格);


                string str單品資訊 = string.Format("{0} {1} {2} {3}元 ", id, fenlei, name, price);

                listOrderInfo.Add(str單品資訊);

            }

            listOrderInfo.Add(" ");
            listOrderInfo.Add(" ");
            listOrderInfo.Add(" ");

            listOrderInfo.Add(salt+" "+ pepper+" "+ spicy+" "+ sour+" "+ oil+" "+ ADD);

         

            listOrderInfo.Add("--------------------------------------");
            listOrderInfo.Add("總價： " + sum+" 元");
            listOrderInfo.Add("****************謝謝光臨****************");

            System.IO.File.WriteAllLines(str完整檔案路徑, listOrderInfo, Encoding.UTF8);
            MessageBox.Show("存檔成功");


        }

        private void cBox鹹度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox鹹度.SelectedIndex;
            salt = listsalt[selIndex];
        }

        private void cBox胡椒粉_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox胡椒粉.SelectedIndex;
            pepper = listpepper[selIndex];
        }

        private void cBox辣度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox辣度.SelectedIndex;
            spicy = listspicy[selIndex];
        }

        private void cBox酸度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox酸度.SelectedIndex;
            sour = listsour[selIndex];
        }

        private void cBox香油_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox香油.SelectedIndex;
            oil = listoil[selIndex];
        }

        private void cBox配料_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox配料.SelectedIndex;
            ADD = listADD[selIndex];
        }

        private void orderitem_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form主頁.Show();
        }
    }
}
