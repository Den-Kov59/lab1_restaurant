using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRest.ViewModels.Entity;

namespace WpfRest.Service
{
    public class EditService
    {
        private const string closetime= "23:30";
        private EditMenu _model;
        public EditService()
        {
            _model = new EditMenu();
        }
        public ObservableCollection<Dish> GetMenu()
        {
            ObservableCollection<Dish> dishes = new ObservableCollection<Dish>();
            List<lab1_restaurant.core.Dish> dds = _model.GetMenu(DateTime.Parse(closetime)).Dishes;
            dds.ForEach(a => dishes.Add(parseOldDish(a)));
            return dishes;
        }
        public bool RemoveDish(Dish dish)
        {
            return _model.RemoveDish(FindDish(dish));
        }
        public bool AddDish(Dish dish)
        {
            return _model.AddDish(ParseNewDish(dish));
        }
        public ObservableCollection<Ingredient> GetIngredients()
        {
            ObservableCollection<Ingredient> res = new ObservableCollection<Ingredient>();
            _model.GetIngredients().ForEach(a => res.Add(parseOldIngredient(a)));
            return res;
        }
        public ObservableCollection<Ingredient> GetStorage()
        {
            ObservableCollection<Ingredient> res = new ObservableCollection<Ingredient>();
            Dictionary<lab1_restaurant.core.Ingredient,double> ins = _model.GetStorage();
            ins.Keys.ToList().ForEach(a => res.Add(parseOldIngredient(a, ins)));
            return res; 
        }
        private lab1_restaurant.core.Dish ParseNewDish(Dish dish)
        {
            lab1_restaurant.core.Dish d = new lab1_restaurant.core.Dish(GetMenu().Count, dish.Name, dish.Time, dish.Weight);
            Dictionary<lab1_restaurant.core.Ingredient, double> rec = new Dictionary<lab1_restaurant.core.Ingredient, double>();
            dish.Ingredients.ToList().ForEach(a => rec.Add(new lab1_restaurant.core.Ingredient(a.Id, a.Name, a.isUseEl), a.Quantity));
            d.ingridients = rec;
            return d;
        }
        private lab1_restaurant.core.Dish FindDish(Dish dish)
        {
            return _model.GetMenu(DateTime.Parse(closetime)).Dishes.Find(a => a.Name.Equals(dish.Name));   
        }
        private Dish parseOldDish(lab1_restaurant.core.Dish dish)
        {
            Dish d = new Dish();
            d.Name = dish.Name;
            d.Weight = dish.weight;
            d.Time = dish.time;
            List<lab1_restaurant.core.Ingredient> oldings = dish.ingridients.Keys.ToList();
            oldings.ForEach(a => d.Ingredients.Add(parseOldIngredient(a, dish.ingridients)));
            return d;
        }
        private Ingredient parseOldIngredient(lab1_restaurant.core.Ingredient ing, Dictionary<lab1_restaurant.core.Ingredient, double> dict)
        {
            Ingredient i = new Ingredient();
            i.Id = ing.Id;
            i.Name = ing.Name;
            i.isUseEl = ing.isUseEl;
            i.Quantity = dict[ing];
            return i;
        }
        private Ingredient parseOldIngredient(lab1_restaurant.core.Ingredient ing)
        {
            Ingredient i = new Ingredient();
            i.Id = ing.Id;
            i.Name = ing.Name;
            i.isUseEl = ing.isUseEl;
            return i;
        }
    }
}
