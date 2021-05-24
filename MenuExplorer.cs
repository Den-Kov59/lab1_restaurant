using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public class MenuExplorer
    {
        private Menu menu;
        private Storage storage = new Storage();
        private Serving _serving = new Serving();
        
        public void loadIng()
        {
            storage.loadIngredients();
        }
        public List<Dish> getMenu(DateTime time)
        {
            //Console.WriteLine($"{time.TimeOfDay- DateTime.Now.TimeOfDay}");
            if (time.TimeOfDay - DateTime.Now.TimeOfDay > new TimeSpan(1, 30, 0))
            {
                menu = new Menu();

            }
            else
            {
                menu = new MenuLate();
            }
            _serving.loadDishes(menu.Dishes);
            return menu.Dishes;

        }
        public bool decIngred(int dishNum,List<Dish> dishes)
        {
            return _serving.decIngr(dishNum, dishes,storage);
        }
    }
}
