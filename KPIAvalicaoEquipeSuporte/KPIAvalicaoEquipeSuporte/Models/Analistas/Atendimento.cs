using System;

namespace KPIAvalicaoEquipeSuporte.Models.Analist
{
    public class Atendimento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int NivelAtendimento { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public bool Reincidencia { get; set; }
        public int? IdAtendimentoOrigem { get; set; }

    }
}