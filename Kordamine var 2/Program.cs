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
        static void Main(string[] args)
        {


            int UserChoice;

            ArrayList arrayList = new ArrayList();
            var MenuItems = arrayList;
            MenuItems.Add("Посчитать кол-во слов и пробелов в тексте");
            MenuItems.Add("Преобразование чисел с сортировкой");
            MenuItems.Add("Счастливое ли число?");

            while (true)
            {

                UserChoice = GetChoiceFromMenu(MenuItems);
                
                switch (UserChoice)
                {

                    case 1: Task1.CountWordsAndSpaces();  break;
                    case 2: Task2.NumberConversionWithSorting(); break;
                    case 3: Task3.LuckyNumber();  break;
                    default: Console.WriteLine("Not a valid menu item"); break;
                }

                EndOrRepeat();
            }
        }
    }
}
