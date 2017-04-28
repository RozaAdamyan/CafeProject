using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Cafe:IComparable
    {
        string name;
        string phoneNumber;
        string adress;
        double rating;
        public OfficialPage officialPage = new OfficialPage();
        public Cafe(string name, string phoneNumber, string adress, double rating)
        {
            this.name = name;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.rating = rating;
            this.officialPage.adress = adress;
        }

        public int CompareTo(Object obj)
        {
            Cafe cafe = (Cafe)obj;
            if (this.rating > cafe.rating)
            {
                return -1;
            }
            else if (this.rating < cafe.rating)
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
