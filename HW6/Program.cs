using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NikolayTools;


namespace HW6
{
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x);
    public delegate double Fun2(double x, double b);
    struct funcions
    {
        public Fun fun;
        public String name;
    }

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата

        //1.Изменить программу вывода таблицы функции так,
        //чтобы можно было передавать функции типа double (double, double). 
        //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
        
        public static double MyFuncX2(double x, double a)
        {
            return a * Math.Pow(x,2);
        }
        public static double MyFuncSinX(double x, double a)
        {
            return a * Math.Sin(x);
        }
        public static void Table(Fun2 F, double x, double b)
        {
            Console.WriteLine("----- X ----- A ----- Y -----");
            while (x <= b)
            {
                for (int a = 0; a <= b; a++)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                }
                x += 1;
                Console.WriteLine("----- X ----- A ----- Y -----");
            }
            Console.WriteLine("---------------------");
        }
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
                {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
                }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2); // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
            ////

            // примеры из домашнего задания
            EasyTools.printInfo(6);
            Console.WriteLine("Таблица функции (a * x^2) :");
            Table(MyFuncX2, -3, 3);
            Console.WriteLine("Таблица функции (a * sin(x)):");
            Table(MyFuncSinX, -3, 3);
            EasyTools.pause();

            // минимум функции (стр 22 методички)
            // задание 2
            SaveFunc(AppDomain.CurrentDomain.BaseDirectory + "data.bin", -100, 100, 0.5, F);
            Console.WriteLine(Load(AppDomain.CurrentDomain.BaseDirectory + "data.bin"));
            Console.ReadKey();

            // домашнее задание
            List<funcions> variants = new List<funcions>();// список структур, содержащих делегаты
            double min;
            double max;
            funcions myF;

            //а) Сделать меню с различными функциями и представить пользователю выбор, 
            //для какой функции и на каком отрезке находить минимум.
            //Использовать массив(или список) делегатов, в котором хранятся различные функции.

            fillVariants(variants); // заполним список несколькими вариантами (делегат + имя)
            menu(variants, out min, out max, out myF); // сформируем меню и обработаем выбор пользователя
            // используем методы из методички, для решения задачи
            SaveFunc(AppDomain.CurrentDomain.BaseDirectory + "data.bin", min, max, 0.5, myF.fun);
            Console.WriteLine(Load(AppDomain.CurrentDomain.BaseDirectory + "data.bin"));
            EasyTools.pause();
            double[] doubles = Load(AppDomain.CurrentDomain.BaseDirectory + "data.bin",out min);
            foreach (double x in doubles) { Console.WriteLine(x); }
            Console.WriteLine("минимум: {0:F2}",min) ;
            EasyTools.pause();
        }

 

        public static void menu(List<funcions> myList, out double min, out double max, out funcions myF)
        {
            EasyTools.pause();
            Console.WriteLine("Выберите из списка функцию, для которой вы хотите найти минимум:");
            int i = 0;
            foreach (funcions func in myList)
            {
                Console.WriteLine($"Введите: {i++} для выбора функции: {func.name}");
            }
            int select = int.Parse(Console.ReadLine());

            myF = myList[select];
            Console.WriteLine($"Вы выбрали функцию: {myF.name}") ;
            Console.WriteLine("Выберите интервал, на котором необходимо найти минимум: ");
            Console.Write("От: ");
            min = double.Parse(Console.ReadLine());
            Console.Write("До: ");
            max = double.Parse(Console.ReadLine());
            // теперь вернем всю собранную информацию в головную функцию
        }
        public static void fillVariants(List<funcions> myList)
        {
            funcions a;
            a.fun = delegate (double x) { return x * x; };
            a.name = "POW 2";
            myList.Add(a);

            funcions b;
            b.fun = delegate (double x) { return Math.Sin(x); };
            b.name = "SIN(x)";
            myList.Add(b);

            funcions c;
            c.fun = delegate (double x) { return Math.Tan(x); };
            c.name = "TAN(x)";
            myList.Add(c);
        }
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        
        //2.Модифицировать программу нахождения минимума функции так,
        //чтобы можно было передавать функцию в виде делегата.
        public static void SaveFunc(string fileName, double a, double b, double h, Fun del_F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(del_F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
        // Пусть она возвращает минимум через параметр (с использованием модификатора out).
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[] values = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                values[i] = d;
            }
            bw.Close();
            fs.Close();
            return values;
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
    }

}

