using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace ClassWork
{
    class Cafe:IComparable
    {
        public string Name { get; private set; }
        public string phoneNumber { get; private set; }
        public GeoCoordinate Adress
        {
            get
            {
                return Adress;
            }
            set
            {
                Adress = value;
            }
        }
        public double Rating { get; private set; }
        public OfficialPage officialPage = new OfficialPage();
        public Cafe(string name, string phoneNumber, GeoCoordinate adress, double rating)
        {
            this.Name = name;
            this.Adress = adress;
            this.phoneNumber = phoneNumber;
            this.Rating = rating;
            
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
