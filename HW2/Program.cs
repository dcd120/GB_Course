using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikolayTools;

/*ДЗ 2. Заривной Николай
 * 
 * Урок 2. Управляющие конструкции
 * 

Достаточно решить 4 задачи. 
Разбивайте программы на подпрограммы. 
Переписывайте в начало программы условие и свою фамилию. 
Все программы делайте в одном решении.
*/

namespace HW2
{
    internal class HomeWork2
    {
        static void reverso()
        {
            /*7.
            a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
            Console.WriteLine("Выведем при помощи рекурсии сумму чисел от А до Б, и посчитаем их сумму");
            Console.Write("Введите число А:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б:");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            reversoNumbers(a,b);
            sum = reversoSum(a,b);
            Console.WriteLine("Сумма чисел равна: {0}",sum);
            EasyTools.pause();
        }

        static void reversoNumbers(int x, int maxX)
        {
            Console.WriteLine("{0}",x);
            x++;
            if (x >= maxX) return; else reversoNumbers(x,maxX);
        }

        static int reversoSum(int x, int maxX)
        {
            if (x + 1 >= maxX) return x; else return x + reversoSum(x + 1, maxX);
        }
        static void calcGoodNumbers()
        {
            /*6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            «Хорошим» называется число, которое делится на сумму своих цифр.
            Реализовать подсчёт времени выполнения программы, используя структуру DateTime.*/
            Console.WriteLine("Подсчитаем количество хороших чисел в диапазоне от 1 до 1 000 000 000");
            EasyTools.pause();
            int sum = 0;
            int sumOfIndex = 0;
            int currentNumber = 0;
            double time;
            DateTime timer = DateTime.Now;
            while (currentNumber < 1000000000)
            { 
                currentNumber++;
                if (currentNumber % sumOfNumbers(currentNumber) == 0)
                {
                    sum += currentNumber;
                    sumOfIndex++;
                }
            }
            time = (DateTime.Now - timer).TotalSeconds;
            Console.WriteLine("Всего хороших чисел: {1} на общую сумму: {0}",sum,sumOfIndex);
            Console.WriteLine("Обработка диапазона заняла: {0:f3} сек.",time);
            EasyTools.pause();
        }

        static int sumOfNumbers(int x)
        {
            int sum = 0;

            while (x >= 10)
            {
                sum += x % 10;
                x = x / 10;
            }
            sum += x; 
            return sum;
        }
        static void weightAnalizator()
        {
            /*5.
            а) Написать программу, которая запрашивает массу и рост человека, 
            вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
            Console.WriteLine("Расчет индекса массы тела и рекомендации по его корректировке.");
            Console.Write("Введите свой рост (в см):");
            double hight = double.Parse(Console.ReadLine())/100;
            Console.Write("Введите свой вес (в кг):");
            double weight = double.Parse(Console.ReadLine());
            double imt = weight / Math.Pow(hight, 2);
            double normalMinimum = 18.5;
            double normalMaximum = 25;

            if ((imt >= normalMinimum) && (imt <= normalMaximum))
            {
                // its ok!
                Console.WriteLine("Поздравляем, ваш индекс массы тела в пределах нормы и равен {0:f2}",imt);
            }
            else if (imt > normalMaximum)
            {
                // you are fat!
                Console.WriteLine("Ваш индекс массы тела выше нормы и равен {0:f2}, рекомендуем похудеть!", imt);
                Console.WriteLine("Для достижения нормы Вам надо похудеть на {0:f2} кг.", (imt - normalMaximum)*Math.Pow(hight,2));
            }
            else 
            {
                // you are hungry dead
                Console.WriteLine("Ваш индекс массы тела ниже нормы и равен {0:f2}, рекомендуем набрать вес!", imt);
                Console.WriteLine("Для достижения нормы Вам надо набрать {0:f2} кг.", (normalMinimum - imt) * Math.Pow(hight, 2));
            }
            EasyTools.pause();
        }
        static void loginEmulator()
        {
            /*4.Реализовать метод проверки логина и пароля.
            На вход метода подается логин и пароль.
            На выходе истина, если прошел авторизацию, и ложь, если не прошел
            (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, написать программу:
            пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            С помощью цикла do while ограничить ввод пароля тремя попытками.*/
            Console.WriteLine("Эмуляция аутентификации пользователя");
            Console.WriteLine("У вас есть 3 попытки ввести правильную комбинацию login/password");
            int count = 3;
            string login;
            string password;
            while (count > 0)
            { 
                count--;
                Console.Write("Введите логин:");
                login = Console.ReadLine();
                Console.Write("Введите пароль:");
                password = Console.ReadLine();
                if (tryLogin(login, password))
                {
                    Console.WriteLine("Успешная авторизация!");
                    EasyTools.pause();
                    return;
                }
                else {
                    Console.WriteLine("Пара логин/пароль не верна!");
                    if (count>0) Console.WriteLine("Попробуйте снова. (Осталось {0} попыток)", count);
                }
            }
            Console.WriteLine("Вы привысили допустимое количество попыток.");
            EasyTools.pause();
        }

