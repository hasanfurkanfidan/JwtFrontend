using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Concrete.AuthDtos
{
    public class AccessTokenDto
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
