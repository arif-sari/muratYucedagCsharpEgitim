using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tenel Dizi Örnekleri

            //2,4,6,8...
            //sarı,kırmızı,mavi,Turuncu

            //Değişken türü [] DiziAdi = new DeğişkenTürü[ElemanSayisi]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[3] = 698;
            //numbers[4] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = {"Prag", "Roma","Atina", "Ankara","Bursa" };

            //Console.WriteLine(cities[2]);



            #endregion


            #region Dizideki Tüm Elemanları Listele

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            for(int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }



            #endregion




            Console.Read();          


        }
    }
}
