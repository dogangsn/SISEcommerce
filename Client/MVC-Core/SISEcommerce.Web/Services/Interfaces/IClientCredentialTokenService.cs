using System;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Services.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();

    }
}
