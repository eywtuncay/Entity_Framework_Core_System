using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Models
{
    internal class Yazar
    {
        public int YazarId { get; set; }

        //Validation
        //AOP --> Attiribute Oriented Programming
        [StringLength(15), Column(TypeName = "varchar")]
        public string Ad { get; set; }

        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string Soyad { get; set; }

        public ICollection<KitapYazar>? Kitaplar { get; set; }
    }
}
