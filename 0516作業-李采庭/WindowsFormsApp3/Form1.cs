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
    public partial class Form1 : Form
    {
        //類別變數
        List<string> list品項名稱 = new List<string>(); //key 字串
        List<int> list品項價格 = new List<int>(); //value
        List<string> list甜度= new List<string>();  //字串
        List<string> list冰塊= new List<string>();  //字串
        List<string> list加料= new List<string>();  //字串
        List<int> list加料價格= new List<int>();

        //作業:加料價格
        ADD[] add = new ADD[5];         //配料用陣列


        //類別變數(私有欄位)的宣告
        int 品項杯數 =0;
        int 單價 =0;
        int 品項總價 =0;
        string 訂購品項="";   //再寫入全域變數list
        string 甜度 = "";
        string 冰塊 = "";
        string 加料 = "";
        int 加料價格 = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        

            list品項名稱.Add("紅茶");
            list品項名稱.Add("綠茶");
            list品項名稱.Add("麥茶");
            list品項名稱.Add("烏龍茶");
            list品項名稱.Add("青茶");
            list品項名稱.Add("東方美人茶");
            list品項名稱.Add("阿里山冰茶");
            list品項名稱.Add("藍莓果粒茶");
            list品項名稱.Add("紅茶鮮奶");
            list品項名稱.Add("綠茶鮮奶");
            list品項名稱.Add("烏龍茶鮮奶");
            list品項名稱.Add("青茶鮮奶");

            //value
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(40);
            list品項價格.Add(40);
            list品項價格.Add(40);
            list品項價格.Add(50);
            list品項價格.Add(50);
            list品項價格.Add(50);
            list品項價格.Add(50);


            //配料用陣列
            add[0] = new ADD(10,"珍珠");
            add[1] = new ADD(10,"波霸");
            add[2] = new ADD(10,"粉角");
            add[3] = new ADD(10, "芋圓");
            add[4] = new ADD(10, "西米露");


            for (int i = 0; i <= add.GetUpperBound(0); i++)
            {               
                
             cBox配料.Items.Add(add[i].Item +"  "+@"$"+add[i].Price);                    
                
            }





            //用foreach把list取出 加到listbox 再加進item(list)
            foreach (string itemName in list品項名稱)
            {
                lBox冷飲品項.Items.Add(itemName);
            }


            //lBox冷飲品項.SelectedIndex = 1; //預選 預選之後內容也要指定相對應內容 變數要指定內容

            品項杯數 = 1;
            txt杯數.Text = 品項杯數.ToString();


            //甜度
            list甜度.Add("正常");
            list甜度.Add("半糖");
            list甜度.Add("少糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");
            foreach (string itemName in list甜度)
            {
                cBox甜度.Items.Add(itemName);         //也可做預選 預選之後內容也要指定相對應內容 變數要指定內容
            }
            //再到cBox甜度加入甜度的變數




            //冰塊
            list冰塊.Add("正常");
            list冰塊.Add("少冰");
            list冰塊.Add("微冰");
            list冰塊.Add("去冰");
            list冰塊.Add("常溫");
            list冰塊.Add("熱");


            foreach (string itemName in list冰塊)
            {
                cBox冰塊.Items.Add(itemName);         //也可做預選 預選之後內容也要指定相對應內容 變數要指定內容
            }
            //再到cBox冰塊加入冰塊的變數



            //加料(有價格)


        }

        private void lBox冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lBox冷飲品項.SelectedIndex;  //   user選到的索引值
            訂購品項 = list品項名稱[selIndex];
            單價= list品項價格[selIndex];

            cBox冰塊.Text = "";       //記得要在轉成字串之前
            cBox甜度.Text = "";
            cBox配料.Text = "";

          

            lbl單價.Text = 單價.ToString() + "元";
            品項總價 = 品項杯數 * GetaddPrice();    //加入方法
            lbl品項總價.Text = 品項總價.ToString() + "元";

        }






        private void cBox甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox甜度.SelectedIndex;
            甜度 = list甜度[selIndex];

        }

        private void cBox冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cBox冰塊.SelectedIndex;
            冰塊 = list冰塊[selIndex];
        }

        private void cBox配料_SelectedIndexChanged(object sender, EventArgs e)
        {//要做key value因為有價錢
            int selIndex = cBox配料.SelectedIndex;
            加料 = add[selIndex].Item;
            加料價格 = add[selIndex].Price;

            品項總價 = 品項杯數 * GetaddPrice();
            lbl品項總價.Text = 品項總價.ToString() + "元";
        }

        //寫個方法把配料抓出來 如果有加配料 不然就是原本的單價
        int GetaddPrice()   
            //獲取int的方法 因為方法沒有回傳值 要記得return
           
        {
            int Price;
            if (cBox配料.Text != "")
            {
                Price = 單價 + 加料價格;
                return Price;
            }
            else             
            {
                Price = 單價;
                return Price;
            }


        }


        private void txt杯數_TextChanged(object sender, EventArgs e)
        {
            
            /*品項杯數 = Convert.ToInt32(txt杯數.Text);
            品項總價 = 品項杯數 * 單價;
            lbl品項總價.Text = 品項總價.ToString() + "元";

            //作業:品項杯數避免與改正輸入錯誤 */
           
            try
            {
                品項杯數 = Convert.ToInt32(txt杯數.Text);
                品項總價 = 品項杯數 * GetaddPrice();
                lbl品項總價.Text = 品項總價.ToString() + "元";
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.ToString(), "字串為空值");
            }



        }








        private void btn加入訂購單_Click(object sender, EventArgs e)
        {//ArrayList
            //作業請用自訂類別
            //品項訂購資訊.Add(訂購品項);
            //品項訂購資訊.Add(單價);
            //品項訂購資訊.Add(品項杯數);     
            //品項訂購資訊.Add(品項總價);   
            //品項訂購資訊.Add(甜度);
            //品項訂購資訊.Add(冰塊);
            //品項訂購資訊.Add(加料);
            //品項訂購資訊.Add(加料價格);
          
            


            //因為我不想用預設 所以想設若是沒有選擇甜度冰塊就不能加入
            //防呆 要輸入聯絡資訊和甜度冰塊
            if (txt訂購人電話.Text.Length!=10)
            {
                MessageBox.Show("請輸入正確聯絡資訊");
            }

            else if(txt訂購人電話.Text.Length == 10)
            {
                if (cBox冰塊.Text == ""&& cBox甜度.Text == "")
                {
                    MessageBox.Show("請選擇甜度、冰塊");
                }
                else if (cBox甜度.Text == "")
                {
                    MessageBox.Show("請選擇甜度");
                }
                else if (cBox冰塊.Text == "")
                {
                    MessageBox.Show("請選擇冰塊");
                }
                else
                {
                    Drink 品項訂購資訊 = new Drink(訂購品項, 單價, 甜度, 冰塊, 品項杯數, 加料, 加料價格);
                    GlobalVar.list訂購品項列表.Add(品項訂購資訊);
                    GlobalVar.訂購人資訊 = txt訂購人電話.Text;

                    MessageBox.Show("已加入結帳單");
                }



                
            }


        }




        private void btn查看訂購單_Click(object sender, EventArgs e)
        {

            GlobalVar.form菜單 = this;    //指定到form菜單


            //點了要開啟Form2
            Form2 form結帳單 = new Form2();
            GlobalVar.form結帳單 = form結帳單;

            form結帳單.Show();
            //開啟之後隱藏
            this.Hide();    //自身類別用this 也可以直接Hide();

            //關掉2後又再打開1 先到GlobalVar 加入2個全域變數 存form1.form2的物件

        
        }



        //建立杯數限制 只能輸入數字的方法
        private void txt杯數_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar.CompareTo('0') < 0 || e.KeyChar.CompareTo('9') > 0 )&& e.KeyChar!= 8)
            {
                e.Handled = true;
            }

        }












    }
}
