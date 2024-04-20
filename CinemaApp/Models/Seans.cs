﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Seans
    {
        public int SeansId { get; set; }
        public string Tarih { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
        public int  Koltukkapasite { get; set; }
    }
}
