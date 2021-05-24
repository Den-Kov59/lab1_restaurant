using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.Logic
{
    public class EditMenu
    {
        private IMenu menu=new Menu();
        private Serving _serving = new Serving();
        private Storage _storage = new Storage();

        public IMenu GetMenu(DateTime time)
        {
            menu = _serving.getMenu(time);
            return menu;
        }
        public bool RemoveDish(Dish dish)
        {
            return _serving.RemoveDish(dish);
        }
        public bool AddDish(Dish dish)
        {
            return _serving.AddDish(dish);
        }
        public List<Ingredient> GetIngredients()
        {
            _storage.refreshProducts();
            List<Ingredient> ings = new List<Ingredient>();
            foreach(Ingredient ing in _storage.Products.Keys)
            {
                ings.Add(ing);
            }
            return ings;
        }
        public Dictionary<Ingredient,double> GetStorage()
        {
            _storage.refreshProducts();
            return _storage.Products;
        }
    }
}
