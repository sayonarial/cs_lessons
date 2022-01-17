using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kordamine_var_2
{
    class Task3
    {

        public static void LuckyNumber()
        {
            string userNumberString;
            while (true)
            {
                //get Number from user
                Console.Write("Введите ваше число: ");
                userNumberString = Console.ReadLine();
                //Check if it is number or not
                if (IsNumber(userNumberString))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите число без лишних символов!\n Enter - заново. Q - выйти");
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.Q)
                    {
                        return;
                    }
                }
            }
            //convert to int array

            //Show numbers array
            PrintArray();

            //check if number is mirrored
            //check if numbers is equal
            //check if numbers in order
        }

        static bool IsNumber(string potentialNumber)
        {
            /* User`s number can be bigger then we can imagine
             * so we can not just try to parse it to number 
             * Lets find numbers in chars of a string and put them into array
            */
            foreach (var item in potentialNumber)
            {
                if (Char.GetNumericValue(item) == -1)
                {
                    return false;
                }
                
            }
            return true;
        }

        static void PrintArray(int[] arrayToPrint)
        {
            foreach (var element in arrayToPrint)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        static ArrayList StringNumbersToIntArray(string numberString)
        {
            var numbersList = new ArrayList();

            foreach (var number in numberString)
            {
                numbersList.Add()
            }
            return numbersList;
        }
    }
}
