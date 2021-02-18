using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");

            foreach (var isim in isimler.items)
            {
                Console.WriteLine(isim);

            }

             
        }
    }
}
