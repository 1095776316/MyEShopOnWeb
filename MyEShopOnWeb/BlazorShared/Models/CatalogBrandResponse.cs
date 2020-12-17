using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShared.Models
{
    public class CatalogBrandResponse
    {
        public List<CatalogBrand> CatalogBrands { get; set; } = new List<CatalogBrand>();
    }
}
