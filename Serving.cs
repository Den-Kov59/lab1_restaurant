using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public class Serving
    {
        //Storage storage = new Storage();
        //Menu menu = new Menu();
        public void loadDishes(List<Dish> dishes)
        {
            Dictionary<Ingredient, double> recipy1 = new Dictionary<Ingredient, double>();
            recipy1.Add(new Ingredient("Bread", false), 0.25);
            recipy1.Add(new Ingredient("Steak", true), 0.4);
            recipy1.Add(new Ingredient("Tomato", false), 0.2);
            recipy1.Add(new Ingredient("Salad", false), 0.1);
            dishes.Add(new Dish("Sandwich", 10, 1, recipy1));
            Dictionary<Ingredient, double> recipy2 = new Dictionary<Ingredient, double>();
            recipy2.Add(new Ingredient("Tomato", false), 0.25);
            recipy2.Add(new Ingredient("Chicken", true), 0.5);
            recipy2.Add(new Ingredient("Potato", true), 1);
            dishes.Add(new Dish("Chicken Soup", 50, 2.5, recipy2));
            Dictionary<Ingredient, double> recipy3 = new Dictionary<Ingredient, double>();
            recipy3.Add(new Ingredient("Ice Cream", false), 0.5);
            dishes.Add(new Dish("Ice Cream", 2, 0.5, recipy3));
            Dictionary<Ingredient, double> recipy4 = new Dictionary<Ingredient, double>();
            recipy4.Add(new Ingredient("Vine", false), 0.5);
            dishes.Add(new Dish("Vine", 2, 0.5, recipy4));

        }
        public bool decIngr(int dishNum, List<Dish> dishes, Storage storage)
        {
            List<Ingredient> hist = new List<Ingredient>();
            Dish dish = dishes[dishNum - 1];
           // storage.loadIngredients();
            foreach (Ingredient ing in dish.ingridients.Keys)
            {
                hist.Add(ing);
                if (!storage.decrIngCount(ing, dish.ingridients[ing]))
                {
                    foreach (Ingredient ingi in hist)
                    {
                        storage.revDecr(ingi, dish.ingridients[ingi]);
                    }
                    return false;
                }

            }
            return true;
        }
        
    }
}
