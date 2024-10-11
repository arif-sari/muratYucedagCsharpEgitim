using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta on adet yıldız
            //for (int i =1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion

            #region Yan yana 10 adet yıldız
            //for (int i=1;i<=10;i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta alta 10 tane yıldız oluşturma her satırda 10 adet yıldız

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik üçgen yıldız

            for (int i = 1; i <= 5; i++)
            {
                
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("*");                  
                }
                Console.WriteLine();
            }

            #endregion
            Console.Read();
        }
    }
}
