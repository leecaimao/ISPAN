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

namespace _0530期中作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn管理者登入_Click(object sender, EventArgs e)
        {
            managerlogin form管理者登入 = new managerlogin();
            form管理者登入.Show();


            GlobalVar.form主頁 = this;


            
            GlobalVar.form管理者登入 = form管理者登入;

            form管理者登入.Show();
            
            this.Hide();  


        }

        private void btn菜單_Click(object sender, EventArgs e)
        {
            menu form菜單 = new menu();
            form菜單.Show();

            GlobalVar.form主頁 = this;



            GlobalVar.form菜單 = form菜單;

            form菜單.Show();

            this.Hide();



        }


        private void btn會員登入訂購_Click(object sender, EventArgs e)
        {
            login form會員登入 = new login();
            form會員登入.Show();

            GlobalVar.form主頁 = this;



            GlobalVar.form會員登入 = form會員登入;

            form會員登入.Show();

            this.Hide();

         



        }
    }
}
