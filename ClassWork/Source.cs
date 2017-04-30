using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Source
    {
        public static void AddCafe(Cafe c)
        {
            Cafe.ListOfCafes.Add(c);
        }
        public static void InitializeSource()
        {
            //
            // Initialization of Cafes and their menus:

            Cafe cafe1 = new Cafe("Jazzve", "9", "+374 10 493330", "35 Tumanyan St, Yerevan, Armenia", "http://www.jazzve.am", "info@jazzve.am");
            cafe1.Menu.AddingItemToMenu("Coffee Amerikano", 400);
            cafe1.Menu.AddingItemToMenu("Coffee Latte", 350);
            cafe1.Menu.AddingItemToMenu("Cake Walnut Chocolate", 1200);
            cafe1.Menu.AddingItemToMenu("Cake Tiramisu", 1300);
            Cafe cafe2 = new Cafe("Verona", "8", "+374 10 433353", "35 Isahakyan St, Yerevan, Armenia", "http://verona.am", "info@verona.am");
            cafe2.Menu.AddingItemToMenu("Sandwich with beef", 1100);
            cafe2.Menu.AddingItemToMenu("Sandwich California", 2000);
            cafe2.Menu.AddingItemToMenu("Ice Cream White lady", 1400);
            cafe2.Menu.AddingItemToMenu("Ice Cream Onasys", 1800);
            //
            // Adding cafes in list
            Cafe.ListOfCafes.Add(cafe1);
            Cafe.ListOfCafes.Add(cafe2);
        }
        public static void ClearSource()
        {
            Cafe.ListOfCafes.Clear();
        }
    }
}
