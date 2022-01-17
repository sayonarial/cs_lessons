using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_var_2
{
    public class Task1
    {
        public static void CountWordsAndSpaces()
        {
            Console.WriteLine("Введите строку для подсчета пробелов и слов:");
            string userString = Console.ReadLine();
            // trying to split user string by spaces
            int wordsCount = 0;
            try
            {
                string[] devidedWords = userString.Split(' ');
                wordsCount = devidedWords.Length;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            //count all spaces by combing string array
            int spacesCounter = 0;
            foreach (char c in userString) 
            {
                if(c == ' ')
                {
                    spacesCounter++;
                }
            }

            //Output stats
            Console.WriteLine($"Слов: {wordsCount}");
            Console.WriteLine($"Пробелов: {spacesCounter}");

        }

    }
}
