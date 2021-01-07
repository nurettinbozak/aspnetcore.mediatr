using System;
using System.Threading;
using System.Threading.Tasks;
using AspNetCore.Mediatr.Notification;
using MediatR;

namespace AspNetCore.Mediatr.EventHandler
{
    public class UserEventHandler : INotificationHandler<UserRegisterNotification>
    {
        public Task Handle(UserRegisterNotification notification, CancellationToken cancellationToken)
        {
            //Burada e-mail atma işlemini yapabiliriz.

            return Task.Run(() =>
            {
                Console.WriteLine($"Email: '{notification.Email}'");
            });
        }
    }
}
