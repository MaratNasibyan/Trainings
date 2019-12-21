using System;
using System.Collections.Generic;

namespace Mobile.DBMap.Northwind_Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
