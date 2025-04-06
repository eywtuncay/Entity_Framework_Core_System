using System;
using System.Collections.Generic;

namespace _06_CodeFirst_DatabaseFirst.Models;

public partial class Kitaplar
{
    public int KitapId { get; set; }

    public string KitapAdi { get; set; } = null!;

    public int? SayfaSayisi { get; set; }

    public int? YazarId { get; set; }

    public virtual Yazarlar? Yazar { get; set; }
}
