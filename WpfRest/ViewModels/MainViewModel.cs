using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRest
{
    public class MainViewModel : BindableBase 
    {
        public ViewModelLocator Navigation;
        private EditViewModel _editVM;
        private MenuViewModel _menuVM;
        public MainViewModel()
        {
            Navigation = new ViewModelLocator();
            _editVM = new EditViewModel(this);
            _menuVM = new MenuViewModel(this);
        }
        public EditViewModel EditViewModel
        {
            get => _editVM;
            set
            {
                _editVM = value;
                RaisePropertyChanged(nameof(EditViewModel));
            }
        }
        public MenuViewModel MenuViewModel
        {
            get => _menuVM;
            set
            {
                _menuVM = value;
                RaisePropertyChanged(nameof(MenuViewModel));
            }
        }
    }
}
