using System.ComponentModel;

namespace FazendaUrbanaAPI.Models.Enums
{
    public enum PrioridadeTarefa
    {
        [Description("Baixa")]
        Baixa = 1,
        [Description("Média")]
        Media = 2,
        [Description("Alta")]
        Alta = 3
    }
}
