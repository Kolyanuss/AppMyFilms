using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Interfaces;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using AppMyFilm.DAL.Entities.SQLEntities;
using System.Collections.Generic;
using Dapper;

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

        public IEnumerable<SQLFilms> GetPopularFilms()
        {
            string sqlExpression = @"
            SELECT [Id],[NameFilm],[ReleaseData],[Country],[DescriptionId] 
                FROM ListFilms RIGHT JOIN Films ON ListFilms.IdFilms = Films.Id  
            WHERE ListFilms.IdFilms IS NULL
            ";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<SQLFilms>(sqlExpression);
            }
        }

    }
}
