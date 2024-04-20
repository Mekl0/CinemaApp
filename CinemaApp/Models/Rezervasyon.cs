using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int SeansId { get; set; } // Seans tablosu ile ilişkili foreign key
        public Seans Seans { get; set; } // Seans tablosu ile ilişkili navigation property       
        public DateTime Tarih { get; set; }
    }
}
