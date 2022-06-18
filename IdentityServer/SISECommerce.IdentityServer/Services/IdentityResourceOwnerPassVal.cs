using IdentityModel;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Identity;
using SISECommerce.IdentityServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISECommerce.IdentityServer.Services
{
    public class IdentityResourceOwnerPassVal : IResourceOwnerPasswordValidator
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityResourceOwnerPassVal(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var exisUser = await _userManager.FindByEmailAsync(context.UserName);

            if (exisUser == null)
            {
                var errors = new Dictionary<string, object>();
                errors.Add("errors", new List<string> { "Email veya parola yanlış" });

                context.Result.CustomResponse = errors;
                return;
            }
            var passwordCheck = await _userManager.CheckPasswordAsync(exisUser, context.Password);
            if (passwordCheck == false)
            {
                var errors = new Dictionary<string, object>();
                errors.Add("errors", new List<string> { "Email veya parola yanlış" });

                context.Result.CustomResponse = errors;
                return;
            }

            context.Result = new GrantValidationResult(exisUser.Id.ToString(), OidcConstants.AuthenticationMethods.Password);


        }
    }
}
