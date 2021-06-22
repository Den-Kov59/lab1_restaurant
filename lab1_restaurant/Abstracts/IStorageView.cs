using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant
{
    public interface IStorageView
    {
        MyDictToString Dict { get; set; }
    }
}
