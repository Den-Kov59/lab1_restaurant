using lab1_restaurant.IO;
using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    class Program
    {

        static void Main(string[] args)
        {
            InputConverter input = new InputConverter();
            OutputService output = new OutputService();
            MenuExplorer menu = new MenuExplorer();
            string closeTime = "23:30";
            DateTime time = DateTime.Parse(closeTime);
              output.callMenu(time,menu);
              input.readOrder(time,output,menu);
              output.order(2,menu);
            EditMenu edit = new EditMenu();
            input.AddingDish(edit);
            input.readOrder(time, output, menu);
        }
    }
}
