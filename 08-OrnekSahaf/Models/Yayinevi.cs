using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Models
{
    internal class Yayinevi
    {
        public int YayıneviId { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
