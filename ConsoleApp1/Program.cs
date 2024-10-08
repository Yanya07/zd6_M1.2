using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];// Создаем массив из 10 вещественных элементов
            Random rand = new Random();  
            for (int i = 0; i < array.Length; i++)// Заполняем массив случайными значениями из диапазона [-10, 10)
            {
                array[i] = rand.NextDouble() * 20 - 10; // Генерация случайных значений в диапазоне [-10, 10)
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:F2} ");
            }
            Console.WriteLine();
            int[] indices = Enumerable.Range(0, array.Length).ToArray(); // Создаем массив индексов
            Array.Sort(indices, (i, j) => array[i].CompareTo(array[j]));// Сортируем индексы по значениям элементов исходного массива

            Console.WriteLine("Массив индексов в порядке возрастания значений элементов исходного массива:");// Выводим отсортированный массив индексов
            for (int i = 0; i < indices.Length; i++)
            {
                Console.Write($"{indices[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Значения массива в порядке возрастания:");
            for (int i = 0; i < indices.Length; i++)
            {
                Console.Write($"{array[indices[i]]:F2} ");
            } 
            Console.WriteLine("\nНажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
    }
}
