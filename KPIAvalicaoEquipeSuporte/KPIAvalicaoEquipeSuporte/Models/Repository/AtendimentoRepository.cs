using Dapper;
using KPIAvalicaoEquipeSuporte.Models.Atendimentos;
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

            var sql = @"SELECT  
                                
                            FROM funcionario f (NOLOCK)
                                INNER JOIN nivel_funcionario_setor nfs (NOLOCK) on 
                                INNER JOIN atendimento a (NOLOCK) on 
                                INNER JOIN def_nivel dn (NOLOCK) on 
                                INNER JOIN def_setor ds (NOLOCK) on
                            WHERE a.idAtendimento = @IdAnalista";

            using (_conn)
            {
                atendimentos = await _conn.QueryAsync<Atendimento>(sql,parameters);
            }

            return atendimentos;
        }
    }
}
