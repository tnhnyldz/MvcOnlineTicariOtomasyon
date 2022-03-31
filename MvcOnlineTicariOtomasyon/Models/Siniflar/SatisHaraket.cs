using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatisHaraket
    {
        [Key]
        public int SatisID { get; set; }
        //Urun
        //Cari
        //Personel
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Cariler> Carilers { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}