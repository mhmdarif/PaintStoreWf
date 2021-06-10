using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformPaintStore.Service
{
    interface IPaintService
    {
        void Add(string brand, string color, double price);
        void Update(int id, string brand, string color, double price);
        void Delete(int id);
        List<PaintService> GetAllPaint();
    }
}
