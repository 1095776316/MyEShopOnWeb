using BlazorShared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Interfaces
{
    public interface ICatalogTypeService
    {
        Task<List<CatalogType>> List();

        Task<CatalogType> GetById(int id);
    }
}
