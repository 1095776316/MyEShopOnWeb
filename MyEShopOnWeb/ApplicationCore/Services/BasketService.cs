using ApplicationCore.Entities.BasketAggregate;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class BasketService: IBasketService
    {
        private readonly IAsyncRepository<Basket> _basketRespository;
        private readonly IAppLogger<BasketService> _logger;

        public BasketService(IAsyncRepository<Basket> basketRespository, IAppLogger<BasketService> logger)
        {
            this._basketRespository = basketRespository;
            this._logger = logger;
        }

        public async Task AddItemToBasketAsync(int basketId, int catalogItemId, decimal price, int quanitiy = 1)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBasketAsync(int basketId)
        {
            throw new NotImplementedException();
        }

        public Task SetQuantities(int basketId, Dictionary<string, int> quantities)
        {
            throw new NotImplementedException();
        }

        public Task TransferBasketAsync(string anonyousId, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
