using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_restaurant
{
    public interface IMainView
    {
        IMenu Menu { get; set; }
        List<Dish> SelectedDishes { get; }
        void RefreshMenu();
        event EventHandler<EventArgs> eRefreshMenu;
        event EventHandler<EventArgs> SetOrder;
    }
}
