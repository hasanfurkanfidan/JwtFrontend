using Dtos.Concrete.AuthDtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IAuthService
    {
        Task<AccessTokenDto> SignInAsync(AppUserSignInDto model);
        Task<ActiveUserDto> GetActiveUserAsync();

    }
}
