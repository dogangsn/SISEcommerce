using System;
using System.Collections.Generic;
using System.Text;

namespace SISECommerce.Shared.Services
{
    public interface ISharedIdentityService
    {
        public string GetUserId { get; }
    }
}
