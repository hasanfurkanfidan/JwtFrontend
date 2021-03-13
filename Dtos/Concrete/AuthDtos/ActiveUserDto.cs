using Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos.Concrete.AuthDtos
{
    public class ActiveUserDto:IDto
    {
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
