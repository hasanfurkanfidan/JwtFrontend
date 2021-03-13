using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        public async Task< IActionResult> SignIn()
        {
            return View();
        }
    }
}
