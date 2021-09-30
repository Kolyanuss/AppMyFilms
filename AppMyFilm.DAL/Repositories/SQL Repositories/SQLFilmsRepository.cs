using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Interfaces;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using AppMyFilm.DAL.Entities.SQLEntities;

namespace AppMyFilm.DAL.Repositories.SQL_Repositories
{
    public class SQLFilmsRepository : GenericRepository<SQLFilms, long>, ISQLFilmsRepository
    {
        private static readonly string _tableName = "Films";
        private static readonly bool _isSoftDelete = true;
        public SQLFilmsRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, _tableName, _isSoftDelete)
        {
            var connectionString = config.GetConnectionString("DefaultConnection2");
            connectionFactory.SetConnection(connectionString);
        }
    }
}
