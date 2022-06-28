using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class MountainSkis : Skis
    {
        public override string Type => "Горные";
        public override int MaxSpeed => 50;
        public MountainSkis(int price)
        {
            Price = price;
        }
    }
}