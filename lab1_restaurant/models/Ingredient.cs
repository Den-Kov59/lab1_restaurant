using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.core
{
    public class Ingredient
    {
        public int Id { get; }
        public string Name { get; }
        public bool isUseEl { get; }
        public Ingredient(int Id,string name, bool electricityStatus)
        {
            this.Id = Id;
            this.Name = name;
            this.isUseEl = electricityStatus;
        }

        public override string ToString()
        {
            return Id+"."+Name;
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Ingredient p = (Ingredient)obj;
                return p.Name == Name;
            }
        }
        public override int GetHashCode()
        {
            return -1234 + GetNameHash(Name);
        }
        private int GetNameHash(string Name)
        {
            int sum = 0;
            int m = 1;
            foreach (char ch in Name)
            {
                m += m;
                sum += Convert.ToInt32(ch) * m;
            }
            return sum;
        }
    }
}
