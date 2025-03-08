using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2,4,6,8,10
            //adana,ankara,istanbul,izmir,antalya
            //sarı,kırmızı,yeşil,mavi,mor

            //DeğişkenTürü[] diziAdı = new DeğişkenTürü[ElemanSayısı];

            //string[] colors = new string[4];
            //colors[0] = "Sarı";
            //colors[1] = "Kırmızı";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[4];
            //cities[0] = "Adana";
            //cities[1] = "Ankara";
            //cities[2] = "İstanbul";
            //cities[3] = "İzmir";
            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[5];
            //numbers[0] = 2;
            //numbers[1] = 4;
            //numbers[2] = 6;
            //numbers[3] = 8;
            //numbers[4] = 10;
            //Console.WriteLine(numbers[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = new string[5];
            //colors[0] = "Sarı";
            //colors[1] = "Kırmızı";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";
            //colors[4] = "Mor";

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(i+1 +  ". değer : " + colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine("En büyük sayı : " + maxNumber);

            //Array.Sort(numbers); //Diziyi küçükten büyüğe sıralar

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Reverse(numbers); //Diziyi ters çevirir
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Veli", "Deli", "Mehmet", "Ahmet", "Ayşe", "Fatma", "Zeynep", "Kemal", "Mehmet" };
            //int index = Array.IndexOf(customers, "Mehmet");
            //Console.WriteLine("Mehmet ismi " + index + ". indiste yer alıyor.");

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + ". Dizinin en kümük elemanı : " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i+1}. şehrini giriniz : ");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine(cities[3]);

            #endregion

            Console.Read();
        }
    }
}
