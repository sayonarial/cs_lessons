using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Pro_Ver
{
    public class MenuItem
    {

        public string Name { get; }
        public Action Selected { get; }
        public List<string> ItemOptions {get;}
        int SelectedOptionIndex;

        public MenuItem(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }
        public MenuItem(string name,List<string> optionList, ref int optionIndex)
        {
            Name = name;
            ItemOptions = optionList;
            this.SelectedOptionIndex = optionIndex;

        }


        public void Show()
        {
            Console.Write(Name);
            Console.WriteLine();
        }

    }
}
