using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Models
{
    internal class Kitap
    {
        public int KitapId { get; set; }
        public string Ad { get; set; }
        public short SayfaSayisi { get; set; }
        public DateTime BasimTarihi { get; set; }
        public int BaskiSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public string ISBN { get; set; }
        public string Ozet { get; set; }
        public string KapakResmi { get; set; }

        public int KategoriId { get; set; }

        public Kategori? Kategori { get; set; }
        public ICollection<KitapYazar>? Yazarlar { get; set; }


        public int YayinEviId { get; set; }
        public Yayinevi? YayinEvi { get; set; }


        public Barkod? Barkod { get; set; }
    }
}
