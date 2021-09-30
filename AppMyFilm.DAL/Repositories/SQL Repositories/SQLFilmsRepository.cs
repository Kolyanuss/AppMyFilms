using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Interfaces;

namespace AppMyFilm.DAL.Repositories.SQL_Repositories
{
    public class SQLFilmsRepository : GenericRepository<SQLEmployee, long>, ISQLEmployeeRepository
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
