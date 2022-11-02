using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipDemo
{
    [Table("Products")] 
    public class Product
    {
        [Key]
        public int UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public int UrunSayisi { get; set; }

    }
}
