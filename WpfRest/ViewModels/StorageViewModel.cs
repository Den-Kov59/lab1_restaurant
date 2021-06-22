using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfRest.Service;
using WpfRest.ViewModels.Entity;

namespace WpfRest
{
    public class StorageViewModel:BindableBase
    {
        private MainViewModel _mainViewModel;
        private EditService _model;
        public DelegateCommand<object> GoBackCommand { get; }
        public StorageViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;

        }
        public StorageViewModel()
        {
            _model = new EditService();
            _mainViewModel = new MainViewModel();
            GoBackCommand = new DelegateCommand<object>(GoBack);
        }

        public UserControl StorageControl
        {
            get => _mainViewModel.Navigation.GetControl("StorageControl");
            set
            {
                StorageControl = value;
                RaisePropertyChanged(nameof(StorageControl));
            }
        }
        public ObservableCollection<Ingredient> Storage
        {
            get => _model.GetStorage();
        }
        private void GoBack(object obj)
        {
            _mainViewModel.Navigation.NavigateTo("MenuPage");
        }
    }
}
