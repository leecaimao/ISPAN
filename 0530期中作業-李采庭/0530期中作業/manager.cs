using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0530期中作業
{
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            
            lblLoginName.Text = "目前使用者:" + GlobalVar.目前使用者;
        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            membermanage form開啟會員資料管理 = new membermanage();
            form開啟會員資料管理.Show();


            GlobalVar.form管理者介面 = this;



            GlobalVar.form會員資料管理 = form開啟會員資料管理;

            form開啟會員資料管理.Show();

            this.Hide();
        }

        private void btn員工資料管理_Click(object sender, EventArgs e)
        {
            employeemanage form開啟員工管理 = new employeemanage();
            form開啟員工管理.Show();


            GlobalVar.form管理者介面 = this;



            GlobalVar.form員工資料管理 = form開啟員工管理;

            form開啟員工管理.Show();

            this.Hide();


        }

        private void manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form主頁.Show();
        }
    }
}
