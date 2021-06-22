using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfRest.Service;
using WpfRest.ViewModels.Entity;

namespace WpfRest
{
    public class EditViewModel : BindableBase
    {
        private MainViewModel _mainViewModel;
        private EditService _model;
        private Dish _selectedDish;
        private UserControl _dishControl;
        private ObservableCollection<Ingredient> _dishIng;
        private Ingredient _selectedIng;
        private double _ingq=0;
        private string _dishName;
        private int _dishTime=0;
        private double _dishWeight=0;
        public DelegateCommand<object> GoBackCommand { get; }
        public DelegateCommand<object> AddProductCommand { get; }
        public DelegateCommand<object> AddDishCommand { get; }
        public DelegateCommand<object> ClearAllCommand { get; }
        public EditViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            GoBackCommand = new DelegateCommand<object>(GoBack);
        }
        public EditViewModel()
        {
            _mainViewModel = new MainViewModel();
            GoBackCommand = new DelegateCommand<object>(GoBack);
            _model = new EditService();
            _dishIng = new ObservableCollection<Ingredient>();
            AddProductCommand = new DelegateCommand<object>(AddProduct);
            AddDishCommand = new DelegateCommand<object>(AddDish);
            ClearAllCommand = new DelegateCommand<object>(ClearAll);
        }

        public Ingredient SelectedIngredient
        {
            get => _selectedIng;
            set
            {
                _selectedIng = value;
                RaisePropertyChanged(nameof(SelectedIngredient));
            }
        }
        public Dish SelectedProduct
        {
            get => _selectedDish;
            set
            {
                _selectedDish = value;
                DishControl = _mainViewModel.Navigation.GetControl("DishControl");
                RaisePropertyChanged(nameof(SelectedProduct));
            }
        }
        public double IngQuant
        {
            get => _ingq;
            set
            {
                _ingq = value;
                RaisePropertyChanged(nameof(IngQuant));
            }
        }
        public string DishName
        {
            get => _dishName;
            set
            {
                _dishName = value;
                RaisePropertyChanged(nameof(DishName));
            }
        }
        public int DishTime
        {
            get => _dishTime;
            set
            {
                _dishTime = value;
                RaisePropertyChanged(nameof(DishTime));
            }
        }
        public double DishWeight
        {
            get => _dishWeight;
            set
            {
                _dishWeight = value;
                RaisePropertyChanged(nameof(DishWeight));
            }
        }

        private void GoBack(object obj)
        {
            _mainViewModel.Navigation.NavigateTo("MenuPage");
        }
        private void AddProduct(object obj){
            Ingredient t = SelectedIngredient;
            t.Quantity = IngQuant;
            DishIngs.Add(t);
            IngQuant = 0;
            }
        private void AddDish(object obj){
            Dish p = new Dish();
            p.Name = DishName;
            p.Time = DishTime;
            p.Weight = DishWeight;
            p.Ingredients = DishIngs;
            _model.AddDish(p);
            ClearAll(p);
            }
        private void ClearAll(object obj){
            SelectedProduct = null;
            IngQuant = 0;
            DishName = null;
            DishTime = 0;
            DishWeight = 0;
            DishIngs.Clear();
            }

        public ObservableCollection<Dish> Menu
        {
            get => _model.GetMenu();
        }
        public ObservableCollection<Ingredient> Ingredients
        {
            get => _model.GetIngredients();
        }
        public ObservableCollection<Ingredient> DishIngs
        {
            get => _dishIng;
            set
            {
                _dishIng = value;
                RaisePropertyChanged(nameof(DishIngs));
            }
        }


        public UserControl EditControl {
            get => _mainViewModel.Navigation.GetControl("EditControl");
        }
        public UserControl AddDishControl
        {
            get => _mainViewModel.Navigation.GetControl("AddDishControl");
        }
        public UserControl DishControl
        {
            get => _mainViewModel.Navigation.GetControl("DishControl");
            set
            {
                _dishControl = value;
                RaisePropertyChanged(nameof(DishControl));
            }
        }
    }
}
