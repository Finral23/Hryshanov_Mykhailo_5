using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class Equipment
    {
        public abstract string Name { get; }
        public abstract int MaxSpeed { get; }
        public int Price;

        public abstract void GetInfo();
    }
}