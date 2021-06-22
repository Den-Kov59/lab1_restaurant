using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.CustomEventArgs
{
    public class IngredientEventArgs:EventArgs
    {
        public Ingredient ing { get; set; }
        public double quant { get; set; }
    }
}
