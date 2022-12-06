using System;
using System.Collections.Generic;

namespace webAPI.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int PubId { get; set; }

    public decimal? Price { get; set; }

    public decimal? Advance { get; set; }

    public int? Royalty { get; set; }

    public int? YtdSales { get; set; }

    public string? Notes { get; set; }

    public DateTime PublishedDate { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; } = new List<BookAuthor>();

    public virtual Publisher Pub { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();
}
