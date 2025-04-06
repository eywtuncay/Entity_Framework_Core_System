using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Models
{
    internal class KitapYazar
    {
        public int ID { get; set; }
        public int KitapId { get; set; }
        public int YazarId { get; set; }


        public Kitap? Kitap { get; set; }
        public Yazar? Yazar { get; set; }
    }
}
