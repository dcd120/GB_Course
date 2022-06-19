using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikolayTools
{
    public class EasyTools
    {
        public static int NOD(int x, int y)
        {
            if (x < 0) x = -x;
            if (y < 0) y = -y;
            if (x == 0 || y == 0) return 1;
            while (x != y)
            {
                
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
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
            Console.WriteLine("(для продолжения нажмите любую клавишу...)");
            Console.ReadKey();
        }
    }
}
