using System;
using System.Collections.Generic;

namespace _06_CodeFirst_DatabaseFirst.Models;

public partial class IlkUcAyKazanciGorunumu
{
    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public double? ToplamKazanc { get; set; }
}
