using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRest.ViewModels.Entity
{
    public class Ingredient:BindableBase
    {
        private string _name;
        private bool _useEl;
        private double _quantity;
        public int Id { get; set; }
        public string Name 
        { 
            get=>_name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }
        public bool isUseEl 
        { 
            get=>_useEl;
            set
            {
                _useEl = value;
                RaisePropertyChanged(nameof(isUseEl));
            }
        }
        public double Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                RaisePropertyChanged(nameof(Quantity));
            }
        }
    }
}
