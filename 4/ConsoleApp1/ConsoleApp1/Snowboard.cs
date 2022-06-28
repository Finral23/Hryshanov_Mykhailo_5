using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Snowboard : Equipment
    {
        public override string Name => "Сноуборд";
        public override int MaxSpeed => 124;

        public Snowboard(int price)
        {
            Price = price;
        }

        public override void GetInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Вид: {Name}");
            Console.WriteLine($"Максимальная скорость: {MaxSpeed} км/ч");
            Console.WriteLine($"Цена: {Price} долларов");
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    }
}