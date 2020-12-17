using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShared.Models
{
    public class PagedCatalogItemResponse
    {
        public List<CatalogItem> CatalogItems { get; set; } = new List<CatalogItem>();
        public int PageCount { get; set; } = 0;
    }
}
