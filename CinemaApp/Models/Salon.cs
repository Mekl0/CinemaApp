using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Salon
    {
        public int SalonId { get; set; }
        public string Ad { get; set; }
        public int KoltukKapasitesi { get; set; }
        public List<Seans> Seanslar { get; set; }
    }
}
