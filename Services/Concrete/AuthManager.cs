using Dtos.Concrete.AuthDtos;
using Microsoft.AspNetCore.Http;
using MsgPack.Serialization;
using Services.Abstract;
using Services.Results;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly HttpClient _httpClient;
        public AuthManager()
        {
            _httpClient = new HttpClient();
        }
        public Task<ActiveUserDto> GetActiveUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AccessTokenDto> SignInAsync(AppUserSignInDto model)
        {
            var result = new AccessTokenDto();
            var data = JsonSerializer.Serialize(model);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:44327/api/auth/signin", content);
            if (response.IsSuccessStatusCode)
            {
                result = JsonSerializer.Deserialize<AccessTokenDto>(await response.Content.ReadAsStringAsync());

                return result;
            }
            return result;
        }
    }
}
