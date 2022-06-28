using System;

namespace OrientacoesPossiveis
{
    public enum OrientacoesEnum
    {
        [Description("Seu robô está orientado a norte.")]
        ORIENTADO_A_NORTE = 1,
        [Description("Seu robô está orientado a oeste.")]
        ORIENTADO_A_OESTE = 2,
        [Description("Seu robô está orientado a sul.")]
        ORIENTADO_A_SUL = 3,
        [Description("Seu robô está orientado a leste.")]
        ORIENTADO_A_LESTE = 4
    };
};