using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.core
{
    public class Menu:IMenu
    {
        public List<Dish> Dishes { get; set; }
        
        public Dish getDish(int dishNum)
        {
            return Dishes[dishNum-1];
        }
        public List<Dish> CheckDishesAvailable(Storage storage)
        {
            List<Dish> AvailableMenu = new List<Dish>();
            bool Eligible = true;
            foreach(Dish d in Dishes)
            {
                foreach (Ingredient v in d.ingridients.Keys)
                {
                    if(!storage.CheckEnough(v, d.ingridients[v])) { Eligible=false; }
                }
                if (Eligible) AvailableMenu.Add(d);
                Eligible = true;
            }
            return AvailableMenu;
        }
    }
}
