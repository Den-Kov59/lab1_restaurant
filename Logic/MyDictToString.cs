using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.Logic
{
    public class MyDictToString
    {
        public Dictionary<Ingredient,double> dict { get; set; }
        public List<string> getStr()
        {
            List<string> str = new List<string>();
            foreach(Ingredient ing in dict.Keys)
            {
                str.Add(ing + " : " + dict[ing]);
            }
            return str;
        }
    }
}
