using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ef.Models
{
    internal class Bolum
    {

        public int BolumID { get; set; }
        public string BolumAdi { get; set; }


        //public int PersonelID { get; set; }

        //public Personel? Personel { get; set; }


        //Navigation Property
        //public ICollection<Personel> Personeller { get; set; }

        //N-N
        //public ICollection<PersonelBolum> Personeller { get; set; }

    }
}
