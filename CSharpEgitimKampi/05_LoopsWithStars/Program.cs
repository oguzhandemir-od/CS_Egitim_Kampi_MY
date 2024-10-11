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

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("*");
            }

            #endregion
            
            Console.ReadKey();
        }
    }
}
