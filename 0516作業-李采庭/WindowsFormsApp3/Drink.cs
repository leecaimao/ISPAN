using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Drink
    {
        #region 內容
        public string Item;
        public int Price;
        public string Sugar;
        public string Ice;
        public int Number;
        public int Total;
        public string AddItem;
        public int AddItemprice;    //跟AddItem是一起的

        #endregion


        public Drink(string Item, int Price, string Sugar, string Ice, int Number,string AddItem, int AddItemprice)
        {
            this.Item = Item;
            this.Price = Price;
            this.Sugar = Sugar;
            this.Ice = Ice;
            this.Number = Number;
            this.AddItem = AddItem;
            this.AddItemprice = AddItemprice;

            this.Total = (Price + AddItemprice)* Number;         
          

        }





        

     










    }
}
