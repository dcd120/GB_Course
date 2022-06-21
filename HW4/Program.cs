using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NikolayTools;
using NikolayData;

namespace HW4
{
    /*
     * 1. Дан целочисленный массив из 20 элементов. 
     * Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
     * Заполнить случайными числами. 
     * Написать программу, позволяющую найти и вывести количество пар элементов массива, 
     * в которых только одно число делится на 3. 
     * В данной задаче под парой подразумевается два подряд идущих элемента массива.
    Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

    2. Реализуйте задачу 1 в виде статического класса StaticClass;
    а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
    в)*Добавьте обработку ситуации отсутствия файла на диске.

    3.
    а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)

    4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
    5.
    а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    **в) Обработать возможные исключительные ситуации при работе с файлами.
    **/
    internal class Program
    {
        static void DDADemo()
        {
            EasyDoubleArray myArray = new EasyDoubleArray(10, 10, 100);
            Console.WriteLine("Работа с двумерным массивом");
            Console.WriteLine(myArray);
            int i;
            int j;
            myArray.MaxCoordinates(out i, out j);
            Console.WriteLine("Максимальное значение: {0} с координатами в массиве: ({1},{2})",myArray.Max,i+1,j+1);
            Console.WriteLine($"Минимальное значение: {myArray.Min}");
            Console.WriteLine($"Сумма всех элементов: {myArray.SumOfAllElements()}");
            Console.WriteLine($"Сумма всех элементов, больше 50: {myArray.SumOfAllElements(50)}");
            // сохраним в файл и загрузим из него
            myArray.SaveDataToFile(AppDomain.CurrentDomain.BaseDirectory + "DBL.txt");
            EasyDoubleArray myArray2 = new EasyDoubleArray(AppDomain.CurrentDomain.BaseDirectory + "DBL.txt");
            Console.WriteLine(myArray2);
        }
        static void LoginEmulator()
        {
            Console.WriteLine("Эмуляция аутентификации пользователя");
            Console.WriteLine("У вас есть 3 попытки ввести правильную комбинацию login/password");
            int count = 3;
            string login;
            string password;
            String path = AppDomain.CurrentDomain.BaseDirectory + "users.txt";
            Account[] accounts = LoadPasswordsFromFile(path);

            while (count > 0)
            {
                count--;
                Console.Write("Введите логин:");
                login = Console.ReadLine();
                Console.Write("Введите пароль:");
                password = Console.ReadLine();
                if (tryLogin(login, password, accounts))
                {
                    Console.WriteLine("Успешная авторизация!");
                    EasyTools.pause();
                    return;
                }
                else
                {
                    Console.WriteLine("Пара логин/пароль не верна!");
                    if (count > 0) Console.WriteLine("Попробуйте снова. (Осталось {0} попыток)", count);
                }
            }
            Console.WriteLine("Вы привысили допустимое количество попыток.");
            EasyTools.pause();
        }

        static Account[] LoadPasswordsFromFile(String fileName)
        {

            StreamReader streamReader = new StreamReader(fileName);
            //  Считываем количество элементов массива
            int max = int.Parse(streamReader.ReadLine());
            Account[] accounts = new Account[max];
            //  Считываем массив
            for (int i = 0; i < max; i++)
            {
                string[] parts = streamReader.ReadLine().Split(new char[] { ' ' });
                accounts[i].login = parts[0];
                accounts[i].password = parts[1];
            }
            streamReader.Close();
            return accounts;
        }
        static bool tryLogin(string login, string pass, Account[] accounts )
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if ((login == accounts[i].login) && (pass == accounts[i].password)) return true; 
            }
            return false;
        }

        static void Main(string[] args)
        {
            EasyTools.printInfo(4);

            DDADemo();
            EasyTools.pause();

            int[] array0 = new int[20];
            MyArray.FillArray(array0, -10000, 10001);
            int[] array1 = new int[5] { 6, 2, 9, -3, 6 };
            MyArray.PrintPairs(array1, 3);

            // демонстрация работы с классом из библиотеки
            Console.WriteLine("Создадим массив из 10 элементов, от 0 и с шагом 2");
            EasyArray myArray = new EasyArray(10, 0, 2);
            Console.WriteLine(myArray);
            EasyTools.pause();
            Console.WriteLine("Умножим на 2");
            myArray.Multi(2);
            Console.WriteLine(myArray);
            EasyTools.pause();
            Console.WriteLine("Создадим второй, где все элементы инвертированы");
            EasyArray invArray = myArray.Inverse();
            Console.WriteLine(invArray);
            Console.WriteLine($"Количество максимальных значений в массиве: {myArray.MaxCount}, сумма всех чисел в массиве: {myArray.Sum}");
            EasyTools.pause();
            Console.WriteLine(myArray.CalcInserts().ToString());
            EasyTools.pause();

            LoginEmulator();
            EasyTools.pause();

        }
    }
}
