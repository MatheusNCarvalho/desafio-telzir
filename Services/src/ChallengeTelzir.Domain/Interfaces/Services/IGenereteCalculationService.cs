using System;
using System.Threading.Tasks;
using ChallengeTelzir.Domain.DTO;

namespace ChallengeTelzir.Domain.Interfaces.Services
{
    public interface IGenereteCalculationService : IDisposable
    {
        Task Add(GenereteCalculationDto dto);
    }
}