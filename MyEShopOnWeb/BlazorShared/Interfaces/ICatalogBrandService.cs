using BlazorShared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Interfaces
{
    public interface ICatalogBrandService
    {
        Task<List<CatalogBrand>> List();

        Task<CatalogBrand> GetById(int id);
    }
}
