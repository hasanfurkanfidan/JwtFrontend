using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Results
{
    public class SignInResult
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
