using System;
using System.Collections.Generic;
using System.Text;

namespace RentABikeApp.Model
{
    public class Bicikli
    {
        public int BicikloId { get; set; }
        public string Boja { get; set; }
        public bool Brzinomjer { get; set; }
        public DateTime GodinaProizvodnje { get; set; }
        public string NazivBicikla { get; set; }
        public string PhotoPath { get; set; }
        public double CijenaBiciklaPoDanu { get; set; }
        public TipoviBicikla TipoviBicikla { get; set; }
        public int TipBiciklaId { get; set; }




    }
}
