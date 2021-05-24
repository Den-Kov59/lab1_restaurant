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
        private IMenu menu= new Menu();
        private Storage storage = new Storage();
        private Serving _serving = new Serving();

        public IMenu getMenu(DateTime time)
        {
            menu=_serving.getMenu(time);
            return menu;

        }
        public bool decIngred(int dishNum)
        {
            return _serving.decIngr(dishNum, storage);
        }
        public void check() { menu.Dishes=menu.CheckDishesAvailable(storage); }
        public bool DishOrder(Dish dish)
        {
            return _serving.DishOrder(dish, storage);
        }
    }
}
