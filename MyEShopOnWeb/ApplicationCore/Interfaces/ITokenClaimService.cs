using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ITokenClaimService
    {
        Task<string> GetTokenAsync(string userName);
    }
}
