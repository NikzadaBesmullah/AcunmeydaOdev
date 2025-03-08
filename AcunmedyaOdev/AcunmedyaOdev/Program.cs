using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //yas bulma
            Console.WriteLine("Doğüm Yılınızı Giriniz");
            int dt = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - dt;
            Console.WriteLine(Convert.ToString($"{yas}  yaşındasınız"));
            Console.WriteLine("----------------------------");

            //kullanıcın girdigi sayıdan 1 e kadar olan toplamı
            int toplam = 0;
            Console.WriteLine("Bir sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                toplam = toplam + i;

            }
            Console.WriteLine($"1 den {sayi} olan sayiların tolamı:{toplam}");
            Console.WriteLine("----------------------------");

            //çift-tek sayi belirleme

            Console.WriteLine("Sayı giriniz");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s < 0)
            {
                Console.WriteLine("sayı negatif");
            }
            
            else if (s%2==0) 
            {
                Console.WriteLine("Sayi Çift");
            }
             else
            {
                Console.WriteLine("sayı Tek");
            }
            Console.WriteLine("----------------------------");



            //dizideki en kucuk ve en utuk degeri bulma
            int[] sayilar = new int[5];

            Console.WriteLine("Lütfen 5 tam sayı giriniz:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Sayı {i + 1}: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int min = sayilar[0];
            int max = sayilar[0];

            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] < min)
                    min = sayilar[i];

                if (sayilar[i] > max)
                    max = sayilar[i];
            }

            Console.WriteLine($"En küçük sayı: {min}");
            Console.WriteLine($"En büyük sayı: {max}");

        }
    }
}





