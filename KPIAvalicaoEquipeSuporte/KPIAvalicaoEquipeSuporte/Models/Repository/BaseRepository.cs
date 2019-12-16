

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace KPIAvalicaoEquipeSuporte.Models.Repository
{
    public abstract class BaseRepository
    {
        private readonly IConfiguration _config;
        protected SqlConnection _conn { get { return new SqlConnection(_config.GetConnectionString("SqlConnection")); } }
    }
}
