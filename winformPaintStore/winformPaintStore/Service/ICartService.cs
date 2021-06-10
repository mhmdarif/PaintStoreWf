using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformPaintStore.Service
{
    interface ICartService
    {
        void Add(string brand, string color, double price);
        double GetCartTotalCost();
        void Delete(int id);
        List<CartService> GetAllCartItems();
    }
}
