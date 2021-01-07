using System;
using AspNetCore.Mediatr.Response;
using MediatR;

namespace AspNetCore.Mediatr.Request
{
    public class UserRegisterRequestModel : IRequest<UserResponseModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
