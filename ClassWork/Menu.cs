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


        public void RemoveFood(string name,double price)
        {
            
            bool count = false;
            foreach(string item in menu.Keys)
            {
                if (item.Equals(name))
                {
                    count = true;
                    menu.Remove(name);
                }
           }
            if (count == false)
            {

                Console.WriteLine("We have not food of this type. ");
                
            }
       }
      
        
    }
}
