using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public CatalogItemOrdered ItemOrdered { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Units { get; private set; }
        private OrderItem()
        {

        }
        public OrderItem(CatalogItemOrdered catalogItemOrdered, decimal unitPrice, int units)
        {
            ItemOrdered = catalogItemOrdered;
            UnitPrice = unitPrice;
            Units = units;
        }
    }
}
