using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0413practice3
{
    class Program
    {
        static void Main(string[] args)
        {//練習:輸出 等腰三角形(正三角形).菱形   用*表示
         //課程作業加分題:請輸出 聖誕樹 彩色 有裝飾(思考， 可以任意輸入聖誕樹的高度)


            //等腰三角形
            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= 5 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");



            //菱形(分成上下三角形 數字反就可以了)

            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= 5 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 5; i >= 1; i -= 1)
            {
                for (int j = 1; j <= 5 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.WriteLine("----------------------------");



            //聖誕樹


            for (int i = 1; i < 5; i += 1)
            {

                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {

                    if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    else if (i == 2 & j % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    else if (i == 3 & j % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    else if (i == 4 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }



                    Console.Write("*");

                }

                if (i < 4)
                {
                    Console.WriteLine();
                }

            }



            for (int i = 0; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    if (i == 2 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }


                    else if (i == 4 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }

                    else if (i == 6 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }


                    Console.Write("*");
                }

                if (i < 6)
                {
                    Console.WriteLine();
                }

            }



            for (int i = 0; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    if (i == 2 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    else if (i == 4 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    else if (i == 6 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }

                    Console.Write("*");

                }

                Console.WriteLine();

            }



            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("");
            for (int i = 1; i < 6; i += 1)
            {
                for (int j = 1; j < 8; j += 1)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 3; j += 1)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------");




            //正方形
            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= 10; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");



            //直角三角形
            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");



            //直角三角形(反)
            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 0; j <= 10 - i; j += 1)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");



            //直角三角形(反+移位)
            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= 5; j += 1)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= 10 - i; j += 1)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");




            //小的直角三角形
            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");


            //樹幹(長方形)
            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= 5; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");



            //樹幹(長方形)
            for (int i = 1; i < 7; i += 1)
            {
                for (int j = 1; j <7; j += 1)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <5; j += 1)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");


            //樹幹(長方形)
            for (int i = 1; i <6; i += 1)
            {
                for (int j = 1; j <= 5; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");


            //樹
            for (int i = 1; i <= 7; i += 2)
            {
                for (int j = 1; j <= 7- i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------");


            //樹

            for (int i = 1; i <= 4; i += 1)
            {
                for (int j = 1; j <= 7 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");




            //3樹

            for (int i = 1; i <5; i += 1)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= 7; i += 2)
            {
                for (int j = 1; j <=9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 6; i += 1)
            {
                for (int j = 1; j < 8; j += 1)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 3; j += 1)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");




            //3樹

            for (int i = 1; i < 5; i += 1)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 6; i += 1)
            {
                for (int j = 1; j < 8; j += 1)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 3; j += 1)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");



            //成功的3樹

          
            for (int i = 1; i < 5; i += 1)
            {                
                
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {

                    if (i ==1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    else if(i == 2 & j % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    else if (i == 3 & j % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    else if (i == 4 & j % 2 ==0 )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    
                    
                    
                    Console.Write("*");
                    
                }
                
                if (i < 4)
                {
                    Console.WriteLine();
                }
                
            }
            


            for (int i = 0; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    if (i == 2 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    

                    else if (i == 4 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }

                    else if (i == 6 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }


                    Console.Write("*");
                }

                if (i < 6)
                {
                    Console.WriteLine();
                }

            }



            for (int i = 0; i <= 7; i += 2)
            {
                for (int j = 1; j <= 9 - i; j += 1)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j += 1)
                {
                    if (i == 2 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    else if (i == 4 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    else if (i == 6 & j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }

                    Console.Write("*");

                    }

                    Console.WriteLine();
                
            }



            Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("");
            for (int i = 1; i < 6; i += 1)
            {
                for (int j = 1; j < 8; j += 1)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 3; j += 1)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------");





            








                Console.WriteLine();
                Console.WriteLine("----------------------------");
                Console.WriteLine("按任意鍵結束");
                Console.ReadKey();

            }

        }
    }



            
            
        




  

