using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kordamine_var_2
{
    class UserNumber
    {
        public string numbersString;
        List<int> numbersArray = new List<int>();

        public bool IsNumber()
        {
            /* User`s number can be bigger then we can imagine
             * so we can not just try to parse it to number 
             * Lets find numbers in chars of a string and put them into array
            */
            if (numbersString.Length < 2)
            {
                return false;
            }
            foreach (var item in this.numbersString)
            {
                if (Char.GetNumericValue(item) == -1)
                {
                    return false;
                }

            }
            //convert to array
            ToIntArray();
            return true;
        }

        void ToIntArray()
        {
            foreach (var number in this.numbersString)
            {
                numbersArray.Add((int)Char.GetNumericValue(number));
            }
        }

        public void PrintIntArray()
        {
            foreach (var element in numbersArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public void PrintLucky()
        {
            Console.WriteLine($"Ваше число {numbersString} счастиливое!");
        }
        public void PrintUnlucky()
        {
            Console.WriteLine($"Ваше число {numbersString} обычное (не счастливое)");
        }

        public bool IsMirrored()
        {
            int arrayLength = numbersArray.Count;

            for (int i = 0; i < arrayLength / 2; i++)
            {
                if (numbersArray[i] - numbersArray[arrayLength - i - 1] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsEqual()
        {
            foreach (var item in numbersArray)
            {
                if (item != numbersArray[0])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsInOrder()
        {
          
            for (int i = 0; i < numbersArray.Count - 1; i++)
            {
                if (numbersArray[i+1] - numbersArray[i] != 1)
                {
                    return false;
                }
            }
            return true;
        }

        

    }
}
