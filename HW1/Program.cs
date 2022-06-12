using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikolayTools;

/* ДЗ 1. Заривной Николай
 * 
 * 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 * В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.

2. Ввести вес и рост человека. 
Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах.

3.
а) Написать программу, 
которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
а) с использованием третьей переменной;
б) *без использования третьей переменной.

5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организовать в центре экрана.
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
Достаточно решить 3 задачи. Записывайте в начало программы условие и свою фамилию. 
Все программы создавайте в одном решении. 
Со звездочками задания выполняйте в том случае, если вы решили задачи без звездочек.
*/

namespace HW1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание 1. Анекта");
            // (имя, фамилия, возраст, рост, вес)
            string Name;
            string Family;
            string Age;
            string Tall;
            string Weight;

            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            Family = Console.ReadLine();
            Console.Write("Введите возраст: ");
            Age = Console.ReadLine();
            Console.Write("Введите рост: ");
            Tall = Console.ReadLine();
            Console.Write("Введите вес: ");
            Weight = Console.ReadLine();

            //*В результате вся информация выводится в одну строчку:
            // а) используя склеивание;
            // б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            Console.WriteLine();
            Console.WriteLine(Name + " " + Family + " " + Age + " " + Tall + " " + Weight);
            Console.WriteLine("{0} {1} {2} {3} {4}",Name,Family,Age,Tall,Weight);
            Console.WriteLine($"{Name} {Family} {Age} {Tall} {Weight}");
            Console.ReadLine();
        }

        static void Task2()
        {
            //2.Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах.
            Console.Clear();
            Console.WriteLine("Задание 2. ИМТ");
            double Tall;
            double Weight;
            double Index;

            Console.Write("Введите рост: ");
            Tall = double.Parse(Console.ReadLine());
            Console.Write("Введите вес: ");
            Weight = double.Parse(Console.ReadLine());

            Index = Weight / (Tall * Tall);
            Console.WriteLine($"Индекс массы тела: {Index}");
            Console.ReadLine();
        }

        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задание 3. Расстояние между точками");
            //3.
            //а) Написать программу,
            //которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            //используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            double x1;
            double y1;
            double x2;
            double y2;
            double r;

            Console.Write("Введите x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = double.Parse(Console.ReadLine());

            //r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            r = Calc_R(x1, x2, y1, y2);

            Console.WriteLine($"r = {r:f2}");
            Console.ReadLine();
        }

        static void Task4()
        {
            //4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.

            int x = 5;
            int y = 2;
            //а) с использованием третьей переменной;
            int z;
            z = y;
            y = x;
            x = z;
            //б) *без использования третьей переменной.
            x = y + x;
            y = x - y;
            x = x - y;
        }

        static double Calc_R(double x1, double x2, double y1, double y2)
        {
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }



        static void Main(string[] args)
        {
            EasyTools.printInfo(1);
            Task1();
            Task2();
            Task3();
            Task4();


        }
    }
}
