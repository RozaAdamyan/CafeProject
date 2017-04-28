using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Menu
    {
        Dictionary<string, double> menu = new Dictionary<string, double>();
        public void AddFood(string name,double price)
        {
            menu.Add(name, price);
        }
    }
}
