﻿using Microsoft.AspNetCore.Mvc;
using SISECommerce.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISECommerce.Shared.ControllerBases
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
