using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.Presenters
{
    public class StoragePresenter
    {
        EditMenu _model = new EditMenu();
        MyDictToString dict = new MyDictToString();
        IStorageView _view;
        public StoragePresenter(IStorageView view)
        {
            _view = view;
            dict.dict = _model.GetStorage();
            _view.Dict = dict;
        }
    }
}
