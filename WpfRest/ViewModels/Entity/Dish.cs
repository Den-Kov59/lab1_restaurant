using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRest.ViewModels.Entity
{
    public class Dish : BindableBase
    {
        private string _name;
        private int _time;
        private double _weight;
        public ObservableCollection<Ingredient> Ingredients;
        public Dish()
        {
            Ingredients = new ObservableCollection<Ingredient>();
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }
        public int Time
        {
            get => _time;
            set
            {
                _time = value;
                RaisePropertyChanged(nameof(Time));
            }
        }
        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                RaisePropertyChanged(nameof(Weight));
            }
        }
    }
}
