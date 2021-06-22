using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1_restaurant;
using lab1_restaurant.core;
using lab1_restaurant.Presenters;

namespace WinFormsMVP
{
    public partial class StartMenu : Form, IMainView
    {
        public IMenu Menu { get; set; }
        public List<Dish> SelectedDishes { get; set; }

        public event EventHandler<EventArgs> eRefreshMenu;
        public event EventHandler<EventArgs> SetOrder;

        public StartMenu()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            SelectedDishes = new List<Dish>();
            eRefreshMenu(this, EventArgs.Empty);
            base.OnLoad(e);
        }
        private void btnStorage_Click(object sender, EventArgs e)
        {
            StorageForm storageView = new StorageForm();
            StoragePresenter presenter = new StoragePresenter(storageView);
            this.Hide();
            storageView.ShowDialog();
            this.Show();
        }
        public void RefreshMenu()
        {
            lbMenu.DataSource = null;
            lbMenu.DataSource = Menu.Dishes;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            foreach (object o in lbMenu.SelectedItems)
            {
                SelectedDishes.Add((Dish)o);
            }
            try { SetOrder(this, EventArgs.Empty); }
            catch (ArgumentException q) { MessageBox.Show(q.Message); eRefreshMenu(this, EventArgs.Empty); }
            SelectedDishes.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            eRefreshMenu(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editView = new EditForm();
            EditPresenter presenter = new EditPresenter(editView);
            this.Hide();
            editView.ShowDialog();
            this.Show();
            eRefreshMenu(this, EventArgs.Empty);
        }
             
    
    }
}
