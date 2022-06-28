using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class Skis : Equipment
    {

        public override string Name => "Лыжи";
        abstract public string Type { get; }

        public override void GetInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Вид: {Type} {Name}");
            Console.WriteLine($"Максимальная скорость: {MaxSpeed} км/ч");
            Console.WriteLine($"Цена: {Price} долларов");
            Console.WriteLine("---------------------");
            Console.WriteLine();
        }
    }
}