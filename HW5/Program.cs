using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikolayTools;
using System.Text.RegularExpressions;
using System.IO;

namespace HW5
{
 
    internal class Program
    {
        struct Student
        {
            public string name;
            public double mark;
        }
        static void Task3()
        {

            /*4. * Задача ЕГЭ.
            На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов 
            некоторой средней школы.
            В первой строке сообщается количество учеников N, 
            которое не меньше 10, но не превосходит 100, 
            каждая из следующих N строк имеет следующий формат:
            < Фамилия > < Имя > < оценки >,
            где < Фамилия > — строка, состоящая не более чем из 20 символов, 
            < Имя > — строка, состоящая не более чем из 15 символов, 
            < оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
            < Фамилия > и<Имя>, а также<Имя> и<оценки> разделены одним пробелом. 
            Пример входной строки:
            Иванов Петр 4 5 3
            Требуется написать как можно более эффективную программу, 
            которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
            Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших,
            следует вывести и их фамилии и имена.*/

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "data.txt");
            int N = int.Parse(sr.ReadLine());
            Student[] a = new Student[N];
            double[] massiv = new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].name = s[0] + ' ' + s[1];
                a[i].mark = (double.Parse(s[2]) * double.Parse(s[3]) * double.Parse(s[4]))/3;
                massiv[i] = a[i].mark;
            }
            sr.Close();

            Array.Sort(massiv);

            double passMark = massiv[0];
            int maxLevel = 3; // сколько минимальных оценок мы пропускаем
            for (int i = 0; i < massiv.Length; i++)
            { 
                if ((maxLevel-1 > 0) && (massiv[i] > passMark))
                {
                    passMark = massiv[i];
                    maxLevel--;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].mark <= passMark) Console.WriteLine($"{a[i].name} средний балл: {a[i].mark}");
            }
            EasyTools.pause();

        }
        static void Task2()
        {
            // запросим у пользователя две строки и проведем их сравнение
            Console.WriteLine("Сравнение двух строк на предмет - является ли одна, перестановкой другой");
            Console.WriteLine("Введите первую строку, нажмите ввод, и введите вторую строку");
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            if (CheckStrings(a, b))
            {
                Console.WriteLine("Одна строка является перестановкой букв второй!");
            }
            else 
            {
                Console.WriteLine("Строки различны!");
            }
            EasyTools.pause();
        }
        static bool CheckStrings(String _a, String _b)
        {
            // 3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //Например: badc являются перестановкой abcd.
            // сначала проверим длинну
            if (_a.Length != _b.Length) return false;
            // проверить перестановку можно через частотный анализ текстов (они должны быть равны)
            return EqualDict(GetAnalyz(_a),GetAnalyz(_b));
        }

        static bool EqualDict(Dictionary<char, int> _a, Dictionary<char, int> _b)
        {
            for (int i = 0; i < _a.Count; i++)
            { 
                if (!_b.ContainsKey(_a.ElementAt(i).Key)) return false; //буквы есть в одном наборе, но нет в другом
                if (_b[_a.ElementAt(i).Key] != _a[_a.ElementAt(i).Key]) return false; // сама буква есть, но в другом количестве
            }
            return true;
        }

        static Dictionary<char, int> GetAnalyz(String _str)
        { 
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < _str.Length; i++)
            {
                if (result.ContainsKey(_str[i])) result[_str[i]]++; else result.Add(_str[i], 1);
            }
            return result;
        }
        static bool LoginCheck(string login)
        {
            /*1.Создать программу, которая будет проверять корректность ввода логина.
            Корректным логином будет строка от 2 до 10 символов, 
            содержащая только буквы латинского алфавита или цифры, 
            при этом цифра не может быть первой.*/
            Regex myReg = new Regex(@"^[a-z,A-Z][0-9,a-z,A-Z]{1,9}$");
            if (myReg.IsMatch(login)) return true; else return false; //&&(login.Length<10))
        }

        static void Task1()
        {
            Console.WriteLine("Проверка работы с регулярным выражением (п.1. логин");
            Console.WriteLine("Введите логин для проверки на соответствие правилам:");
            for (int i = 0; i < 5; i++)
            {
                if (LoginCheck(Console.ReadLine()))
                {
                    Console.Write("...введенный логин соответствует правилу\n");
                }
                else
                {
                    Console.Write("...ошибка! Введенный логин не соответствует требованиям!\n");
                }

            }
            EasyTools.pause();
        }
        static void Main(string[] args)
        {
            EasyTools.printInfo(5);
            Task1();
            Task2();
            Task3();

        }
    }
}
