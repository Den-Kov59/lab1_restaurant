using lab1_restaurant.core;
using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.IO
{
    public class InputConverter
    {
        public void readOrder(DateTime time,OutputService output, MenuExplorer menu)
        {
            Console.WriteLine("Choose dish number to order: ");
            string mesg = Console.ReadLine();
            try
            {
            int inpNum = msgParser(mesg, time,menu);
            //Console.WriteLine(inpNum);
            if (inpNum != 0)
            {
                output.order(inpNum,menu);
            }
            }catch(Exception)
            {
                Console.WriteLine("Wrong format");
            }
        }
        private int msgParser(string msg, DateTime time,MenuExplorer menu)
        {
            int num = int.Parse(msg);
            if (num > menu.getMenu(time).Dishes.Count || num < 0)
            {
                throw new ArgumentException();
            }
            else { return num; }
        }
        public void AddingDish(EditMenu edit)
        {
            Dish dish = new Dish(5, "Test", 12, 33.1);
            Dictionary<Ingredient, double> recipy = new Dictionary<Ingredient, double>();
            recipy.Add(edit.GetIngredients().Find(q => q.Id == 6), 33.1);
            dish.ingridients = recipy;
            edit.AddDish(dish);
            IMenu menu = edit.GetMenu(DateTime.Now);
            menu.Dishes.ForEach(d => Console.WriteLine(d));
            edit.RemoveDish(dish);
            menu = edit.GetMenu(DateTime.Now);
            menu.Dishes.ForEach(d => Console.WriteLine(d));
        }
    }
}
