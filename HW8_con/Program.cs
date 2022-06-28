using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NikolayTools;

namespace HW8_con
{
    //1. С помощью рефлексии выведите все свойства структуры DateTime.
    internal class Program
    {
        public static void Reflex()
        {
            DateTime dateTime = new DateTime();
            //dateTime.DayOfWeek
            int i = 0;
            Console.WriteLine("Список и тип полей класса DateTime");
            foreach (Object prop in dateTime.GetType().GetProperties())
            {
                Console.WriteLine($"{++i}\t { prop }");
            }
            EasyTools.pause();
        }

        static void Main(string[] args)
        {
            EasyTools.printInfo(8);
            Reflex();
        }
    }
}
