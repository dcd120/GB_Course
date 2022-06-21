using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NikolayData
{
    //*5. а) Реализовать библиотеку с классом для работы с двумерным массивом.

    public class EasyDoubleArray
    {
        int[,] ints;

        public bool SaveDataToFile(String fileName)
        {
            //б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            try 
            { 
                StreamWriter sw = new StreamWriter(fileName);
                // сначала запишем размерность массива
                sw.WriteLine($"{ints.GetLength(0)};{ints.GetLength(1)}");
                // а теперь в цикле все значения из массива
                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    for (int j = 0; j < ints.GetLength(1); j++)
                    {
                        sw.WriteLine(ints[i,j]);
                    }
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; 
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Массив: \n");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    sb.Append($" {ints[i,j]}\t");
                }
                sb.Append($"\n");
            }
            return sb.ToString();
        }

        public bool LoadFromFile(String fileName)
        {
            try
            {
                if (!File.Exists(fileName)) throw new AggregateException($"Файл {fileName} не обнаружен!");
                StreamReader sr = new StreamReader(fileName);

                // из Первой строки считаем размерность массива в файле (i и j)
                String[] paramStrings = sr.ReadLine().Split(';');
                ints = new int[int.Parse(paramStrings[0]), int.Parse(paramStrings[1])];

                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    for (int j = 0; j < ints.GetLength(1); j++)
                    {
                        ints[i, j] = int.Parse(sr.ReadLine());
                    }
                }


                sr.Close();
            }
            catch (Exception Error)
            {
                //в) Обработать возможные исключительные ситуации при работе с файлами.
                Console.WriteLine(Error.Message);
                return false;
            }
            return true;
        }

        public EasyDoubleArray(String fileName)
        {
            //Добавить конструктор и методы, которые загружают данные из файл
            try
            {
                if (!File.Exists(fileName)) throw new AggregateException($"Файл {fileName} не обнаружен!");
                StreamReader sr = new StreamReader(fileName);

                // из Первой строки считаем размерность массива в файле (i и j)
                String[] paramStrings = sr.ReadLine().Split(';');
                ints = new int[int.Parse(paramStrings[0]), int.Parse(paramStrings[1])];

                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    for (int j = 0; j < ints.GetLength(1); j++)
                    {
                        ints[i, j] = int.Parse(sr.ReadLine());
                    }
                }


                sr.Close();
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
                //в) Обработать возможные исключительные ситуации при работе с файлами.
            }

        }

        /// <summary>
        /// Метод возвращает координаты элемента с максимальным значением
        /// </summary>
        /// <param name="_i">В данную переменную - позиция по первому измерению</param>
        /// <param name="_j">В данную - по второму измерению</param>
        public void MaxCoordinates(out int _i, out int _j)
        {
            //*метод, возвращающий номер максимального элемента массива
            //* (через параметры, используя модификатор ref или out).
            int max = ints[0, 0];
            _i = 0;
            _j = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i, j] >= max)
                    {
                        max = ints[i, j];
                        _i = i;
                        _j = j;
                    }
                }
            }
        }

        public int SumOfAllElements()
        {
            //которые возвращают сумму всех элементов массива
            return SumOfAllElements(Min-1);
        }

        public int Max
        {
            //свойство, возвращающее максимальный элемент массива,
            get
            {
                int max = ints[0, 0];
                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    for (int j = 0; j < ints.GetLength(1); j++)
                    {
                        if (ints[i, j] > max) max = ints[i, j];
                    }
                }
                return max;
            }
        }
        
        public int Min
        {
            //свойство, возвращающее минимальный элемент массива
            get
            {
                int min = ints[0, 0];
                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    for (int j = 0; j < ints.GetLength(1); j++)
                    {
                        if (ints[i, j] < min) min = ints[i, j];
                    }
                }
                return min;
            }
        }

        public int SumOfAllElements(int minV)
        {
            //сумму всех элементов массива больше заданного
            int count = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i,j] > minV) count += ints[i, j];
                }
            }
            return count;
        }
        /// <summary>
        /// Конструктор, заполняющий случайными числами создаваемый массив
        /// </summary>
        /// <param name="maxX">Количество объектов первого измерения</param>
        /// <param name="maxY">Количество объектов второго измерения</param>
        /// <param name="maxV">Максимальное значение</param>
        public EasyDoubleArray(int maxX, int maxY, int maxV)
        {
            //*Реализовать конструктор, заполняющий массив случайными числами.
            Random r = new Random();
            ints = new int[maxX,maxY];
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    ints[i, j] = r.Next(maxV + 1);
                }
            }
        }
    }
}
