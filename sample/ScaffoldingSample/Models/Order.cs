﻿using System;
using System.Collections.Generic; // Comment

namespace ScaffoldingSample.Models
{ // Comment
    public partial class Order : EntityBase // My Handlebars Helper
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
