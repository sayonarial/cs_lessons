using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kordamine_var_2
{
    partial class Program
    {
        static public void ShowMenu(ArrayList menuList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int c = 0;
            foreach(String e in menuList)
            {
                c++;
                Console.WriteLine($"{c}.{e}");
            }
        }

        static int GetChoiceFromMenu(ArrayList menuItems)
        {

            ShowMenu(menuItems);
            int userInput = 0;
            try
            {
                Console.WriteLine("Введите номер меню: ");
                userInput = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }

            return userInput;
            
        }

        static void EndOrRepeat()
        {

            Console.WriteLine("Нажмите любую клавишу чтобы закончить или Enter чтобы выйти в глваное меню");
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            if (keyPressed.Key != ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }    
        }
    }
}
