using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.core
{
    public class MenuLate: Menu
    {
        private List<Dish> _dishes = new List<Dish>();
        public List<Dish> dishes
        {
            get { return _dishes.Where(p => !p.checkDishUseEl()).ToList(); }
            set { _dishes = value; }
        }
    }
}
