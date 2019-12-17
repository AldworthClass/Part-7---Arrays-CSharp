using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7___Arrays_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int evenCount = 0;
            //Q1 - Create Array
            int[] numbers = new int[30];
            //Q2 - Creates fills array with random values 1 - 100
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = generator.Next(1, 101);

            //Q3 - Display Contents
            Console.WriteLine("Q3 - Values in array:");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("");

            //Q4a - Count even numbers
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                    evenCount += 1;
            Console.WriteLine("");
            Console.WriteLine($"Q4a - There are {evenCount} even numbers in the array");
            Console.WriteLine("");

            //Q4b - Display multiples of 5
            Console.WriteLine("Q4b - Values in array that are multiples of 5:");
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 5 == 0)
                    Console.Write(numbers[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("");

            //Q4c - Double every second value
            for (int i = 0; i < numbers.Length; i += 2)
                numbers[i] *= 2;

            //Q4d - Re-print list
            Console.WriteLine("Q4d - Print list with doubled values");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("");

            //Q5 - Determine largest and smallest value
            //If the list is sorted, the first index will have the smallest value, 
            //and the last index will have the greatest value
            Array.Sort(numbers);
            Console.WriteLine($"Q5 - Min: {numbers[0]}, Max: {numbers[numbers.Length - 1]}");
        }
    }
}
