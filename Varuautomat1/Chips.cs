using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varuautomat1
{
    //subklass
    internal class Chips: Produkter, Varuautomatinterface
    {
        public static List<Chips> chips = new();
        public Chips(string Namn, int Pris, string VaruBeskrivning) : base(Namn, Pris, VaruBeskrivning)
        {
            this.Namn = Namn;
            this.Pris = Pris;   
            this.VaruBeskrivning = VaruBeskrivning;
        }

        public void Buy()
        {
            Console.WriteLine($"Varsågod du har köpt en: {Namn} ");
        }

        public void Using()
        {
            Console.WriteLine($"Du äter just nu dom goda: {Namn}");
        }

        public void Info()
        {
            Console.WriteLine($"påsen är tom så du slänger: {Namn}");
        }
    }
}
