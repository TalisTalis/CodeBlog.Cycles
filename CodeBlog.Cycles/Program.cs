using System;

namespace CodeBlog.Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];

            int i = 0;

            while (i < arr.Length)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");

                if (int.TryParse(Console.ReadLine(), out int res))
                {
                    arr[i] = res;

                    i++;
                }
            }

            int sumElementArray = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                sumElementArray += arr[j];
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива равна {sumElementArray}");
            Console.WriteLine();

            int diffElementsArray = arr[0];
            int k = 1;

            while (k < arr.Length)
            {
                diffElementsArray -= arr[k];
                k++;
            }

            Console.WriteLine();
            Console.WriteLine($"Разность элементов массива равна {diffElementsArray}");
            Console.WriteLine();

            long multElementsArray = (long)arr[0];

            int l = 1;

            do
            {
                multElementsArray *= (long)arr[l];
                l++;

            } while (l < arr.Length);

            Console.WriteLine();
            Console.WriteLine($"Произведение элементов массива равна {multElementsArray}");
            Console.WriteLine();
        }
    }
}
