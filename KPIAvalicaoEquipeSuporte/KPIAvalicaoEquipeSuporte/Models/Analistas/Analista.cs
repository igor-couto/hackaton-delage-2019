using System.Collections.Generic;

namespace KPIAvalicaoEquipeSuporte.Models.Analist
{
    public class Analista
    {
        public int Id { get; set; }
        public int NivelAnalista { get; set; }
        public string NomeCompleto { get; set; }
        public decimal Salario { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }

    }
}
