using ChallengeTelzir.Domain.Core.Notifications;
using MediatR;

namespace ChallengeTelzir.Domain.Handler
{
    public abstract class CommandHandlerBase
    {
        private readonly IMediator _mediator;
        private readonly DomainNotificationHandler _notifications;

        protected CommandHandlerBase(IMediator mediator, INotificationHandler<DomainNotification> notification)
        {
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)notification;
        }

        protected bool HasNotifications() => _notifications.HasNotifications();

        protected void NotificationDomainError(string message)
        {
            _mediator.Publish(new DomainNotification("", message));
        }
    }
}