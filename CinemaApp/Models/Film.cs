using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Ad { get; set; }
        public string[] Seanslar { get; set; }

    }
}
