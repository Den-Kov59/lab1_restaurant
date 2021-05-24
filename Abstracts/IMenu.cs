using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.core
{
    public interface IMenu
    {
        List<Dish> Dishes { get; set; }
        Dish getDish(int dishNum);
        List<Dish> CheckDishesAvailable(Storage storage);

    }
}
