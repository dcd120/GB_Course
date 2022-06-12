using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikolayTools;

namespace HW3
{
    /*
 
    3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    Добавить свойства типа int для доступа к числителю и знаменателю;
    Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); *** Добавить упрощение дробей.
    Достаточно решить 2 задачи. Все программы сделать в одном решении.
    */

    class ComplexClass
    {
        // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
        double im;
        double re;
        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        public double Im
        {
            get { return im; }
        }

        public double Re
        {
            get { return re; }
        }

        public ComplexClass(double re_, double im_)
        {
            this.im = im_;
            this.re = re_;
        }

        public override string ToString()
        {
            return $"{re} + ({im})i";
        }

        static public ComplexClass Sum(ComplexClass a, ComplexClass b)
        {
            ComplexClass c = new ComplexClass(a.Re + b.Re,a.Im + b.Im);
            return c;
        }

        static public ComplexClass Minus(ComplexClass a, ComplexClass b)
        {
            ComplexClass c = new ComplexClass(a.Re - b.Re, a.Im - b.Im);
            return c;
        }
        static public ComplexClass Multi(ComplexClass a, ComplexClass b)
        {
            ComplexClass c = new ComplexClass(a.Re * b.Re, a.Im * b.Im);
            return c;
        }
    }

    struct Complex
    {
        //* 1.
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        public double im;
        public double re;

        public Complex Sum(Complex second)
        {
            Complex result;
            result.im = im + second.im;
            result.re = re + second.re;
            return result;
        }

        public Complex Minus(Complex second)
        {
            Complex result;
            result.im = im - second.im;
            result.re = re - second.re;
            return result;
        }

        public override string ToString()
        {
            return $"{re} + ({im})i";
        }

    }

    internal class Program
    {
        /*
         * 2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
         * Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, 
         * используя tryParse.*/
        static void tryParseDemo()
        {
            Console.WriteLine("Вводите числа, нечетные положительные будут просуммированы, введите (0) для завершения.");
            double x = 0;
            double sum = 0;
            List<double> rightNumbers = new List<double>();
            
            do
            {
                Console.Write("Введите число:");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    if ((x > 0) && (x % 2 == 1))
                    {
                        sum += x;
                        rightNumbers.Add(x);
                    }
                }
                else 
                {
                    Console.WriteLine("Вы ввели некорректное число");
                    x = 1;
                }
            } while (x != 0);

            Console.WriteLine("Благодарю! Общая сумма нечетных положительных чисел: {0}",sum);
            Console.Write("Введенные Вами числа:");
            foreach (var number in rightNumbers)
            {
                Console.Write($"{number};");
            }
            EasyTools.pause();
        }
        static void ComplexClassDemo()
        { 
            ComplexClass a = new ComplexClass(5,2);
            ComplexClass b = new ComplexClass(3,1);

            Console.WriteLine("Демонстрация работы класса для хранения и обработки комплексных чисел");
            Console.WriteLine("Есть два комплексных числа: {0} и {1}", a, b);
            Console.WriteLine("Результат сложения: {0}", ComplexClass.Sum(a,b));
            Console.WriteLine("Результат вычитания: {0}", ComplexClass.Minus(a, b));
            Console.WriteLine("Результат умножения: {0}", ComplexClass.Multi(a, b));
            EasyTools.pause();
        }

        static void ComplexStructDemo()
        {
            Complex a;
            Complex b;

            a.re = 5;
            a.im = 2;

            b.re = 3;
            b.im = 1;

            Console.WriteLine("Демонстрация работы структуры для хранения комплексных чисел");
            Console.WriteLine("Есть два комплексных числа: {0} и {1}", a, b);
            Console.WriteLine("Результат сложения: {0}", a.Sum(b));
            Console.WriteLine("Результат вычитания: {0}", a.Minus(b));
            EasyTools.pause();
        }
        static void Main(string[] args)
        {
            EasyTools.printInfo(3);
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            do { printMenu(); } while (selector());


        }

        static void printMenu()
        {
            Console.Clear();
            Console.WriteLine("Меню задач, домашней работе:");
            Console.WriteLine("(1) Демонстрация работы со структурой Комплексные числа");
            Console.WriteLine("(2) Демонстрация работы с классом Комплексные числа");
            Console.WriteLine("(3) Суммирование неотрицательных положительных через tryParse");
        }

        static bool selector()
        {
            Console.WriteLine("Введите номер задачи, для запуска, или любое другое число - для выхода:");
            int result = int.Parse(Console.ReadLine());
            switch (result)
            {
                case 1:
                    ComplexStructDemo();
                    return true;
                case 2:
                    ComplexClassDemo();
                    return true;
                case 3:
                    tryParseDemo();
                    return true;


                default: return false;
            }

        }
    }
}
