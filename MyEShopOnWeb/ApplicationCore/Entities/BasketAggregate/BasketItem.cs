﻿using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.BasketAggregate
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; private set; }

        public int Quantity { get; private set; }

        public int CatalogItemId { get; set; }

        public int BasketId { get; private set; }

        public BasketItem(int catalogItemId, int quantity, decimal unitPprice)
        {
            CatalogItemId = catalogItemId;
            UnitPrice = unitPprice;
            SetQuantity(quantity);
        }

        public void AddQuantity(int quantity)
        {
            Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue);
            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue);
            Quantity = quantity;
        }
    }
}
