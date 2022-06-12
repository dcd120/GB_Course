using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikolayTools
{
    public class EasyTools
    {
        public static void printInfo(int homeWorkNumber)
        {
            
            string studentName = "Заривной Николай";
            Console.WriteLine("Домашняя работа :{0}", homeWorkNumber);
            Console.WriteLine("Выполнил студент:{0}", studentName);
            Console.WriteLine("(для продолжения нажмите любую клавишу...)");

            Console.ReadKey();
        }

        public static void pause()
        {
            Console.Write("(для продолжения нажмите любую клавишу...)");
            Console.ReadKey();
        }
    }
}
