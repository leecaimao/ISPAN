using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0414practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //便當選單 輸入便當名字 告訴使用者有無販售.此便當多少錢
            //建立二維陣列.string陣列.儲存便當名稱價格.做搜尋
            //至少有10種便當.string[20便當最多的種類,2名稱.價格(便當的屬性有2個)]--便當名稱價格

            string[,] BB = 
            { 
                {"排骨便當","70"},
                {"雞腿便當","90"},
                {"黑胡椒豬排便當","75"},
                {"土魠魚便當","80"},
                {"滷雞腿便當","90"},
                {"宮保雞丁便當","75"},
                {"虱目魚肚便當","100"},
                {"三杯雞便當","70"},
                {"滷肉便當","75"},
                {"肉燥便當","60"},
            };

           


            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("   ======今天吃什麼扁冬咧======");
            Console.WriteLine("=================================");


            //跟長方形有關
            for (int i = 0; i < BB.GetUpperBound(0); i++)   //0是第一個的位置
            {
                if(i<BB.GetUpperBound(0))
                {
                    Console.WriteLine("{0}",BB[i,0]);
                }

            }



            Console.WriteLine("=================================");
            Console.WriteLine("請輸入便當名稱(輸入完成後按Enter)");
            Console.WriteLine("=================================");


            string strBB = Console.ReadLine();
            bool isNOBB = false;
            for (int i = 0; i < BB.GetUpperBound(0); i++) 
            {
                if (BB[i,0]==strBB)
                {
                    Console.WriteLine("您的選擇為:" + BB[i, 0] + "，價錢為:" + BB[i, 1]);
                    isNOBB = true;
                    break;
                }
            }

            if (isNOBB == false)
            {
                Console.WriteLine("沒有此選項，請重新輸入");
            }
            else
            {
                Console.WriteLine("販售中");
            }



            Console.WriteLine("------------------------");
            Console.WriteLine("按任意鍵結束程式");
            Console.ReadKey();















        }
    }
}
