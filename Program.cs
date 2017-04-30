using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear user !");
            Line1();
            Console.Write(">>");
            Console.WriteLine("Enter \"help\" for displaying commands.");
            while (true)
            {
                Console.Write(">>");
                string command = Console.ReadLine().Trim().ToLower();
                switch (command)
                {
                    case "show":
                        Line3();
                        if (Cafe.ListOfCafes.Count == 0)
                        {
                            Console.WriteLine("Database is empty, nothing to show !");
                        }
                        else
                        {
                            Console.WriteLine("Database :");
                            for (int i = 0; i < Cafe.ListOfCafes.Count; i++)
                            {
                                Console.WriteLine(Cafe.ListOfCafes[i].ToString());
                            }
                        }
                        Line3();
                        break;
                    case "import":
                    case "import_data":
                        Source.InitializeSource();
                        Console.WriteLine("Data is succesfully imported !");
                        break;
                    case "clear_data":
                        if (Cafe.ListOfCafes.Count == 0)
                        {
                            Console.WriteLine("Database is already empty !");
                            break;
                        }
                        Source.ClearSource();
                        Console.WriteLine("Database is succesfully cleared");
                        break;
                    case "add":
                    case "add_cafe":
                        Console.Write("Please enter the name : ");
                        string name = Console.ReadLine();
                        Console.Write("Please enter the adress : ");
                        string adress = Console.ReadLine();
                        Console.Write("Please enter the phone number : ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Please enter the WEB pages URL(optional) : ");
                        string webPage = Console.ReadLine();
                        Console.Write("Please enter the email(optional) : ");
                        string email = Console.ReadLine();
                        Console.Write("Please enter the rank of the cafe(in range 0-10)(optional) : ");
                        a: string rank = Console.ReadLine();
                        if (double.Parse(rank) > 10 || double.Parse(rank) < 0)
                        {
                            Console.WriteLine("Enter value in range 0-10");
                            goto a;
                        }
                        Source.AddCafe(new Cafe(name, rank, phoneNumber, adress, webPage, email));
                        break;
                    case "sort":
                        Console.WriteLine("If you want to sort by rating in ascending order enter \"sort_ascending\" \notherwise enter\"sort_descending\" command.");
                        break;
                    case "sort_ascending":
                        Cafe.ListOfCafes.Sort(delegate (Cafe x, Cafe y)
                        {
                            if (double.Parse(x.Rank) > double.Parse(y.Rank))
                            {
                                return 1;
                            }
                            else if (double.Parse(x.Rank) < double.Parse(y.Rank))
                            {
                                return -1;
                            }
                            else
                            {
                                return 0;
                            }
                        });
                        Console.WriteLine("Data is succefully sorted in ascending order by rank.");
                        break;
                    case "sort_descending":
                        Cafe.ListOfCafes.Sort(delegate (Cafe x, Cafe y)
                        {
                            if (double.Parse(x.Rank) > double.Parse(y.Rank))
                            {
                                return -1;
                            }
                            else if (double.Parse(x.Rank) < double.Parse(y.Rank))
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        });
                        Console.WriteLine("Data is succefully sorted in descending order by rank.");
                        break;
                    case "clear_console":
                        Console.Clear();
                        Console.WriteLine("Hello dear user !");
                        Console.WriteLine("Enter \"help\" for displaying commands.");
                        break;
                    case "help":
                        help();
                        break;
                    case "exit":
                        return;
                }
            }
        }
        public static void help()
        {
            Line2();
            Console.WriteLine("\"clear_console\" - Clears the console");
            Console.WriteLine("\"exit\" - Closes the program");
            Console.WriteLine("\"show\" - Shows all information about cafes(Database)");
            Console.WriteLine("\"import_data\" (or simply \"import\")- Imports already written data");
            Console.WriteLine("\"clear_data\" - Clears current database");
            Console.WriteLine("\"add_cafe\" or \"add\" - Adds cafe to current database");
            Console.WriteLine("\"sort\" - Helps to sort data in order you want");
            Line2();
        }
        public static void Line1()
        {
            Console.WriteLine("==========================================================================================");
        }
        public static void Line2()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=");
        }
        public static void Line3()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}