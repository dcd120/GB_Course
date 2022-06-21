using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NikolayData
{
    //4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    //    Создайте структуру Account, содержащую Login и Password.
    public struct Account
    {
        public string login;
        public string password;
    }

    //б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    public class EasyArray
    {
        int[] array;

        
        public Dictionary<int, int> CalcInserts()
        {
            //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
            Dictionary<int, int> myDic = new Dictionary<int, int>();
            int[] sortedArray = new int[array.Length];
            Array.Copy(array, sortedArray, array.Length);
            Array.Sort(sortedArray);
            int currentValue = sortedArray[0];
            int counter = 0;
            if (array.Length == 0) throw new ApplicationException("Массив пуст!");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (i == 0)
                {
                    counter++;
                } else {
                    if (sortedArray[i] == currentValue)
                    {
                        counter++;
                    }
                    else
                    {
                        myDic.Add(currentValue, counter);//сохраним количество найденных элементов и начнем новый подсчет
                        currentValue = sortedArray[i];
                        counter = 1;
                    }
                }
            }
            myDic.Add(currentValue, counter);//сохраним последний элемент
            return myDic;
        }

        public int MaxCount
        {
            // свойство MaxCount, возвращающее количество максимальных элементов
            get
            {
                int[] _array = new int[array.Length];
                Array.Copy(array, _array, array.Length);
                Array.Sort(_array, 0, array.Length);
                Array.Reverse(_array, 0, array.Length);

                int maxcount = 0;
                int Max = 0;
                for (int i = 0; i < _array.Length; i++)
                {
                    if (i == 0) { Max = _array[i]; maxcount++; }
                    else
                    {
                        if (_array[i] == Max)
                        {
                            maxcount++;
                        }
                    }
                }

                return maxcount;
            }
        }

        public void Multi(int power)
        {
            //метод Multi, умножающий каждый элемент массива на определённое число
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * power;
            }
        }

        public EasyArray Inverse()
        {
            //метод Inverse,
            //возвращающий новый массив с измененными знаками у всех элементов
            //массива(старый массив, остается без изменений)
            int[] _array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = -array[i];
            }
            EasyArray newArray = new EasyArray(array.Length, _array);
            return newArray;

        }

        public int Sum
        {
            //Создать свойство Sum, которое возвращает сумму элементов массива
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
        }

        public EasyArray(int size, int[] filler)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = filler[i];
            }
            Console.WriteLine($"Создан массив из {size} элементов");
        }

        public EasyArray(int size, int start, int step)
        {
            //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами
            //от начального значения с заданным шагом.
            array = new int[size];
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = start + i * step;
                sum += array[i];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append($" {array[i]}");
            }
            sb.Append($"\t общая сумма массива: {Sum}");
            return sb.ToString();
        }
    }
}

