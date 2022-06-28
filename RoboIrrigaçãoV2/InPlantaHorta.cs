using System;

namespace entradaCampos{
    
    public class InPlantaHorta()
    {   
        public string TamanhoLargura {get; set;}
        public string TamanhoComprimento {get; set;}
        public string PosicaoInicial {get; set;}
        public OrientacoesEnum OrientacaoInicial {get; set;}
        public string QuantidadeCanteiros {get; set;}
        public string CoordenadaIrrigar {get; set;}

    }
    
    public List<string> ValidarObjetos(InPlantaHorta)
    {
        List<string> erros = new List<string>();
        foreach (string field in entradaCampos)
        {
        If (TamanhoLargura.IsNullOrWhiteSpace()
            || TamanhoComprimento.IsNullOrWhiteSpace()
            || PosicaoInicial.IsNullOrWhiteSpace()
            || QuantidadeCanteiros.IsNullOrWhiteSpace()
            || CoordenadaIrrigar.IsNullOrWhiteSpace()
            || OrientacaoInicial.IsNullOrWhiteSpace())}
    }

            public static bool PossuiAlgumaPropriedadeNulaOuVazia<T>(this T obj) where T : ViewModelBase
        {
            foreach (PropertyInfo propriedade in obj.GetType().GetProperties())
            {
                string value = Convert.ToString(propriedade.GetValue(obj));

                if (string.IsNullOrWhiteSpace(value))
                    return true;
            }
        }
}