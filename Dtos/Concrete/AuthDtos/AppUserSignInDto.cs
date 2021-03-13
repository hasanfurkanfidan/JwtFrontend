using Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos.Concrete.AuthDtos
{
    public class AppUserSignInDto:IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool DontForget { get; set; }
    }
}
