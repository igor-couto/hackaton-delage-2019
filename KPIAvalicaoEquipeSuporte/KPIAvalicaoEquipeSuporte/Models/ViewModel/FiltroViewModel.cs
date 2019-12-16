using System;

namespace KPIAvalicaoEquipeSuporte.Models.ViewModel
{
    public class FiltroViewModel
    {
        public string Analista { get; set; }
        public string Situacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}