using Microsoft.AspNetCore.Mvc;

namespace OnClick.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();

        public IActionResult Logout() => View();
    }
}
