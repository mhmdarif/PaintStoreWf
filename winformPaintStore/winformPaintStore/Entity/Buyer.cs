using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformPaintStore.Entity
{
    class Buyer
    {
        // properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string TelpNumber { get; set; }
        public string Address { get; set; }
        public double Money { get; set; }

        //Constructor

        public Buyer() { }
        public Buyer(string cname, string cnumber, string caddress)
        {
            Name = cname;
            TelpNumber = cnumber;
            Address = caddress;
        }

    }
}
