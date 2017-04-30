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
     
            //
            // List of objects(cafes)(Initialization @see CafeProject.Source.cs):        

            public static List<Cafe> ListOfCafes = new List<Cafe>();

            //
            // Initialization of cafes menu:
            public Menu Menu = new Menu();
            //
            // Fields:
            public static int count = ListOfCafes.Count;


            private string name;
            private string rank;
            private string phoneNumber;
            public string adress;
            public string webPage;
            public string email;
            // 
            // Constructors:

            public Cafe(string name, string rank, string phoneNumber, string adress, string webPage, string email)
            {
                this.Name = name;
                this.PhoneNumber = phoneNumber;
                this.Adress = adress;
                if (rank.Equals("")) { this.Rank = "not specefied"; }
                else { this.Rank = rank; }
                if (webPage.Equals("")) { this.WebPage = "not specefied"; }
                else { this.WebPage = webPage; }
                if (email.Equals("")) { this.Email = "not specefied"; }
                else { this.Email = email; }
            }

            //
            // Properties:
            public string Name
            {
                get
                {
                    return this.name;
                }
                private set
                {
                    this.name = value;
                }
            }
            public string Rank
            {
                get
                {
                    return this.rank;
                }
                private set
                {
                    if (double.Parse(value) > 10 || double.Parse(value) < 0)
                    {
                        Console.WriteLine("Please enter value in range 0-10");
                    }
                    else
                    {
                        this.rank = value;
                    }
                }
            }
            public string PhoneNumber
            {
                get
                {
                    return this.phoneNumber;
                }
                set
                {
                    this.phoneNumber = value;
                }
            }
            public string Adress
            {
                get
                {
                    return this.adress;
                }
                set
                {
                    this.adress = value;
                }
            }
            public string WebPage
            {
                get
                {
                    return this.webPage;
                }
                set
                {
                    this.webPage = value;
                }

            }
            public string Email
            {
                get
                {
                    return this.email;
                }
                set
                {
                    this.email = value;
                }
            }
            //
            // Methods


            //
            // Getting information about object(cafe):
            public override string ToString()
            {
                string information;
                information = "___________________________________________\n";
                information += String.Format("Cafes name : {0} \nRank : {1} \nPhone Number : {2} \nAdress : {3} \nWeb Page URL : {4} \nEmail : {5} \n"
                    , this.Name, this.Rank, this.PhoneNumber, this.Adress, this.WebPage, this.Email);
                information += "___________________________________________";
                return information;
            }
      public int CompareTo(Object obj)
        {
            Cafe cafe = (Cafe)obj;
            if (this.Rating > cafe.Rating)
            {
                return -1;
            }
            else if (this.Rating < cafe.Rating)
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
