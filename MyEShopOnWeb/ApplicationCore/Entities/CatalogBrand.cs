using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class CatalogBrand : BaseEntity, IAggregateRoot
    {
        public CatalogBrand(string brnad)
        {
            Brand = brnad;
        }
        public string Brand { get; private set; }
    }
}
