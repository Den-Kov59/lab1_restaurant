using lab1_restaurant.core;
using lab1_restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1_restaurant.CustomEventArgs;
using lab1_restaurant.Presenters;

namespace WinFormsMVP
{
    public partial class EditForm : Form, IEditView
    {
        
        public double DishWeight { get; set; }
        public Dictionary<Ingredient, double> SelectedIngredients { get; set; }
        public Dish SelectedDish { get; set; }
        public List<Ingredient> Storage { get; set; }
        public IMenu menu { get; set; }

        public event EventHandler<DishEventArgs> AddingDish;
        public event EventHandler<EventArgs> RemovingDish;
        public event EventHandler<EventArgs> RefreshingMenu;
        public EditForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            SelectedIngredients = new Dictionary<Ingredient, double>();
            lbMenu.DataSource = menu.Dishes;
            lbIngrAvailable.DataSource = Storage;
            base.OnLoad(e);
        }
        private void lbIngrAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingredient selectedIng = (Ingredient)lbIngrAvailable.SelectedItem;
            lblProductName.Text = selectedIng.ToString();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ing = (Ingredient)lbIngrAvailable.SelectedItem;
            SelectedIngredients.Add(ing, double.Parse(tbProdQuant.Text));
            DishWeight += double.Parse(tbProdQuant.Text);
            refreshSelectedIngredients();
        }
        private void refreshSelectedIngredients()
        {
            tbProdQuant.Text = "";
            lblDishWeight.Text = DishWeight.ToString()+"kg";
            lbSelectedIngr.DataSource = null;
            lbSelectedIngr.DataSource = SelectedIngredients.Keys.ToList<Ingredient>();
        }
        private void refreshMenu()
        {
            lbMenu.DataSource = null;
            lbMenu.DataSource = menu.Dishes;
        }
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            Dish newDish = new Dish(menu.Dishes.Count + 1, tbDishName.Text, int.Parse(tbDishTime.Text), DishWeight);
            newDish.ingridients = SelectedIngredients;
            DishEventArgs args = new DishEventArgs();
            args.dish = newDish;
            try
            {
                AddingDish(this, args);
            }catch(FormatException q)
            {
                MessageBox.Show(q.Message);
            }
            RefreshingMenu(this, EventArgs.Empty);
            refreshMenu();
            clearAll();
        }
        private void clearAll()
        {
            DishWeight = 0;
            SelectedIngredients.Clear();
            tbDishName.Text = "";
            tbDishTime.Text = "";
            tbProdQuant.Text = "";
            refreshSelectedIngredients();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnRemoveDish_Click(object sender, EventArgs e)
        {
            SelectedDish = (Dish)lbMenu.SelectedItem;
            RemovingDish(this, EventArgs.Empty);
            RefreshingMenu(this, EventArgs.Empty);
            refreshMenu();
        }

        private void tbProdQuant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
