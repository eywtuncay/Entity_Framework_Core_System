using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ef.Models
{
    internal class PersonelDetay
    {
        public int PersonelDetayID { get; set; }
        public string SicilNotu { get; set; }

        [ForeignKey("PersonelDetayID")]
        public Personel? personel { get; set; }



    }
}
