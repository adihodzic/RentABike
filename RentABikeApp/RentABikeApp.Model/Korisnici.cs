using System;
using System.Collections.Generic;
using System.Text;

namespace RentABikeApp.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string IzjavaZastitaPodataka { get; set; }

    }
}
