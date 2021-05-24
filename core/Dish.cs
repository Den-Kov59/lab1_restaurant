using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.core
{
    public class Dish
    {
        string Name;
        int time;
        double weight;

        public Dictionary<Ingredient, double> ingridients { get; }
        public Dish(string name, int time, double weight, Dictionary<Ingredient, double> ingr)
        {
            Name = name;
            this.time = time;
            this.weight = weight;
            ingridients = ingr;
        }
        string ingrStr()
        {
            string res = "";

            ; foreach (Ingredient ing in ingridients.Keys)
            {
                res += ing.ToString() + " ";
            }
            return res;
        }
        public bool checkDishUseEl()
        {
            foreach (Ingredient ing in ingridients.Keys)
            {
                if (ing.isUseEl) return true;
            }
            return false;
        }
        public override string ToString()
        {
            return Name + "|| " + weight + "kg|| Ingredients: " + ingrStr();
        }
    }
}
