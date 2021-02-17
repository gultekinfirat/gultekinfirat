using System;

namespace KamppIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bool komutu dallandırma işlemlerinde kullanılmaktadır.(Sisteme giriş yapılmış mı yoksa yapılmamış mı gibi)
            // Do not repeat yourself- Kendini tekrar etme
            // Type safety- Tip güvenliği
            // İnt tamasayıları tutar
            // Double ondalıklı sayıları tutar

            String KategoriEtiketi = "Kategoriler";
            int OgrenciSayisi = 32000;
            double FaizOrani = 1.47;
            bool SistemeGirisYapmısMı = true;
            double DolarDun = 7.55;
            double DolarBugun = 7.55;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (DolarDun == DolarBugun)
            {
                Console.WriteLine("Eşitlik Butonu");
            }
            else
            {
                Console.WriteLine("Yükselis Butonu");
            }


            if (SistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }



            Console.WriteLine(KategoriEtiketi);



        }
    }
}
