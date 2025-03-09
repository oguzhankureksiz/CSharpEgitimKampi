using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer --> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int a = 5;
            //    int b = 10;
            //    int sum = a + b;
            //    Console.WriteLine("Toplam: " + sum);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metodlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine("Merhaba " + name);
            //}

            //WriteMethod("Ali");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surname);
            //}

            //CustomerCard("Ali", "Yıldız");
            //CustomerCard("Ayşe", "Yıldız");
            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string CustomerName()
            //{
            //    return "Ali";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            #endregion

            Console.Read();
        }
    }
}
