using System;
using System.Collections.Generic;
using System.Text;

namespace RentABikeApp.Model
{
    public class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public double CijenaUsluge { get; set; }
        public DateTime DatumPreuzimanja { get; set; }
        public DateTime DatumVracanja { get; set; }
        public Bicikli Bicikli { get; set; }
        public int BicikloId { get; set; }
        public int KlijentId { get; set; }
        public Klijenti Klijenti { get; set; } 
        public int TuristRutaId { get; set; }
        public TuristRute TuristRute { get; set; }


    }
}
