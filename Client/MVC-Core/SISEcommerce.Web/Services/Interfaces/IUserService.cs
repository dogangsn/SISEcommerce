﻿using SISEcommerce.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();


    }
}
