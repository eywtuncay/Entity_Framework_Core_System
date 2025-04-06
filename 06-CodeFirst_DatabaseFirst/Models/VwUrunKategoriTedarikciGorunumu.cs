using System;
using System.Collections.Generic;

namespace _06_CodeFirst_DatabaseFirst.Models;

public partial class VwUrunKategoriTedarikciGorunumu
{
    public string UrunAdi { get; set; } = null!;

    public string KategoriAdi { get; set; } = null!;

    public string TedarikciAdi { get; set; } = null!;
}
