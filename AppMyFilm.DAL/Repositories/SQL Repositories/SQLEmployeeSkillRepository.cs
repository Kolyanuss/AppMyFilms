using Dapper;
using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System.Collections.Generic;
using System.Data;

namespace SkillManagement.DataAccess.Repositories.SQL_Repositories
{
    public class SQLEmployeeSkillRepository : GenericRepository<SQLEmployees_Skill, long>, ISQLEmployeeSkillRepository
    {
        private static readonly string _tableName = "Employees_Skills";
        public SQLEmployeeSkillRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, _tableName, false)
        {
            var connectionString = config.GetConnectionString("DefaultConnection2");
            connectionFactory.SetConnection(connectionString);
        }

        public IEnumerable<SQLEmployees_Skill> GetAllEmployeeSkillsByEmployeeId(long employeeId)
        {
            var query = "SP_GetAllEmployeeSkillsByEmployeeId";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<SQLEmployees_Skill>(query,
                    new { P_Id = employeeId },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
