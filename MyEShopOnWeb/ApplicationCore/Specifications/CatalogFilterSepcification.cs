using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class CatalogFilterSepcification : Specification<CatalogItem>
    {
        public CatalogFilterSepcification(int? brandId, int? typeId)
        {
            Query.Where(i => (!brandId.HasValue || i.CatalogBrandId == brandId)
            && (!typeId.HasValue || i.CatalogTypeId == typeId));
        }
    }
}
