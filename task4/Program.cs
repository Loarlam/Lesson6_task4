/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию. 
*/
using System;

namespace task4
{
    static class MyClass
    {
        static int[] _arrayToSort;

        public static int[] SortsMass(this int[] array)
        {
            _arrayToSort = array;
            Array.Sort(_arrayToSort);
            return _arrayToSort;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] initialArray, finalArray;

            Console.Write("Размерность массива = ");
            int arraySize = Int32.Parse(Console.ReadLine());

            initialArray = new int[arraySize];
            finalArray = new int[arraySize];

            Console.Write("Массив до сортировки = ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{initialArray[i] = random.Next(1, 30)} ");                
            }

            finalArray = initialArray.SortsMass();

            Console.Write("\nМассив после сортировки = ");
            for (int j = 0; j < finalArray.Length; j++)
            {
                Console.Write($"{finalArray[j]} ");
            }

            Console.ReadKey();
        }
    }
}
