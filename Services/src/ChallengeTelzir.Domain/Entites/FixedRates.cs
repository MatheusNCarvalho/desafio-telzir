using System;
using ChallengeTelzir.Domain.Core.Models;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Domain.Entites
{
    public class FixedRates : Entity
    {
        public FixedRates(Guid id, EDdds originId, EDdds distinguishedId, decimal amount)
        {
            Id = id;
            OriginId = originId;
            DistinguishedId = distinguishedId;
            Amount = amount;
        }

        public EDdds OriginId { get; private set; }
        public EDdds DistinguishedId { get; private set; }
        public decimal Amount { get; private set; }
    }
}