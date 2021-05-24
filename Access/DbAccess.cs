using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using lab1_restaurant.core;
using System.Globalization;

namespace lab1_restaurant.Access
{
    public class DbAccess
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\mtrps\lab1_restaurant\RestaurantDB.mdf;Integrated Security=True"); 
        public DbAccess()
        {
        }
        public List<Dish> readDishes()
        {
            List<Dish> dishes = new List<Dish>();
            cnn.Close();
            cnn.Open();
            string sqlcom = "Select ID,Name,Weight,Time from dbo.Menu;";
            SqlCommand getAllDishes = new SqlCommand(sqlcom, cnn);
            SqlDataReader dataReader = getAllDishes.ExecuteReader();
            while (dataReader.Read())
            {
                dishes.Add(new Dish(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(3), dataReader.GetDouble(2)));
            }
            cnn.Close();
            return dishes;
        }
        public void readDishIng(Dish dish)
        {
            cnn.Open();
            
            string sqlcom = $"Select dbo.Storage.ID,dbo.Storage.Name, dbo.Storage.IsUseEl, dbo.Ingredients.InDishQuantity from dbo.Ingredients left join Storage on dbo.Ingredients.ProductID=dbo.Storage.Id where dbo.Ingredients.DishID={dish.Id};";
            SqlCommand getRecepy = new SqlCommand(sqlcom, cnn);
            SqlDataReader dataReader = getRecepy.ExecuteReader();
            Dictionary<Ingredient, double> receipt = new Dictionary<Ingredient, double>();
            while (dataReader.Read())
            {
                Ingredient ing = new Ingredient(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetBoolean(2));
                receipt.Add(ing, dataReader.GetDouble(3));
            }
            dish.ingridients=receipt;
            cnn.Close();
        }
        public Dictionary<Ingredient, double> readStorage() 
        {
            Dictionary<Ingredient, double> ingredients = new Dictionary<Ingredient, double>();
            cnn.Open();
            string sqlcom = "Select * from dbo.Storage;";
            SqlCommand getStorage = new SqlCommand(sqlcom, cnn);
            SqlDataReader dataReader = getStorage.ExecuteReader();
            while (dataReader.Read())
            {
                Ingredient ing = new Ingredient(dataReader.GetInt32(0),dataReader.GetString(1), dataReader.GetBoolean(2));
                ingredients.Add(ing,dataReader.GetDouble(3));
            }
            cnn.Close();
            return ingredients;
        }
        public void UpdateStorage(Ingredient ing, string quant)
        {
            cnn.Close();
            cnn.Open();
            string sqlcom = $"update dbo.Storage set dbo.Storage.Quantity={quant.Replace(',','.')} where dbo.Storage.Id={ing.Id};";
            SqlCommand setUpdate = new SqlCommand(sqlcom, cnn);
            setUpdate.ExecuteNonQuery();
            cnn.Close();
        }
        public void RestoreStorage()
        {
            cnn.Open();
            string update = "update dbo.Storage set dbo.Storage.Quantity=12 where dbo.Storage.Id=1;" +
                "update dbo.Storage set dbo.Storage.Quantity=10.1 where dbo.Storage.Id=2;" +
                "update dbo.Storage set dbo.Storage.Quantity=6 where dbo.Storage.Id=3;" +
                "update dbo.Storage set dbo.Storage.Quantity=5.4 where dbo.Storage.Id=4;" +
                "update dbo.Storage set dbo.Storage.Quantity=15 where dbo.Storage.Id=5;" +
                "update dbo.Storage set dbo.Storage.Quantity=16 where dbo.Storage.Id=6;" +
                "update dbo.Storage set dbo.Storage.Quantity=17 where dbo.Storage.Id=7;" +
                "update dbo.Storage set dbo.Storage.Quantity=20 where dbo.Storage.Id=8;";
            SqlCommand setUpdate = new SqlCommand(update, cnn);
            setUpdate.ExecuteNonQuery();
            cnn.Close();
        }
        public void AddDish(Dish dish)
        {
            cnn.Open();
            Console.WriteLine("Start adding");
            string weight=dish.weight.ToString().Replace(",",".");
            string applyToMenu = $"Insert into dbo.Menu (Id,Name, Weight, Time) Values ({dish.Id},'{dish.Name}',{weight},{dish.time});";
            Console.WriteLine(applyToMenu);
            SqlCommand setUpdate = new SqlCommand(applyToMenu, cnn);
            setUpdate.ExecuteNonQuery();
            foreach(Ingredient ing in dish.ingridients.Keys)
            {
                string quant= dish.ingridients[ing].ToString().Replace(",", ".");
                string applyToIngredients = $"Insert into dbo.Ingredients (ProductId, InDishQuantity, DishId) Values ({ing.Id},{quant},{dish.Id});";
                Console.WriteLine(applyToIngredients);
                setUpdate = new SqlCommand(applyToIngredients, cnn);
                setUpdate.ExecuteNonQuery();
            }
            cnn.Close();
        }
        public void RemoveDish(Dish dish)
        {
            cnn.Open();
            string deleteFromIngredients = $"Delete from dbo.Ingredients where DishId={dish.Id};";
            Console.WriteLine(deleteFromIngredients);
            SqlCommand setUpdate = new SqlCommand(deleteFromIngredients, cnn);
            setUpdate.ExecuteNonQuery();
            string deleteFromMenu = $"Delete from dbo.Menu where Id={dish.Id};";
            Console.WriteLine(deleteFromMenu);
             setUpdate = new SqlCommand(deleteFromMenu, cnn);
            setUpdate.ExecuteNonQuery();
           
            cnn.Close();
        }
    }
}
