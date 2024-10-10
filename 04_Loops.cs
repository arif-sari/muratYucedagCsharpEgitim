using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü
            //for(x,y,z)
            //x:başlangıç noktası
            //y:bitiş noktasi
            //artış miktarı

            //int i;

            //for (i = 1; i <= 5; i++) //break point ekleyip f11 ile adım adım görebiliriz.

            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}


            //for (int i= 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //başlangıç ve bitiş bilgileri kullanıcıdan alınabilir

            //Console.WriteLine("Lütfen yazılmasını istediğiniz adedi giriniz :");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}




            #endregion

            #region For döngüsü ile Karar Yapıları

            //1-100 arası sayıların 5 bölümü

            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i% 5 == 00)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //ardışık sayıları toplama

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //1-20 arası çift sayi toplamı

            //int count = 0;
            //for (int i =1; i <= 60; i++)
            //{
            //    if (i % 7== 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            //Console.WriteLine();

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium);

            //}

            #endregion

            #region while döngüsü
            //şart sağlandığı müddetçe geçerlidir

            // while (şart){ işlemler}

            //int i= 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba döngüler ");
            //    i++;

            //}


            // 1 - 10 arası 3'e tam bölünen sayılar

            //int i = 1;
            //while (i<=10){
            //    if (i % 3 == 0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //    i++;

            //1-10 arası sayıları topla

            //int i = 1;
            //int sum = 0;
            //while (i < 10)
            //{

            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu




            Console.Read();
        }
    }
}
