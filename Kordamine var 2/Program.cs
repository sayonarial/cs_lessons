using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_var_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_input;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {

                Console.WriteLine("Menu:\n" +
                    "1.Посчитать кол-во слов и пробелов в тексте\n" +
                    "2.Преобразование чисел с сортировкой\n" +
                    "3.Счастливое ли число?");
                Console.WriteLine("Введите номер меню: ");
                try
                {
                    user_input = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
                switch (user_input)
                {

                    case 1:break;
                    case 2: break;
                    case 3: break;
                    default: Console.WriteLine("Not a valid menu item"); break;
                }

            }
        }
    }
}
