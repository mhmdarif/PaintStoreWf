using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace winformPaintStore.Entity
{
    class Cart
    {
        //Properties

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        //Constructor

        public Cart() { }

        public Cart(string pbrand, string pcolor, double pprice)
        {
            Brand = pbrand;
            Color = pcolor;
            Price = pprice;
        }

    }
}
