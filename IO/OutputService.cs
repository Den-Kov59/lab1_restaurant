using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.IO
{
    public class OutputService
    {
        private Serving _serving=new Serving();
        private IMenu Menu;
        public void callMenu(DateTime time,MenuExplorer menu)
        {
            Console.WriteLine("Menu");
            int iter = 1;
            Menu = menu.getMenu(time);
            foreach (Dish dish in Menu.Dishes)
            {
                Console.WriteLine($"{iter}. {dish}");
                iter++;
            }
            Console.WriteLine("0. Refresh");
        }
        public void order(int dishNum,MenuExplorer menu)
        {
            if (menu.decIngred(dishNum))
            {
                Console.WriteLine($"Success!, your {Menu.Dishes[dishNum-1]} is ready");
            }
            else { Console.WriteLine("Not enough ingridients"); }
        }
    }
}
