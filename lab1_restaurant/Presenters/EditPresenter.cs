using lab1_restaurant.CustomEventArgs;
using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.Presenters
{
    public class EditPresenter
    {
        private EditMenu _model = new EditMenu();
        private IEditView _view;
        string closeTime = "23:30";
        public EditPresenter(IEditView view)
        {
            _view = view;
            _view.Storage = _model.GetIngredients();
            _view.menu = _model.GetMenu(DateTime.Parse(closeTime));
            _view.AddingDish += new EventHandler<DishEventArgs>(OnAddingDish);
            _view.RefreshingMenu += new EventHandler<EventArgs>(OnRefreshingMenu);
            _view.RemovingDish += new EventHandler<EventArgs>(OnRemovingDish);
        }
        void OnAddingDish(object sender,DishEventArgs args)
        {
            try 
            {
                _model.AddDish(args.dish);
            }
            catch (Exception)
            {
                throw new FormatException("Couldn't add dish");
            }
            
        }
        void OnRefreshingMenu(object sender,EventArgs e)
        {
            _view.menu = _model.GetMenu(DateTime.Parse(closeTime));
        }
        void OnRemovingDish(object sender,EventArgs e)
        {
            _model.RemoveDish(_view.SelectedDish);
        }
    }
}
