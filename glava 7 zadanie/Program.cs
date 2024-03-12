using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava7_zadanie
{
    class Program
    {
        static void Main()
        {
            // Пример вызова метода InsertSpaces
            string originalText = "Примертекста";
            string spacedText = InsertSpaces(originalText);

            Console.WriteLine("Исходный текст: " + originalText);
            Console.WriteLine("Текст с пробелами: " + spacedText);
        }
        // Статический метод для вставки пробелов между символами текста
        static string InsertSpaces(string text)
        {
            // Создаем пустую строку для результата
            string result = "";
            // Перебираем символы исходного текста
            foreach (char c in text)
            {
                // Добавляем текущий символ в результат
                result += c;

                // Если символ не последний, добавляем пробел после него
                if (c != text[text.Length - 1])
                {
                    result += " ";
                }
            }
            return result;
        }
    }






    class Program
    {
        static void Main()
        {
            string inputText = "Пример текста для обработки";
            string reversedText = ReverseWords(inputText);

            Console.WriteLine("Исходный текст: " + inputText);
            Console.WriteLine("Текст с обратным порядком слов: " + reversedText);
        }
        static string ReverseWords(string text)
        {
            // Разбиваем текст на слова
            string[] words = text.Split(' ');
            // Создаем новую строку для хранения результата
            string reversedText = "";
            // Проходим по массиву слов в обратном порядке и добавляем их к новой строке
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedText += words[i];
                // Добавляем пробел между словами, кроме последнего
                if (i > 0)
                {
                    reversedText += " ";
                }
            }
            return reversedText;
        }
    }







    class Program
    {
        static void Main()
        {
            string text1 = "example";
            string text2 = "exambpe";
            bool result = CompareStrings(text1, text2);
            if (result)
            {
                Console.WriteLine("Текстовые строки совпадают.");
            }
            else
            {
                Console.WriteLine("Текстовые строки не совпадают.");
            }
        }
        static bool CompareStrings(string text1, string text2)
        {
            // Проверка длин строк
            if (text1.Length != text2.Length)
            {
                return false;
            }
            // Сравнение строк посимвольно
            for (int i = 0; i < text1.Length; i++)
            {
                // Если коды символов отличаются больше, чем на 1, строки не совпадают
                if (Math.Abs((int)text1[i] - (int)text2[i]) > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }






    class Program
    {
        static void Main()
        {
            string text1 = "hello";
            string text2 = "ohell";
            bool result = CompareTexts(text1, text2);
            if (result)
            {
                Console.WriteLine("Текстовые строки содержат одинаковые наборы букв.");
            }
            else
            {
                Console.WriteLine("Текстовые строки содержат разные наборы букв.");
            }
        }
        static bool CompareTexts(string text1, string text2)
        {
            // Создаем множества для уникальных букв из каждого текста
            HashSet<char> set1 = new HashSet<char>(text1);
            HashSet<char> set2 = new HashSet<char>(text2);

            // Сравниваем множества букв
            return SetEquals(set1, set2);
        }

        static bool SetEquals<T>(HashSet<T> set1, HashSet<T> set2)
        {
            if (set1.Count != set2.Count)
            {
                return false;
            }
            foreach (var item in set1)
            {
                if (!set2.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }
    }



    class Program
    {
        static void Main()
        {
            string text = "hello world";
            char symbol = 'o';

            int[] positions = FindSymbolPositions(text, symbol);

            Console.WriteLine($"Позиции символа '{symbol}' в тексте '{text}':");

            if (positions.Length == 1 && positions[0] == -1)
            {
                Console.WriteLine("Символ не найден.");
            }
            else
            {
                foreach (int position in positions)
                {
                    Console.WriteLine(position);
                }
            }
        }
        static int[] FindSymbolPositions(string text, char symbol)
        {
            int count = 0;
            // Подсчет количества вхождений символа в текст
            foreach (char c in text)
            {
                if (c == symbol)
                {
                    count++;
                }
            }
            // Если символ не найден, возвращаем массив с одним элементом -1
            if (count == 0)
            {
                return new int[] { -1 };
            }
            // Создание массива для хранения позиций символа
            int[] positions = new int[count];
            int index = 0;
            // Заполнение массива позициями символа в тексте
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    positions[index++] = i;
                }
            }
            return positions;
        }
    }











    class Program
    {
        static void Main()
        {
            string text = "Hello, World!";
            int startIndex = 7;
            int length = 5;
            string substring = Substring(text, startIndex, length);
            Console.WriteLine("Подстрока: " + substring);
        }

        static string Substring(string text, int startIndex, int length)
        {
            // Проверка на выход за границы строки
            if (startIndex < 0 || startIndex >= text.Length || length <= 0)
            {
                return string.Empty; // Возвращаем пустую строку
            }
            // Определение длины подстроки (не больше, чем оставшаяся длина текста)
            int actualLength = Math.Min(length, text.Length - startIndex);
            // Получение подстроки
            return text.Substring(startIndex, actualLength);
        }
    }










    class TextEditor
    {
        private string text;

        // Конструктор класса
        public TextEditor(string initialText)
        {
            text = initialText;
        }
        // Метод для вставки подстроки в текст
        public void InsertSubstring(string substring, int index)
        {
            // Проверка на корректность введенного индекса
            if (index < 0 || index > text.Length)
            {
                Console.WriteLine("Ошибка: Некорректный индекс.");
                return;
            }
            // Выполняем вставку подстроки
            text = text.Insert(index, substring);
        }
        // Переопределение метода ToString() для возврата текста из текстового поля
        public override string ToString()
        {
            return text;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем объект класса TextEditor
            TextEditor editor = new TextEditor("Это исходный текст.");
            // Вставляем подстроку
            editor.InsertSubstring("вставленная ", 4);
            // Выводим текст после вставки
            Console.WriteLine(editor);
        }
    }






    class IntegerArray
    {
        private int[] array;

        // Конструктор класса
        public IntegerArray(int size)
        {
            array = new int[size];
            // Заполнение массива случайными числами
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(100); // Генерация случайного числа от 0 до 99
            }
        }

        // Переопределение метода ToString() для возврата текстовой строки со значениями элементов массива и информацией о количестве и среднем значении
        public override string ToString()
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            double average = (double)sum / array.Length;
            // Формируем строку с элементами массива, количеством элементов и средним значением
            string result = "Элементы массива:\n";
            foreach (int num in array)
            {
                result += num + " ";
            }
            result += $"\nКоличество элементов: {array.Length}\n";
            result += $"Среднее значение: {average:F2}";
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем объект класса IntegerArray с массивом из 10 случайных чисел
            IntegerArray array = new IntegerArray(10);
            // Выводим результат метода ToString()
            Console.WriteLine(array);
        }
    }


}