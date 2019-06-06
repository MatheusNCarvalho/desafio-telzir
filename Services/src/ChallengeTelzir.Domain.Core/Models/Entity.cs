using System;

namespace ChallengeTelzir.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}