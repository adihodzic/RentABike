using System;
using System.Collections.Generic;
using System.Text;

namespace RentABikeApp.Model
{
    public class StatusiBicikla
    {
        public int StatusBiciklaId { get; set; }
        public bool Ispravnost { get; set; }
        public bool Rezervisan { get; set; }
    }
}
