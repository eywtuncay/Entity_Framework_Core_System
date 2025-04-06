using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Models
{
    internal class Kategori
    {

        public int KategoriId { get; set; }
        
        public string Ad { get; set; }
        //max lenght 25, tipi varchar olsun

        public ICollection<Kitap>? Kitaplar { get; set; }

    }
}
