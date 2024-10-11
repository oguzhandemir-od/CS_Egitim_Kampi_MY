using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Top and Bottom 10 Stars

            //for (int i = 0; i <=10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Side by Side 10 Stars

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region 10 Rows, 10 Stars in Each Row

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("**********");
            //}

            #endregion

            #region Right Triangle

            for (int i = 1; i <=5; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
        }
    }
}
