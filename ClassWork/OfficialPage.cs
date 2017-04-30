using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class OfficialPage:IComparable
    {
        Cafe cafe = new Cafe();
        //properties
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                this.Name = " "+cafe.Name + ".am";
            }
        }
        public int CountOfFollowers { get; private set;}

        //methods
        public void GetInformAboutCafe()
        {
            cafe.ToString();
        }
        public void OnlineOrder(string item,double YourMoney)
        {
            Menu menu = new Menu();
            double price = menu.GetPriceForFood(item);
            if (menu.ExistsFood(item))
            {
                Console.WriteLine("Please pay for Order.You must pay {0} dram",price);
                if (Paying(item,YourMoney ))
                {
                    Console.WriteLine("Please Enter your Adress");
                    Console.ReadLine();
                    Console.WriteLine("Thanks for order.Your order will be in 1 hour.");
                }
            }
          
            else
            {
                Console.WriteLine("Sorry,at this time we haven't this food.You can choose another one.");
            }
        }
        private bool Paying(string item,double balance)
        {
            Menu menu = new Menu();
            double price = menu.GetPriceForFood(item);
            if (balance == price)
            {
                return true;
            }
            else
                return false;
       }
        public int CompareTo(Object obj)
        {
            OfficialPage cafe = (OfficialPage)obj;
            if (this.CountOfFollowers > cafe.CountOfFollowers)
            {
                return -1;
            }
            else if (this.CountOfFollowers < cafe.CountOfFollowers)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
       
    }
}
