using System;
using System.Collections.Generic;

namespace Core_Web_App_MVC.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
