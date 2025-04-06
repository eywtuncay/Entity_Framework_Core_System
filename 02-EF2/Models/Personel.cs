using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ef.Models
{
    internal class Personel
    {

        //PrimaryKey İçin kullanılabilecekler.
        //ID
        //PersonelID
        //[KEY]

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }


        //public int BolumID { get; set; }

        //public Bolum? Bolum { get; set; }


        public PersonelDetay personelDetay { get; set; }


        //Navigation Property


        //public ICollection<Bolum> Bolumler { get; set; }


        //N-N
        //public ICollection<PersonelBolum> Bolumler { get; set; }
    }
}
