﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Services.Common;

namespace Northwind.MongoDB
{
    [DataServiceKey("ProductID")]
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; private set; }

        public Products()
        {
            this.OrderDetails = new List<OrderDetails>();
        }
    }
}
