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
            UserNumber userNumber = new UserNumber();

            while (true)
            {
                //get Number from user
                Console.Write("Введите ваше число: ");
                userNumber.numbersString = Console.ReadLine();
                //Check if it is number or not
                if (userNumber.IsNumber())
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите как минимум двузначное число без лишних символов!\n Enter - заново. Q - выйти");
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.Q)
                    {
                        return;
                    }
                }
            }

            //Show numbers array
            userNumber.PrintIntArray();

            //check if number is lucky
            if (userNumber.IsMirrored())
            {
                userNumber.PrintLucky();
            }
            else if (userNumber.IsEqual())
            {
                userNumber.PrintLucky();
            }
            else if (userNumber.IsInOrder())
            {
                userNumber.PrintLucky();
            }
            else
            {
                userNumber.PrintUnlucky();
            }

        }

        

        
        
    }
}
