using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    public class BaseMarketManager : IMarketService 
    {
        private const string V = "%";

        public void Add(Product product)
        {
            Console.WriteLine(product.ItemName + " '" + product.ItemId + "' kodlu ürün eklendi.");
        }

        public void Buy(Product product)
        {
            Console.WriteLine(product.ItemName +  " ürünü satın alındı.");
        }

        public void Discount(Product product,Campaign campaign)
        {
            Console.WriteLine( product.ItemName +" ürününe yüzde '" + campaign.AmountOfDiscount + "' indirim uygulandı.");
        }

        public void Sell(Product product)
        {
            Console.WriteLine(product.ItemName + " Ürün satışı yapıldı. " + product.ItemPrice + " gold hesabınıza eklendi.");
        }
    }
}
