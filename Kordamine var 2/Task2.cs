using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kordamine_var_2
{
    public class Task2
    {
        public static void NumberConversionWithSorting()
        {
            // Instantiate random number generator using system-supplied value as seed.
            var rand = new Random();

            //Define array and fill it with random numbers
            var randomIntArray = new int[40];
            for (int i = 0; i < randomIntArray.Length; i++)
            {
                randomIntArray[i] = rand.Next(40);
            }

            //Output raw array
            Console.WriteLine("Случайно сгенерированный массив: ");
            PrintArray(randomIntArray);
            

            //define array for odd and even numbers
            var oddNumbers = new ArrayList();
            var evenNumbers = new ArrayList();

            //Sort by odd even numbers
            foreach (var number in randomIntArray)
            {
                if (number % 2 == 0) //even number
                {
                    evenNumbers.Add(number);
                }
                else //odd number
                {
                    oddNumbers.Add(number);
                }
            }

            //Sort by built-in function
            evenNumbers.Sort();
            oddNumbers.Sort();

            //Output results
            Console.WriteLine("Отсортированные массивы: ");
            Console.WriteLine("Четные: ");
            PrintArray(evenNumbers);
            Console.WriteLine("Нечетные: ");
            PrintArray(oddNumbers);
        }


        static void PrintArray(ArrayList arrayToPrint)
        {
            foreach (var element in arrayToPrint)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        static void PrintArray(int[] arrayToPrint)
        {
            foreach (var element in arrayToPrint)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
