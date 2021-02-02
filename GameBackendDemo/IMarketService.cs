using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    public interface IMarketService
    {
        void Buy(Product product);

        void Sell(Product product);

        void Add(Product product);

        void Discount(Product product,Campaign campaign);

    }
}
