using ChallengeTelzir.Domain.Core.Notifications;
using ChallengeTelzir.Domain.Interfaces.Repository;
using MediatR;

namespace ChallengeTelzir.Domain.Handler
{
    public abstract class CommandHandlerBase
    {
        private readonly IMediator _mediator;
        private readonly DomainNotificationHandler _notifications;
        private readonly IUnitOfWork _unitOfWork;

        protected CommandHandlerBase(IMediator mediator, INotificationHandler<DomainNotification> notification, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _notifications = (DomainNotificationHandler)notification;
        }

        protected bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            if (_unitOfWork.Commit()) return true;

            _mediator.Publish(new DomainNotification("Commit", "Ocorreu um erro ao salvar dados no banco"));
            return false;
        }

        protected bool HasNotifications() => _notifications.HasNotifications();

        protected void NotificationDomainError(string message)
        {
            _mediator.Publish(new DomainNotification("", message));
        }
    }
}