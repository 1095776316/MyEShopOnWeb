using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShared.Models
{
    public class CatalogTypeResponse
    {
        public List<CatalogType> CatalogTypes { get; set; } = new List<CatalogType>();
    }
}
