using ApplicationCore.Entities.BasketAggregate;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class BasketWithItemSpecification : Specification<Basket>
    {
        public BasketWithItemSpecification(int basketId)
        {
            Query.Where(b => b.Id == basketId).Include(b => b.Items);
        }
        public BasketWithItemSpecification(string buyerId)
        {
            Query.Where(b => b.BuyerId == buyerId).Include(b => b.Items);
        }
    }
}
