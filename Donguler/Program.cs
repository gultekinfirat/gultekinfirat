using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // veri eklentilerini dinamik hale getirmek adına 'array'ler yani diziler kullanılmakadır.

            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            // lenght eleman sayısını ifade eder. İ değerinin döngüde duracağı eleman sayısnın dinamize etmek için bu kod  kullanılmaktadır.
            string[] kurslar = new string[] { "Yazılım geliştirici kursu", "Programlamaya Başlangıç için Temel Kurs", "Java", "python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            // foreach komutu dizi temelli yapıların elemanlarını tek tek dolaşır ve onları döndürür. Ayrıca foreach komtundaki kurs adlı kısım alias(adlandırma)'dır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
