using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformPaintStore.Service
{
    interface IBuyerService
    {
        void Add(string name, string telpNumber, string address, double money);
        string GetBuyerName();
        double GetBuyerMoney();
    }
}
