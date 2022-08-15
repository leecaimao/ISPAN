using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 威力彩_李采庭
{
    public partial class Form1 : Form
    {
        List<int> nums_list = new List<int>();
        int sp_num = 0;
        List<int> res_nums_list = new List<int>();
        int res_sp_num = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn電腦選號_Click(object sender, EventArgs e)
        {
            textBox1產生隨機數字.Text = "";
            nums_list = GenerateNumsList();

            foreach (int i in nums_list)
            {
                textBox1產生隨機數字.Text += (i + "、");
            }
            sp_num = new Random().Next(1, 8);

            textBox1產生隨機數字.Text += sp_num;

        }


        private List<int> GenerateNumsList()
        {
            List<int> nums = new List<int>();
            while (nums.Count() < 6)
            {
                int num = new Random().Next(1, 38);
                if (!nums.Contains(num))
                {
                    nums.Add(num);
                }
            }
            nums.Sort();

            return nums;
        }

        private void ShowNums()
        {
            textBox1.Text = "";
            foreach (int i in nums_list)
            {
                textBox1.Text += (i + "、");
            }
            if (sp_num != 0)
            {
                textBox1.Text += sp_num;
            }
        }

        




        private void btn清除_Click(object sender, EventArgs e)
        {
            nums_list.Clear();
            sp_num = 0;
            ShowNums();

            textBox2.Text = "";
            textBox1產生隨機數字.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 1;
            if (!nums_list.Contains(n)&&nums_list.Count()<6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 2;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 3;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = 4;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = 5;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = 6;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = 7;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = 8;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = 9;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int n = 10;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int n = 11;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int n = 12;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int n = 13;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int n = 14;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int n = 15;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int n = 16;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int n = 17;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int n = 18;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int n = 19;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int n = 20;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int n = 21;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int n = 22;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int n = 23;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int n = 24;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int n = 25;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int n = 26;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int n = 27;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int n = 28;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int n = 29;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int n = 30;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int n = 31;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int n = 32;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int n = 33;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int n = 34;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int n = 35;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int n = 36;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int n = 37;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int n = 38;
            if (!nums_list.Contains(n) && nums_list.Count() < 6)
            {
                nums_list.Add(n);
            }
            nums_list.Sort();
            ShowNums();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            sp_num = 1;
            ShowNums();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            sp_num = 2;
            ShowNums();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            sp_num = 3;
            ShowNums();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            sp_num = 4;
            ShowNums();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            sp_num = 5;
            ShowNums();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            sp_num = 6;
            ShowNums();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            sp_num = 7;
            ShowNums();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            sp_num = 8;
            ShowNums();
        }

        private void btn對獎_Click(object sender, EventArgs e)
        {
            res_nums_list = GenerateNumsList();
            res_sp_num = new Random().Next(1, 8);
            textBox2.Text = "";
            foreach (int i in res_nums_list)
            {
                textBox2.Text += (i + "、");     //1~6個號碼
            }          
            
            textBox2.Text += res_sp_num;  //特別號
            

            int count = 0;
            bool sp_flag = false;
            foreach (int i in nums_list)
            {
                if (res_nums_list.Contains(i))
                {
                    count++;
                }
            }
            if (sp_num == res_sp_num)
            {
                sp_flag = true;
            }

            if (count == 6)
            {
                if (sp_flag)
                {
                    MessageBox.Show("恭喜您中頭獎");
                }
                else
                {
                    MessageBox.Show("恭喜您中貳獎");
                }
            }
            else if (count == 5)
            {
                if (sp_flag)
                {
                    MessageBox.Show("恭喜您中參獎NT$150,000");
                }
                else
                {
                    MessageBox.Show("恭喜您中肆獎NT$20,000");
                }
            }
            else if (count == 4)
            {
                if (sp_flag)
                {
                    MessageBox.Show("恭喜您中伍獎NT$4,000");
                }
                else
                {
                    MessageBox.Show("恭喜您中陸獎NT$800");
                }
            }
            else if (count == 3)
            {
                if (sp_flag)
                {
                    MessageBox.Show("恭喜您中柒獎NT$400");
                }
                else
                {
                    MessageBox.Show("恭喜您中玖獎NT$100");
                }
            }
            else if (count == 2)
            {
                if (sp_flag)
                {
                    MessageBox.Show("恭喜您中捌獎NT$200");
                }
                else
                {
                    MessageBox.Show("未中獎，請再接再厲");
                }
            }
            else if (count == 1)
            {
                if (sp_flag)
                {
                    MessageBox.Show("恭喜您中普獎NT$100");
                }
                else
                {
                    MessageBox.Show("未中獎，請再接再厲");
                }
            }
            
            else
            {
                MessageBox.Show("未中獎，請再接再厲");
            }
        }

        
    }
}