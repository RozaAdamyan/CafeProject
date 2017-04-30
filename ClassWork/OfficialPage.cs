using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class OfficialPage : IComparable
    {
        Cafe cafe = new Cafe();
        //properties
        List<double> votes;
        List<string> commentBook;
        public double Vote
        {
            get
            {
                return Vote;
            }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    Vote = value;
                    votes.Add(Vote);
                }
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                this.Name = " " + cafe.Name + ".am";
            }
        }
        public int CountOfFollowers { get; private set; }

        public OfficialPage()
        {
            votes = new List<double>();
            commentBook = new List<string>();
        }
        //methods
        public void GetInformAboutCafe()
        {
            cafe.ToString();
            Console.WriteLine("Do not forgote vote us.");
        }
        public void OnlineOrder(string item, double yourMoney)
        {
            Menu menu = new Menu();
            double price = menu.GetPriceForFood(item);
            if (menu.ExistsFood(item))
            {
                Console.WriteLine("Please pay for Order.You must pay {0} dram", price);
                if (Paying(item, yourMoney))
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
        private bool Paying(string item, double balance)
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
        public int CountOfVotes()
        {
            return this.votes.Count;
        }
        public double VotingResultsByPercents()
        {
            double sum = 0;
            double maxSum = 5 * CountOfVotes();
            foreach (double vote in this.votes)
            {
                sum += vote;
            }
            return sum * 100 / maxSum;
        }
        public void WriteComment()
        {
            commentBook.Add(Console.ReadLine());
        }
        public void ShowAllComments()
        {
            foreach(string comment in commentBook)
            {
                Console.WriteLine(comment);
            }
        }

    }
}
