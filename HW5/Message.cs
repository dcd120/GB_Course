using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    /*2. Разработать статический класс Message,
    содержащий следующие статические методы для обработки текста:
    
    
    
    
*/

    public static class Message
    {
        public static void TextAnalyz(string[] keys,string message)
        {
            /*
            д) ***Создать метод, который производит частотный анализ текста.
            В качестве параметра в него передается массив слов и текст,
            в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
            Здесь требуется использовать класс Dictionary.*/
            Console.WriteLine("Передана строка:");
            Console.WriteLine(message);
            Console.WriteLine($"Найдем самое длинное слово\n");
            //уберем знаки препинания
            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i])) message.Remove(i, 1);
                else i++;
            }
            //разобьем строку на слова через split
            string[] words = message.Split(' ');

            // сгенерируем словарь, для дальнейшего анализа текста
            Dictionary<string,int> myAnaliz = new Dictionary<string,int>();
            for (int i = 0; i < keys.Length; i++)
            {
                myAnaliz[keys[i]] = 0;
            }

            // теперь прогоняем слова из предложения в цикле и увеличиваем счетчик у ключа
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < keys.Length; j++)
                { 
                    if (words[i] == keys[j]) myAnaliz[keys[j]]++;
                }
            }
            // теперь выведем результаты
            Console.WriteLine("Выведем результаты анализа:\n");
            foreach (KeyValuePair<string, int> pair in myAnaliz)
            {
                Console.WriteLine($"Слово {pair.Key} встречается в тексте {pair.Value} раз.");
            }
        }
        public static void OnlyLongestWords(string message)
        {
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            Console.WriteLine("Передана строка:");
            Console.WriteLine(message);
            Console.WriteLine($"Найдем самое длинное слово\n");
            //уберем знаки препинания
            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i])) message.Remove(i, 1);
                else i++;
            }
            //разобьем строку на слова через split
            string[] words = message.Split(' ');

            int max = LongestWord(message).Length; //длинна самого длинного слова

            StringBuilder word = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == max)
                {
                     word.Append(words[i]);
                }
            }
            Console.WriteLine("Предложение, составленное только из самых длинных слов\n");
            Console.Write($"{word.ToString()}\t");
            //return word.ToString();
        }
        public static string LongestWord(string message)
        {
            // в) Найти самое длинное слово сообщения.
            Console.WriteLine("Передана строка:");
            Console.WriteLine(message);
            Console.WriteLine($"Найдем самое длинное слово\n");
            //уберем знаки препинания
            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i])) message.Remove(i, 1);
                else i++;
            }
            //разобьем строку на слова через split
            string[] words = message.Split(' ');

            StringBuilder word = new StringBuilder(words[0]);
                
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > word.Length)
                {
                    word.Clear();
                    word.Append(words[i]);
                }
            }
            Console.Write($"{word.ToString()}\t");
            return word.ToString();
        }
        public static void PrintNotEndedBy(string message, char ender)
        {
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            Console.WriteLine("Передана строка:");
            Console.WriteLine(message);
            Console.WriteLine($"Выведем слова, кроме кончающихся на {ender}\n");
            //уберем знаки препинания
            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i])) message.Remove(i, 1);
                else i++;
            }
            //разобьем строку на слова через split
            string[] words = message.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length] != ender) Console.Write($"{words[i]}\t");
            }
        }
        public static void PrintShorter(string message, int maxLetters)
        {
            // а) Вывести только те слова сообщения, которые содержат не более n букв.
            Console.WriteLine("Передана строка:");
            Console.WriteLine(message);
            Console.WriteLine($"Выведем слова, короче чем {maxLetters}\n");
            //уберем знаки препинания
            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i])) message.Remove(i, 1); 
                else i++;
            }
            //разобьем строку на слова через split
            string[] words = message.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= maxLetters) Console.Write($"{words[i]}\t");
            }
        }
    }
}
