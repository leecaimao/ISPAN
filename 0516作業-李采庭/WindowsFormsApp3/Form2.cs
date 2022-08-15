using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//加arraylist的命名空間

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        bool is計算稅金 = false;    //預設是不算稅金
        //折扣活動
        int int折扣活動代碼 = 0;
        int int總價 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chkTax.Checked = true;
            is計算稅金 = true;



            lbl訂購人資料.Text = GlobalVar.訂購人資訊;

            foreach (Drink 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {//這裡是區域變數list
             //要和ArrayList順序一樣 因為有索引值問題
                string 訂購品項 = 訂購品項資訊.Item;   //Convert.ToString(訂購品項資訊[0]);  
                int 單價 = 訂購品項資訊.Price;
                int 品項杯數 = 訂購品項資訊.Number;
                int 品項總價 = 訂購品項資訊.Total;
                string 甜度 = 訂購品項資訊.Sugar;
                string 冰塊 = 訂購品項資訊.Ice;
                string 加料 = 訂購品項資訊.AddItem;
                int 加料價格 = 訂購品項資訊.AddItemprice;

                //string str單品資訊 = string.Format("{0} {1}元 數量:{2}杯 總價:{3}元 {4} {5} {6} {7}元",訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);
                
                string str單品資訊 = string.Format("{0}  {1}元 {4} {5} {6} +{7}元 數量:{2}杯 總價:{3}元",訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

                lBox訂購品項列表.Items.Add(str單品資訊);      //lBox只能加字串


                int總價 = int總價 + 品項總價;   //int總價 = 0;後面用foreach是一筆一筆加



            }
            計算訂單總價();
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lBox訂購品項列表.SelectedIndex>=0)
            {
                int selIndex = lBox訂購品項列表.SelectedIndex;
                lBox訂購品項列表.Items.RemoveAt(selIndex);
                GlobalVar.list訂購品項列表.RemoveAt(selIndex);
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }

        }


        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lBox訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項列表.Clear();
            計算訂單總價();
        }


        //計算訂單總價
        void 計算訂單總價()
        {
            //作業:計算訂單總價 顯示在標籤

            double sum = 0;
            double tax = 1.05;


            if (is計算稅金)
            {
                sum = int總價 * tax;

            }
            else
            {
                sum = int總價;
            }


            lbl訂購單總價.Text = Math.Ceiling(sum).ToString();
            //原本是數字轉成字串到label

        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)  //boolean
        {
            if (chkTax.Checked==true)
            {
                is計算稅金 = true;
               

            }
            else
            {
                is計算稅金 = false;
                
            }
            計算訂單總價();
        }

        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)  //用整數(1or2or3)紀錄要哪個活動
        {//加分題
            int折扣活動代碼 = 101;
            計算訂單總價();
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {//加分題
            int折扣活動代碼 = 102;
            計算訂單總價();
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {//加分題
            int折扣活動代碼 = 103;
            計算訂單總價();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單.Show();
            
            
            
            this.Close();
            //讓form1出現  透過全域變數找到form1


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {//攔截會關閉的事件 才不會被關閉後變成記憶體洩漏(memory leak) 就需要重開機     //FormClosing表單關閉前
            GlobalVar.form菜單.Show();


        }

        private void btn儲存訂單_Click(object sender, EventArgs e)
        {//預設檔案儲存位置
            /*string str檔案路徑 = @"D:\C#.net\WindowsFormsApp3"; //@忽略特殊符號的影響
                                                            //針對檔案命名 日期時間+隨機變數random
            System.Random mRnd = new Random();
            int myNum = mRnd.Next(1000, 9999);  //傳回四位數整數
            //合成檔名
            string str檔名 = DateTime.Now.ToString("yy年MM月dd日HH時mm分ss秒") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();  
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*txt"; //附檔名過濾器 |是任意字元


            //定義變數
            DialogResult R = sfd.ShowDialog();  //獨佔模式 ShowDialog開啟form2之後就不能切回form1
            //R是user選的結果 回傳值 存在R這物件裡

            if(R==DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;

            }
            else
            {
                return; //使用者不存檔 停止執行

            }



            //訂單內容存檔
            //列印訂購單
            List<string> List訂單資訊 = new List<string>();
            List訂單資訊.Add("****************冷飲店訂購單****************");
            List訂單資訊.Add("------------------------------------------");
            List訂單資訊.Add("訂購時間:"+DateTime.Now.ToString()+"訂購人:"+GlobalVar.訂購人資訊);
            List訂單資訊.Add("------------------------------------------");
            List訂單資訊.Add("<<<<<訂購品項>>>>>");

            foreach (ArrayList 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {
                string 訂購品項 = (string)(訂購品項資訊[0]);    
                int 單價 = (int)(訂購品項資訊[1]);
                int 品項杯數 = (int)(訂購品項資訊[2]);
                int 品項總價 = (int)(訂購品項資訊[3]);
                string 甜度 = (string)(訂購品項資訊[4]);
                string 冰塊 = (string)(訂購品項資訊[5]);
                string 加料 = (string)(訂購品項資訊[6]);
                int 加料價格 = (int)(訂購品項資訊[7]);

                string str單品資訊 = string.Format("{0} {1}元 數量:{2}杯 總價:{3}元 {4} {5} {6} {7}元", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

                List訂單資訊.Add(str單品資訊);     

            }
            List訂單資訊.Add("------------------------------------------");
            List訂單資訊.Add("折扣:" + "買二送一"+"稅金:"+"35"+"元");
            List訂單資訊.Add("總價:"+int總價);
            List訂單資訊.Add("------------------------------------------");
            List訂單資訊.Add("***************謝謝光臨********************");


            //寫進檔案  WriteAllLines把List元素寫入
            System.IO.File.WriteAllLines(str完整檔案路徑, List訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");  */


        }
    }
}
