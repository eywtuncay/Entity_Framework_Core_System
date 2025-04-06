using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Models
{
    internal class Barkod
    {
        public int BarkodId { get; set; }

        public string BarkodNo { get; set; }
        public string Karekod { get; set; }


        //
        public Kitap? Kitap { get; set; }
    }
}
