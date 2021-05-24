using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.CustomEventArgs
{
    public class DishEventArgs:EventArgs
    {
        public Dish dish { get; set; }
    }
}
