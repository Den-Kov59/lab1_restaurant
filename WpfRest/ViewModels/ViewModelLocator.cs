using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfRest.Controls;

namespace WpfRest
{
    public class ViewModelLocator
    {
        private readonly Dictionary<string, Uri> _pages;
        private readonly Dictionary<string, UserControl> _controls;
        public ViewModelLocator()
        {
            _pages = new Dictionary<string, Uri>();
            _controls = new Dictionary<string, UserControl>();
            _pages.Add("MenuPage", new Uri("../Pages/MenuPage.xaml", UriKind.Relative));
            _pages.Add("EditPage", new Uri("../Pages/EditPage.xaml", UriKind.Relative));
            _pages.Add("AddDishPage", new Uri("../Pages/AddDishPage.xaml", UriKind.Relative));
            _pages.Add("StoragePage", new Uri("../Pages/StoragePage.xaml", UriKind.Relative));

            _controls.Add("MenuControl", new MenuControl());
            _controls.Add("AddDishControl", new EditControl1());
            _controls.Add("DishControl", new DishControl());
            _controls.Add("EditControl", new EditControl());
            _controls.Add("StorageControl", new StorageControl());
        }
        public UserControl GetControl(string controlName)
        {
            return _controls[controlName];
        }
        public void NavigateTo(string pageKey)
        {
            if (GetDescendantFromName(System.Windows.Application.Current.MainWindow, "MainFrame") is Frame frame) frame.Source = _pages[pageKey];
        }
        private FrameworkElement GetDescendantFromName(DependencyObject parent, string name)
        {
            var count = VisualTreeHelper.GetChildrenCount(parent);

            if (count < 1) return null;

            for (var i = 0; i < count; i++)
            {
                if (VisualTreeHelper.GetChild(parent, i) is FrameworkElement frameworkElement)
                {
                    if (frameworkElement.Name == name) return frameworkElement;

                    frameworkElement = GetDescendantFromName(frameworkElement, name);
                    if (frameworkElement != null) return frameworkElement;
                }
            }
            return null;
        }
    }
}
