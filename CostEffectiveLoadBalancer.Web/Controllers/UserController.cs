namespace CostEffectiveLoadBalancer.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using CostEffectiveLoadBalancer.Web.Models;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public ActionResult<UserViewModel> Login(UserLoginInfoViewModel loginInfo)
        {
            return new UserViewModel
            {
                Id = -1,
                Name = "Perico el de los palotes",
                Login = "perico",
                Password = "teLoVaADecirTuPadre",
                Claims = new List<string> { "Capitán" }
            };
        }

        public ActionResult Logoff(int userId)
        {
            return new OkResult();
        }
    }
}