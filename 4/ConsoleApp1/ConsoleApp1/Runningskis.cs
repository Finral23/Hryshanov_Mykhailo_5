using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class RunningSkis : Skis
    {
        public override string Type => "Беговые";
        public override int MaxSpeed => 50;
        public RunningSkis(int price)
        {
            Price = price;
        }
    }
}