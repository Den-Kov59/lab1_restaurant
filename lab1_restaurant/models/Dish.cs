using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.core
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int time { get; set; }
        public double weight { get; set; }

        public Dictionary<Ingredient, double> ingridients { get; set; }
        public Dish(int id,string name, int time, double weight)
        {
            this.Id = id;
            Name = name;
            this.time = time;
            this.weight = weight;
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
