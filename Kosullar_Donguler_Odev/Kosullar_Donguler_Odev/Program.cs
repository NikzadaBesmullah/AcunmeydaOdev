using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosullar_Donguler_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Sayının tek-çift ve pzoitif-negatif kontrolu
            Console.Write("Bir Sayı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0) { Console.WriteLine("Girdiğiniz Sayı Pozitif."); }
             else if (sayi < 0) { Console.WriteLine("Girdiğiniz Sayı Negatif."); }
            else { Console.WriteLine("Girdiğiniz Sayı Sıfır."); }
            //Math.Abs: Mutlak degerini alır
            switch (Math.Abs(sayi % 2))
            {
                case 0:
                    Console.WriteLine("Çift Sayı Girdiniz.");
                    break;
                case 1:
                    Console.WriteLine("Tek Sayı Girdiniz.");
                    break;

            }

            Console.WriteLine("--------------------------------");
            // 1-100 arasındaki çift sayıları ekrana yazdırma

            for (int i = 1; i <= 100; i++)
            {
                if (i == 50)
                    break;

                if (i % 2 != 0)
                    continue;

                if (i % 10 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------");


            //foreach kullanımı
            string[] isimler = { "Mehmet", "Ali", "yusuf", "Fatma", "Muhammed", "Fırat" };
            foreach (string s in isimler)
            {
                if (s == "yusuf") continue;
                Console.WriteLine(s);

            }

        }
    }
}
