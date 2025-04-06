using System;
using System.Collections.Generic;

namespace _06_CodeFirst_DatabaseFirst.Models;

public partial class VwToplamTutar
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public float Discount { get; set; }

    public float? ToplamTutar { get; set; }
}
