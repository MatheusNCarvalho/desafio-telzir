using MediatR;

namespace ChallengeTelzir.Domain.Core.Notifications
{
    public class DomainNotification : INotification
    {
        public DomainNotification(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}