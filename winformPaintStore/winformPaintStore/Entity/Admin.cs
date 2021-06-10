using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformPaintStore.Entity
{
    class Admin
    {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; }


        // Constructor 

        public Admin() { }
        public Admin(string aname)
        {
            Name = aname;
        }
        
    }
}
