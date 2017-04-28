using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class CafeList
    {
        public static List<Cafe> List = new List<Cafe>();
        static Cafe Jazzve = new Cafe("Jazve", "+37410378453", "Tumanyan", 5.5);
        static Cafe Verona = new Cafe("Verona", "+37410401040", "Isahakyan", 4.5);
        static Cafe ElGarden = new Cafe("ElGarden", "+374101010", "Ropevay Of Cicernakaberd", 6);
        static CafeList()
        {
            List.Add(Jazzve);
            List.Add(Verona);
            List.Add(ElGarden);
        }

    }
}
