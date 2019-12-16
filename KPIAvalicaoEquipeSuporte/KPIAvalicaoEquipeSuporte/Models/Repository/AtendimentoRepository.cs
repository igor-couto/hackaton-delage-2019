using Dapper;
using KPIAvalicaoEquipeSuporte.Models.Analist;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace KPIAvalicaoEquipeSuporte.Models.Repository
{
    public class AtendimentoRepository : BaseRepository
    {
        public async Task<IEnumerable<Atendimento>> GetAtendimentosByAnalista(int IdAnalista)
        {
            IEnumerable<Atendimento> atendimentos = null;
            var parameters = new DynamicParameters();
            parameters.Add("IdAnalista", IdAnalista, DbType.Int32);

            var sql = @"";

            using (_conn)
            {
                atendimentos = await _conn.QueryAsync<Atendimento>(sql,parameters);
            }

            return atendimentos;
        }
    }
}
