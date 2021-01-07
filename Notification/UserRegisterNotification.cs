using MediatR;

namespace AspNetCore.Mediatr.Notification
{
    public class UserRegisterNotification : INotification
    {
        public string Email { get; set; }
    }
}
