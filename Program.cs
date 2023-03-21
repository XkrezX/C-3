using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shrp_hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива.

            int[] arr = new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 7, 7, 8, 8, 9, 9, 10 };


            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }


            int uniqueCount = 0;
            int[] uniqueArr = new int[arr.Length];

            foreach (int num in arr)
            {
                if (Array.IndexOf(uniqueArr, num) == -1)
                {
                    uniqueArr[uniqueCount] = num;
                    uniqueCount++;
                }
            }
            Console.WriteLine("Количество четных элементов: " + evenCount);
            Console.WriteLine("Количество нечетных элементов: " + oddCount);
            Console.WriteLine("Количество уникальных элементов: " + uniqueCount);

            #endregion

            #region Создайте приложение, отображающее количество значений в массиве меньше заданного параметра пользователем.Например, количество значений меньших, чем 7 (7 введено пользователем с клавиатуры).
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];


            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 11);
            }

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < number)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество значений меньше {number}: {count}");

            Console.ReadKey();
            #endregion

            #region Пользователь вводит с клавиатуры три числа. Необходимо подсчитать сколько раз последовательность из этих трёх чисел встречается в массиве. Например: пользователь ввёл: 7 6 5; массив: 7 6 5 3 4 7 6 5 8 7 6 5; количество повторений последовательности: 3.
            Console.Write("Введите три числа через пробел: ");
            string[] input = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(input, int.Parse);

            int[] arr1 = new int[] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5, 8, 9, 7, 6, 5, 4, 3, 2, 6, 5, 7, 8, 6, 1, 2, 3, 4 };

            int count1 = 0;
            for (int i = 0; i < arr1.Length - 2; i++)
            {
                if (arr1[i] == numbers[0] && arr1[i + 1] == numbers[1] && arr1[i + 2] == numbers[2])
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество повторений последовательности: {count}");

            #endregion

            #region  Даны 2 массива размерности M и N соответственно.Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };
            int[] commonElements = array1.Intersect(array2).Distinct().ToArray();
            Console.WriteLine(string.Join(", ", commonElements));
            int[] array3 = commonElements;
            Console.WriteLine(string.Join(", ", array3));
            #endregion

            #region Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве.
            int[,] array5 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = array5.GetLength(0);
            int cols = array5.GetLength(1);
            int min = array5[0, 0];
            int max = array5[0, 0];
            for (int t = 0; t < rows; t++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (array5[t, y] < min)
                    {
                        min = array5[t, y];
                    }
                    if (array5[t, y] > max)
                    {
                        max = array5[t, y];
                    }
                }
            }
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Максимальное значение: " + max);
            #endregion

            #region Пользователь вводит предложение с клавиатуры. Вам необходимо перевернуть каждое слово предложения и отобразить результат на экран. 
                        Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            int wordCount = 0;
            bool lastWasLetter = false;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    if (!lastWasLetter)
                    {
                        wordCount++;
                    }
                    lastWasLetter = true;
                }
                else
                {
                    lastWasLetter = false;
                }
            }
            Console.WriteLine("Количество слов в предложении: " + wordCount);
            #endregion

            #region Пользователь вводит с клавиатуры предложение. Приложение должно посчитать количество гласных букв в нём.
            Console.WriteLine("Введите предложение:");
            string sentenc = Console.ReadLine();
            int vowelCount = 0;
            foreach (char c in sentenc)
            {
                if ("AEIOUYaeiouy".IndexOf(c) >= 0)
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Количество гласных букв в предложении: " + vowelCount);

            #endregion
            
        }
    }
}