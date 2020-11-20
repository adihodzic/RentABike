using System;
using System.Collections.Generic;
using System.Text;

namespace RentABikeApp.Model
{
    public class DezurnaVozila
    {
        public int VoziloId { get; set; }
        public string NazivVozila { get; set; }
        public DateTime GodinaProizvodnje { get; set; }
        public string BrojMotora { get; set; }
        public double PredjeniKilometri { get; set; }
        public int BrojSjedista { get; set; }
        public string Boja { get; set; }
        public int BrojVrata { get; set; }
        public string RegOznaka { get; set; }
        public bool Ispravnost { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public int TipVozilaId { get; set; }
        public TipoviVozila TipoviVozila { get; set; }
        public int MarkaVozilaId { get; set; }
        public MarkeVozila MarkeVozila { get; set; }
       
    }
}
