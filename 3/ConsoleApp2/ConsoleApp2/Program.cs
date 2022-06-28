using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LAB_3_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Cities = new Dictionary<int, string>()
            {
               {1,"Київ" },
               {2,"Львів" },
               {3,"Харків" },
               {4,"Одеса" },
               {5,"Вінниця" },
               {6,"Черкаси" }
            };

            File.WriteAllText("Dictionary.json", JsonConvert.SerializeObject(Cities));

            Console.WriteLine("Dictionary:");
            foreach (var auto in Cities)
            {
                Console.WriteLine($"key: {auto.Key} value: {auto.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Введите ключ к словарю наименьшего ключа, который будет равен ключу: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int a = Cities.Count;

            if (x > a || x <= 0)
            {
                Console.WriteLine("null");
            }

            if (x > 0 && x <= a)
            {
                Console.WriteLine($"Отриманий ключ: {x}");
            }
        }

    }
}