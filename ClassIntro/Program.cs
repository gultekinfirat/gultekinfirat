using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;


            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Kerem Varıs";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.kursAdi+"   "+kurs1.Egitmen );

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen + "  : " + kurs.IzlenmeOrani);
            }

        }
    }

    class kurs
    {
        public string kursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }


}

