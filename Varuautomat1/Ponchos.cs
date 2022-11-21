using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varuautomat1
{
    //subklass
    internal class Ponchos: Produkter, Varuautomatinterface
    {
        public static List<Ponchos> ponchos = new();
        public Ponchos(string Namn, int Pris, string VaruBeskrivning) : base(Namn, Pris, VaruBeskrivning)
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
            Console.WriteLine($"Du sätter på dig en: {Namn}");
        }

        public void Info()
        {
            Console.WriteLine($"Det regnar inte längre så du stoppar undan din: {Namn}");
        }
    }
}
