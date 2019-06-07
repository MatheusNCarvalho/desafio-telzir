using System;

namespace ChallengeTelzir.Domain.Core.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            CreationDate = DateTime.Now;
        }
        public Guid Id { get; protected set; }
        public DateTime CreationDate { get; protected set; }
    }
}