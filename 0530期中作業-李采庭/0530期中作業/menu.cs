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
    public partial class menu : Form
    {
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

        public menu()
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


                    lBoxmenu.Items.Add(reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2) + " " + reader.GetValue(3));

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
            
            reader.Close();
            con.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            SQL();
        }

        private void lBoxmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selIndex = lBoxmenu.SelectedIndex;
                ID = listID[selIndex];
                fenlei = listfenlei[selIndex];
                name = listname[selIndex];
                Price = listPrice[selIndex];
            }
            catch
            { }


           
        }

        private void btn回首頁_Click(object sender, EventArgs e)
        {
            Form1 form主頁 = new Form1();
            form主頁.Show();

            GlobalVar.form菜單 = this;

            GlobalVar.form主頁 = form主頁;

            form主頁.Show();

            this.Hide();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form主頁.Show();
        }
    }
}
