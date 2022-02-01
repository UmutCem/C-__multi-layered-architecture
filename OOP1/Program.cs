using System;

namespace OOP1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deneme-öğrenme amaçlı böyle girilmiştir.
            //gerçek hayatta bu girdiler kullanıcıdan alınan girdilerle yapılır.
            Product product1 = new Product();
            product1.id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //c# case sensitive (PascalCase, camelCase)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


        }
    }
}
