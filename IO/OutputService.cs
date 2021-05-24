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
        private List<Dish> dishes;
        public void GetDishes(DateTime time,MenuExplorer menu)
        {
            menu.loadIng();
            dishes = menu.getMenu(time);
        }
        public void callMenu(DateTime time,MenuExplorer menu)
        {
            Console.WriteLine("Menu");
            int iter = 1;
            GetDishes(time,menu);
            foreach (Dish dish in dishes)
            {
                Console.WriteLine($"{iter}. {dish}");
                iter++;
            }
            Console.WriteLine("0. Refresh");
        }
        public void order(int dishNum,MenuExplorer menu)
        {
            //Console.WriteLine(dishes.Count);
            if (menu.decIngred(dishNum, dishes))
            {
                Console.WriteLine($"Success!, your {dishes[dishNum-1]} is ready");
            }
            else { Console.WriteLine("Not enough ingridients"); }
        }
    }
}
