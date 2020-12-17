using ApplicationCore.Entities.OrderAggregate;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class CustomerOrderWithItemsSpecification : Specification<Order>
    {
        public CustomerOrderWithItemsSpecification(string buyerId)
        {
            Query.Where(i => i.BuyerId == buyerId)
                    .Include(i => i.OrderItems)
                    .ThenInclude(i => i.ItemOrdered);
        }
    }
}
