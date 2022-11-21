using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Varuautomat1
{
    // konstruktor för pengar
    public class Pengar
    {
        public int EnDrakmer { get; }
        public int TvåDrakmer { get; }
        public int TreDrakmer { get; }
        public int FyrDrakmer { get; }
        public int FemDrakmer { get; }
        public int TioDrakmer { get; }
        public int FemtonDrakmer { get; }
        public int TjugoDrakmer { get; }
        public int TjugofemDrakmer { get; }
        public int TrettioDrakmer { get; }
        public int FyrtioDrakmer { get; }

        //Räknar ut antalet drakmer som du ska få tillbaka
        public Pengar(decimal price)
        {
            EnDrakmer = (int)(price / 1);
            price %= 1;
            TvåDrakmer = (int)(price / 2);
            price %= 2;
            TreDrakmer = (int)(price / 3);
            price %= 3;
            FyrDrakmer = (int)(price / 4);
            price %= 4;
            FemDrakmer = (int)(price / 5);
            price %= 5;
            TioDrakmer = (int)(price / 10);
            price %= 10;
            FemtonDrakmer = (int)(price / 15);
            price %= 15;
            TjugoDrakmer = (int)(price / 20);
            price %= 20;
            TjugofemDrakmer = (int)(price / 25);
            price %= 25;
            TrettioDrakmer = (int)(price / 30);
            price %= 30;
            FyrtioDrakmer = (int)(price / 40);
            price %= 40;


        }












       
        
        
    }
}
