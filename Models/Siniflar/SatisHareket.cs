﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Toplam { get; set; }

        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Personel> Personels{ get; set; }
        public ICollection<Cariler> Carilers{ get; set; }
    }
}