        static bool tryLogin(string login, string pass)
        {
            if ((login == "root") && (pass == "GeekBrains")) return true; else return false;
        }
        static void countOdd()
        {
            //3.С клавиатуры вводятся числа, пока не будет введен 0.
            //Подсчитать сумму всех нечетных положительных чисел.
            int x = 0;
            int sum = 0;
            Console.WriteLine("Подсчет суммы вводимых нечетных положительных чисел (целых).");
            Console.WriteLine("Для окончания ввода наберите 0");
            do
            {
                Console.Write("Введите целое число:");
                x = int.Parse(Console.ReadLine());
                if ((x>0)&&(x%2!=0)) sum = sum + x;
            } 
            while (x != 0);
            Console.WriteLine("Сумма всех введенных положительных нечетных чисел равна: {0}", sum);
            EasyTools.pause();
        }
        static void countNumbers()
        {
            //2. Написать метод подсчета количества цифр числа.
            Console.WriteLine("Подсчет количества цифр в числе.");
            Console.Write("Введите число:");
            string x = Console.ReadLine();
            if (x.Contains(".") && x.Contains("-")) Console.WriteLine("Цифр в числе:{0}", x.Length - 2);
            else if (x.Contains(".")||x.Contains("-")) Console.WriteLine("Цифр в числе:{0}", x.Length - 1); 
            else Console.WriteLine("Цифр в числе:{0}", x.Length);
            EasyTools.pause();
        }
        static void findMinimum()
        {
            //1.Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Работа с методом, возвращающим минимальное значение из 3х");
            Console.Write("Введите первое число:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное число:{0}", findMinimum(x1, x2, x3));
            EasyTools.pause();
        }
        static double findMinimum(double x1, double x2, double x3)
        {
            x1 = x1 < x2 ? x1 : x2;
            return x1 < x3 ? x1 : x3;
        }
        static void Main(string[] args)
        {
            // меню выбора задач
            //Console.WriteLine("Домашнее задание к уроку №2");
            //Console.WriteLine("Студент: Заривной Николай");
            EasyTools.printInfo(2);
            // доступные варианты выбора от 1 до 9
            do { printMenu(); } while (selector());
            // конец
        }

        static bool selector()
        {
            Console.WriteLine("Введите номер задачи, для запуска, или любое другое число - для выхода:");
            int result = int.Parse(Console.ReadLine());
            switch (result)
            {
                case 1:
                    findMinimum();
                    return true;
                case 2:
                    countNumbers();
                    return true;
                case 3:
                    countOdd();
                    return true;
                case 4:
                    loginEmulator();
                    return true;
                case 5:
                    weightAnalizator();
                    return true;
                case 6:
                    calcGoodNumbers();
                    return true;
                case 7:
                    reverso();
                    return true;
                case 8:
                    reverso();
                    return true;

                default: return false;
            }
            
        }

        static void printMenu()
        {
            Console.Clear();
            Console.WriteLine("Меню задач, домашней работе:");
            Console.WriteLine("(1) Минимальное число из трех");
            Console.WriteLine("(2) Подсчет количества цифр числа");
            Console.WriteLine("(3) Суммирование нечетных вводимых чисел");
            Console.WriteLine("(4) Авторизация");
            Console.WriteLine("(5) Оценка веса и рекомендации по его корректировке");
            Console.WriteLine("(6) Подсчет хороших чисел");
            Console.WriteLine("(7) (рекурсия) Вывести числа от А до Б");
            Console.WriteLine("(8) (рекурсия) Подсчет суммы чисел от А до Б");

        }
    }
}
