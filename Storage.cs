using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public class Storage
    {
        private Dictionary<Ingredient, double> _Products = new Dictionary<Ingredient, double>();
        public Dictionary<Ingredient, double> Products { get { return _Products; } }
        public void addProduct(Ingredient ing, double quantity)
        {
            Products.Add(ing, quantity);

        }
        public void loadIngredients()
        {
            addProduct(new Ingredient("Bread", false), 12);
            addProduct(new Ingredient("Steak", true), 10.1);
            addProduct(new Ingredient("Salad", false), 6);
            addProduct(new Ingredient("Tomato", false), 5.4);
            addProduct(new Ingredient("Potato", true), 15);
            addProduct(new Ingredient("Chicken", true), 6);
            addProduct(new Ingredient("Ice Cream", false), 17);
            addProduct(new Ingredient("Vine", false), 20);
        }

        public bool decrIngCount(Ingredient ing, double quant)
        {
            if (Products[ing] - quant < 0)
            {
                return false;
            }
            else
            {
                Products[ing] -= quant;
                return true;
            }
        }
        public void revDecr(Ingredient ing, double quant)
        {
            Products[ing] += quant;
        }
    }
}
