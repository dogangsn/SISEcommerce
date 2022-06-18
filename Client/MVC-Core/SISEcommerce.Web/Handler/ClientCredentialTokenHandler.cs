using SISEcommerce.Web.Exceptions;
using SISEcommerce.Web.Services.Interfaces;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Handler
{
    public class ClientCredentialTokenHandler:DelegatingHandler
    {

        private readonly IClientCredentialTokenService _clientCredentialTokenService;

        public ClientCredentialTokenHandler(IClientCredentialTokenService clientCredentialTokenService)
        {
            _clientCredentialTokenService = clientCredentialTokenService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", await _clientCredentialTokenService.GetToken());
            var response = await base.SendAsync(request, cancellationToken);    

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new UnAuthorizeExceptions();

            }
            return response;

        }
    }
}
