using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NikolayTools;

namespace HW4
{
    internal static class MyArray
    {
        /*  
        б) Добавьте статический метод для считывания массива из текстового файла.
        Метод должен возвращать массив целых чисел;
        в)*Добавьте обработку ситуации отсутствия файла на диске.*/
        public static int[] LoadArrayFromFile(string fileName)
        {
            int[] tmpArray = new int[10000];
            if (!File.Exists(fileName)) throw new AggregateException($"Файл {fileName} не обнаружен!") ;
            StreamReader sr = new StreamReader(fileName);

            int counter = 0;
            while (!sr.EndOfStream)
            {
                tmpArray[counter] = int.Parse(sr.ReadLine());
            }
            sr.Close();
            int[] resultArray = new int[counter];
            Array.Copy(tmpArray, resultArray, counter);
            return resultArray;

        }
        public static void FillArray(int[] x, int min, int max)
        {
            /* 1. Дан целочисленный массив из 20 элементов.
             * Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
             * Заполнить случайными числами.
             2. Реализуйте задачу 1 в виде статического класса StaticClass;
             а) Класс должен содержать статический метод, 
            который принимает на вход массив и решает задачу 1;*/
            Random r = new Random();
            Console.WriteLine($"Заполняем массив из {x.Length} чисел произвольными значениями в диапазоне от {min} до {max-1}");
            EasyTools.pause();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(min,max);
                Console.Write($"({i+1}) {x[i]}\t");
            }
            Console.WriteLine();
            EasyTools.pause();
        }
        public static void PrintPairs(int[] x, int de)
        {
             /*Написать программу, позволяющую найти и вывести количество пар элементов массива,
             *в которых только одно число делится на 3.
             * В данной задаче под парой подразумевается два подряд идущих элемента массива.
            Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.*/
            int prev = 0;
            int counter = 0;
            Console.WriteLine("Демонстрация оценки соседних элементов массива (пар)");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]}\t");
                if (i == 0) prev = x[i];
                else
                {
                    if ((prev % de == 0) && (x[i] % de > 0) || (prev % de > 0) && (x[i] % de == 0))
                    {
                        counter++;
                    }
                    prev = x[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Всего пар, где только одно число кратно {de} : {counter}");
            EasyTools.pause();
        }

    }
}
