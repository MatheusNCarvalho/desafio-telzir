using System.Linq;
using ChallengeTelzir.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeTelzir.Services.API.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly IMediator _mediator;
        private readonly DomainNotificationHandler _notifications;

        protected BaseController(IMediator mediator, INotificationHandler<DomainNotification> notifications)
        {
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)notifications;
        }


        protected new IActionResult Response(object result = null, int statusCode = 200)
        {
            if (OperationValid())
            {
                var data = result;
                return StatusCode(statusCode, new { success = true, data });
            }

            return BadRequest(new { success = false, data = _notifications.GetNotifications().Select(n => n.Value) });
        }

        protected bool OperationValid() => !_notifications.HasNotifications();

        protected void NotificaitonErrorModelStateInvalid()
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            foreach (var error in errors)
            {
                var erroMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                NotifyError("ModelState", erroMsg);
            }
        }

        protected void NotifyError(string code, string mensagem)
        {
            _mediator.Publish(new DomainNotification(code, mensagem));
        }
    }
}