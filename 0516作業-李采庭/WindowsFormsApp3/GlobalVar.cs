using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;   //加arraylist的命名空間

namespace WindowsFormsApp3
{
    class GlobalVar
    {
        public static string 訂購人資訊 = "";
        public static List<Drink> list訂購品項列表 = new List<Drink>();
        //作業規格:品項資訊要由ArrayList改寫成自訂類別 建立新的Class (EX:甜度冰塊加料)


        //加入2個全域變數 存form1.form2的物件
        public static Form1 form菜單;
        public static Form2 form結帳單;

      
       





    }
}
