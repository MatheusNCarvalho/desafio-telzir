using System.ComponentModel;

namespace ChallengeTelzir.Domain.Entites
{
    public enum EPlanSpeakMore
    {
        [Description("Fale Mais 30")]
        SM30 = 30,
        [Description("Fale Mais 60")]
        SM60 = 60,
        [Description("Fale Mais 120")]
        SM120 = 120
    }
}