﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorShared.Models
{
    public class CreateCatalogItemRequest
    {
        public int CatalogTypeId { get; set; }

        public int CatalogBrandId { get; set; }

        [Required(ErrorMessage = "The Name field is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Description field is required")]
        public string Description { get; set; } = string.Empty;

        [RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = "The field Price must be a positive number with maximun two deciaml.")]
        [Range(0.01, 1000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string PictureUir { get; set; } = string.Empty;

        public string PictureBase64 { get; set; } = string.Empty;

        public string PictureName { get; set; } = string.Empty;
    }
}
