using System;

namespace KPIAvalicaoEquipeSuporte.Models.ViewModel
{
    public class FiltroViewModel
    {
        public string Analista { get; set; }
        public string TipoDeGrafico { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
    }
}