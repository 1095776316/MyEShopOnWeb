using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Specifications
{
   public class CatalogItemSpecification:Specification<CatalogItem>
    {
        public CatalogItemSpecification(params int[] ids)
        {
            Query.Where(c=>ids.Contains(c.Id));
        }
    }
}
