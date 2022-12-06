using System;
using System.Collections.Generic;

namespace webAPI.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public string StoreId { get; set; } = null!;

    public string OrderNum { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public short Quantity { get; set; }

    public string PayTerms { get; set; } = null!;

    public int BookId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
