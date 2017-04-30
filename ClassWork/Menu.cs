using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Menu
    {



        public Dictionary<string, double> menu = new Dictionary<string, double>();

        public double GetPriceForFood(string item)
        {
            double price=0;
            foreach (string k in menu.Keys)
            {
                if (k.Equals(item))
                {
                    price = menu[k];
                    break;
                }
            }
            return price;
        }
        public bool ExistsFood(string item)
        {
            bool exists = false;
           foreach (string k in menu.Keys)
            {
                if (k.Equals(item))
                {
                    exists = true;
                }
               
            }
            if (exists)
                return true;
            else
                return false;
        }
        public void AddingItemToMenu(string item, double value)
        {
            menu.Add(item, value);
        }
        public void RemovingItemFromMenu(string item)
        {
            bool exists = true;
            foreach (string k in menu.Keys)
            {
                if (k.Equals(item))
                {
                    menu.Remove(k);
                }
                else
                {
                    exists = false;

                }
                if (!exists)
                {
                    Console.WriteLine("ERROR!!! \n item does does not exist!!!");
                }
            }
        }
        public void ChangeValue(string item, double newValue)
        {
            foreach (string k in menu.Keys)
            {
                if (k.Equals(item))
                {
                    menu[k] = newValue;
                }
            }
        }
        public void SaleForAll(double Percent)
        {
            foreach (string key in menu.Keys)
            {
                menu[key] = menu[key] * Percent / 100;
            }
        }
        public void SaleForItem(string item, double Percent)
        {
            bool exists = true;
            foreach (string key in menu.Keys)
            {
                if (key.Equals(item))
                {
                    menu[key] = menu[key] * Percent / 100;
                }
                else
                {
                    exists = false;
                }
            }
            if (exists == false)
                Console.WriteLine("ERROR!!! \n item does not excist!!!");
        }
    }
}
