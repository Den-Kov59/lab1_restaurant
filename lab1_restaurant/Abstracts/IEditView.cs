using lab1_restaurant.core;
using lab1_restaurant.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public interface IEditView
    {
        double DishWeight { get; set; }
        IMenu menu { get; set; }
        Dictionary<Ingredient,double> SelectedIngredients { get; set; }
        List<Ingredient> Storage { get; set; }
        Dish SelectedDish { get; set; }
        event EventHandler<DishEventArgs> AddingDish;
        event EventHandler<EventArgs> RemovingDish;
        event EventHandler<EventArgs> RefreshingMenu;
    }
}
