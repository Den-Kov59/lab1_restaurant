using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.Presenters
{
    public class MainPresenter
    {
        private MenuExplorer _model=new MenuExplorer();
        private IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.eRefreshMenu += new EventHandler<EventArgs>(OnRefreshMenu);
            _view.SetOrder += new EventHandler<EventArgs>(OnSetOrder);
        }
        private void OnRefreshMenu(object sender, EventArgs e)
        {
            string closeTime = "23:30";
            DateTime time = DateTime.Parse(closeTime);
            _view.Menu = _model.getMenu(time);
            _model.check();
            _view.RefreshMenu();
        }
        private void OnSetOrder(object sender,EventArgs e)
        {
            foreach(Dish d in _view.SelectedDishes)
            {
                if(!_model.DishOrder(d)){
                    throw new ArgumentException("Can't order dishes");
                }
            }
            
        }
    }
}
