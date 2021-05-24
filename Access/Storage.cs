using lab1_restaurant.Access;
using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public class Storage
    {
        private DbAccess db = new DbAccess();

        public Dictionary<Ingredient, double> Products { get; set; }
        public Storage()
        {
         //   RestoreStorage();
            Products = db.readStorage();
        }
        public void refreshProducts()
        {
            Products = db.readStorage();
        }
        public bool decrIngCount(Ingredient ing, double quant)
        {
            if (Products[ing] - quant < 0)
            {
                return false;
            }
            else
            {
                Products[ing] -= quant;
                db.UpdateStorage(ing, Products[ing].ToString());
                return true;
            }
        }
        public void revDecr(Ingredient ing, double quant)
        {
            Products[ing] += quant;
            db.UpdateStorage(ing, Products[ing].ToString());
        }
        public bool CheckEnough(Ingredient ing, double quant)
        {
            if (Products[ing] - quant < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RestoreStorage() { db.RestoreStorage();  }
    }
}
