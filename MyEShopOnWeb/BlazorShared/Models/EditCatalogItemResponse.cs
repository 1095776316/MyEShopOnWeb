using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShared.Models
{
    public class EditCatalogItemResponse
    {
        public CatalogItem CatalogItem { get; set; } = new CatalogItem();
    }
}
