using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStck = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStck = 5, ProductName = "Kalem", UnitPrice = 30 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

           /* int ToplamSonucu = productManager.Topla(3, 6);
            Console.WriteLine(ToplamSonucu*3);*/
        }
    }
}
