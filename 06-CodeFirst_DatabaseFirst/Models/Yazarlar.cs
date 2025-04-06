using System;
using System.Collections.Generic;

namespace _06_CodeFirst_DatabaseFirst.Models;

public partial class Yazarlar
{
    public int YazarId { get; set; }

    public string YazarAd { get; set; } = null!;

    public string YazarSoyad { get; set; } = null!;

    public string? DogumYeri { get; set; }

    public virtual ICollection<Kitaplar> Kitaplars { get; set; } = new List<Kitaplar>();
}
