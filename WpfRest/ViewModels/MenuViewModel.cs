using lab1_restaurant;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using WpfRest.Service;
using WpfRest.ViewModels.Entity;
using System.Windows;
using Prism.Commands;

namespace WpfRest
{
    public class MenuViewModel : BindableBase
    {
        private MenuService _model;
        private MainViewModel _mainViewModel;
        private Dish _selectedDish;
        public DelegateCommand<object> OrderCommand { get; }
        public DelegateCommand<object> GoEditCommand { get; }
        public DelegateCommand<object> GoStorageCommand { get; }
        public DelegateCommand<object> GoAddCommand { get; }
        
        public MenuViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            _model = new MenuService();
        }
        public MenuViewModel()
        {
            _mainViewModel = new MainViewModel();
            _model = new MenuService();
            OrderCommand = new DelegateCommand<object>(Order);
            GoAddCommand = new DelegateCommand<object>(GoAdd);
            GoEditCommand = new DelegateCommand<object>(GoEdit);
            GoStorageCommand = new DelegateCommand<object>(GoStorage);
        }


        public ObservableCollection<Dish> Dishes
        {
            get => _model.GetMenu();
            set
            {
                Dishes = value;
                RaisePropertyChanged(nameof(Dishes));
            }
        }
        private void Order(object obj)
        {
            if (_model.OrderDish(_selectedDish))
            {
                MessageBox.Show("Success!");
            }
            else MessageBox.Show("Error");
        }
        private void GoEdit(object obj)
        {
            _mainViewModel.Navigation.NavigateTo("EditPage");
        }
        private void GoStorage(object obj)
        {
            _mainViewModel.Navigation.NavigateTo("StoragePage");
        }
        private void GoAdd(object obj)
        {
            _mainViewModel.Navigation.NavigateTo("AddDishPage");
        }
        public Dish SelectedDish
        {
            get => _selectedDish;
            set
            {
                _selectedDish = value;
                RaisePropertyChanged(nameof(SelectedDish));
            }
        }
        public UserControl MenuControl
        {
            get => _mainViewModel.Navigation.GetControl("MenuControl");
        }
    }
}
