using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("// Task 1: Count elements divisible by 3");
            int[] array1 = new int[8];
            Random random = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Original array:");
            foreach (int num in array1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int divisibleByThreeCount = 0;
            foreach (int num in array1)
            {
                if (num % 3 == 0)
                {
                    divisibleByThreeCount++;
                }
            }

            Console.WriteLine($"Count of elements divisible by 3: {divisibleByThreeCount}");
            Console.WriteLine();

            // Task 2
            Console.WriteLine("// Task 2: Display indices and values of odd elements");
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array2 = new int[length];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(-10, 26);
            }

            Console.WriteLine("Original array:");
            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Indices and values of odd elements:");
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    Console.WriteLine($"Index: {i}, Value: {array2[i]}");
                }
            }
        }
    }
}
