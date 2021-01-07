using System.Threading.Tasks;
using AspNetCore.Mediatr.Business;
using AspNetCore.Mediatr.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mediatr.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserService _userService;
        public UserController(IMediator mediator, UserService userService)
        {
            _mediator = mediator;
            _userService = userService;

        }

        [HttpPost]
        [Route("register")]
        public async Task<JsonResult> Register([FromBody] UserRegisterRequestModel request)
        {
            //MediatR kullanmadan direk service kullanarak kullanıcıyı kaydetme işlemi yapıyoruz
            //var result = await _userService.Add(request);

            //MediatR kullanarak yapıyoruz
            var result = await _mediator.Send(request);
            if (result != null)
                return Json(result);

            return Json(new { Error = "Kullanıcı kaydedilemedi" });
        }
    }
}
