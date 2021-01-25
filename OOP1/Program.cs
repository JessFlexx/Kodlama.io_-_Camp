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
            product1.ProductName = "Table";
            product1.UnitPrice = 505;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, 
                UnitsInStock = 5 , ProductName = "Pencil" , UnitPrice = 35 };
            
            //case sensitive c#
            //Pasccal Case //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
        }
    }
}
