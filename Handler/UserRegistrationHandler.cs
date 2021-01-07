using System;
using System.Threading;
using System.Threading.Tasks;
using AspNetCore.Mediatr.Business;
using AspNetCore.Mediatr.Notification;
using AspNetCore.Mediatr.Request;
using AspNetCore.Mediatr.Response;
using MediatR;

namespace AspNetCore.Mediatr.Handler
{
    public class UserRegistrationHandler : IRequestHandler<UserRegisterRequestModel, UserResponseModel>
    {
        private readonly UserService _userService;
        private readonly IMediator _mediator;
        public UserRegistrationHandler(UserService userService, IMediator mediator)
        {
            _userService = userService;
            _mediator = mediator;
        }

        public async Task<UserResponseModel> Handle(UserRegisterRequestModel request, CancellationToken cancellationToken)
        {
            var response = await _userService.Add(request);
            if (response != null)
                await _mediator.Publish(new UserRegisterNotification { Email = response.Email });

            return response;
        }
    }
}
