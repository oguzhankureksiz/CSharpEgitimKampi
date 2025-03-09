using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1- Değişken türü
            //2- Değişken adı
            //3- In anahtar kelimesi
            //4- Dizi adı

            //string[] cities = { "Ankara", "İstanbul", "İzmir" };

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int sum = 0;

            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}

            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello World";

            //foreach (var letter in word)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            //Öğrenci isimlerini ve sınav ortalamalarını tutacak dizileri oluşturma
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1} .öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu alınacak

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                studentExamAvg[i] = totalExamResult / 3; //ortalama hesaplama
            }

            //Öğrencinin ortalaması ve geçip kalma durumları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalama notu : {studentExamAvg[i]} ve durumu : {(studentExamAvg[i] >= 50 ? "Geçti" : "Kaldı")}");
            }



            #endregion

            Console.Read();
        }
    }
}
