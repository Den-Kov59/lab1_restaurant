using lab1_restaurant.Access;
using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public class Serving
    {
        IMenu menu= new MenuLate();
        DbAccess db = new DbAccess();
        private List<Dish> DishRecipyConnected()
        {
            List<Dish> dishes= db.readDishes();
            dishes.ForEach(a => db.readDishIng(a));
            return dishes;
        }
        public IMenu getMenu(DateTime time)
        {
            menu.Dishes = DishRecipyConnected();
            if (time.TimeOfDay - DateTime.Now.TimeOfDay < new TimeSpan(1, 30, 0))
            {
                menu = (MenuLate) menu;
            }
            else { menu = (Menu)menu; }
            return menu;

        }
        public bool decIngr(int dishNum, Storage storage)
        {
            List<Ingredient> hist = new List<Ingredient>();
            Dish dish = menu.getDish(dishNum);
            foreach (Ingredient ing in dish.ingridients.Keys)
            {
                if (!storage.decrIngCount(ing, dish.ingridients[ing]))
                {
                    foreach (Ingredient ingi in hist)
                    {
                        storage.revDecr(ingi, dish.ingridients[ingi]);
                    }
                    return false;
                }
                hist.Add(ing);
            }
            return true;
        }
        public bool DishOrder(Dish dish, Storage storage)
        {
            List<Ingredient> hist = new List<Ingredient>();
            foreach (Ingredient ing in dish.ingridients.Keys)
            {
               
                if (!storage.decrIngCount(ing, dish.ingridients[ing]))
                {
                    foreach (Ingredient ingi in hist)
                    {
                        storage.revDecr(ingi, dish.ingridients[ingi]);
                    }
                    return false;
                }
                hist.Add(ing);
            }
            return true;
        }
        public bool RemoveDish(Dish dish)
        {
            try
            {
                db.RemoveDish(dish);
            }
            catch (Exception) { return false; }
            return true;
        }
        public bool AddDish(Dish dish)
        {
            try
            {
                db.AddDish(dish);
            }
            catch (Exception) { return false; }
            return true;
        }
    }
}
