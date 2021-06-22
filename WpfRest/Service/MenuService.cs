using lab1_restaurant;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRest.ViewModels.Entity;

namespace WpfRest.Service
{
    public class MenuService
    {
        private MenuExplorer _model;
        private const string closetime = "23:00";

        public MenuService()
        {
            _model = new MenuExplorer();
        }
        public ObservableCollection<Dish> GetMenu()
        {
            ObservableCollection<Dish> dishes = new ObservableCollection<Dish>();
            List<lab1_restaurant.core.Dish> dds=_model.getMenu(DateTime.Parse(closetime)).Dishes;
            dds.ForEach(a => dishes.Add(parseOldDish(a)));
            return dishes;
        }
        public bool OrderDish(Dish dish)
        {
            lab1_restaurant.core.Dish d= _model.getMenu(DateTime.Parse(closetime)).Dishes.Find(a=> a.Name.Equals(dish.Name));
            return _model.DishOrder(d);
        }
        private Dish parseOldDish(lab1_restaurant.core.Dish dish)
        {
            Dish d = new Dish();
            d.Name = dish.Name;
            d.Weight = dish.weight;
            d.Time = dish.time;
            List<lab1_restaurant.core.Ingredient> oldings = dish.ingridients.Keys.ToList();
            oldings.ForEach(a => d.Ingredients.Add(parseOldIngredient(a,dish.ingridients)));
            return d;
        } 
        private Ingredient parseOldIngredient(lab1_restaurant.core.Ingredient ing, Dictionary<lab1_restaurant.core.Ingredient,double> dict)
        {
            Ingredient i = new Ingredient();
            i.Id = ing.Id;
            i.Name = ing.Name;
            i.isUseEl = ing.isUseEl;
            i.Quantity = dict[ing];
            return i;
        }
    }
}
