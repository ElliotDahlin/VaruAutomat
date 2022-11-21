using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varuautomat1
{
    //Abstract klass
    internal class Produkter
    {
        public string Namn;

        public int Pris;

        public string VaruBeskrivning;

        public Produkter(string Namn, int Pris, string VaruBeskrivning)
        {
            this.Namn = Namn;
            this.Pris = Pris;
            this.VaruBeskrivning = VaruBeskrivning;
        }
    }
}
