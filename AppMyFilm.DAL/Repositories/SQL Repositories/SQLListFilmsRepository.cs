using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AppMyFilm.DAL.Repositories.SQL_Repositories
{
    public class SQLListFilmsRepository : ISQLListFilmsRepository
    {
        protected IConnectionFactory _connectionFactory;
        private static readonly string _tableName = "ListFilms";

        public SQLListFilmsRepository(IConnectionFactory connectionFactory, IConfiguration config)
        {
            _connectionFactory = connectionFactory;
            var connectionString = config.GetConnectionString("DefaultConnection2");
            _connectionFactory.SetConnection(connectionString);
        }

        public async IAsyncEnumerable<SQLListFilms> Get(string sqlExpression)
        {
            using (SqlConnection connection = (SqlConnection)_connectionFactory.GetSqlAsyncConnection)
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        long Field1 = reader.GetInt32(0);
                        long Field2 = reader.GetInt32(1);

                        yield return new SQLListFilms(Field1, Field2);
                    }
                }
                reader.Close();
            }
            //return rez;
            yield break;
        }

        public IAsyncEnumerable<SQLListFilms> GetAll()//
        {
            return Get("SELECT * FROM " + _tableName);
        }

        public IAsyncEnumerable<SQLListFilms> GetByIdFilms(long Id)
        {
            return Get("SELECT * FROM " + _tableName + " WHERE IdFilms=" + Id);

        }

        public IAsyncEnumerable<SQLListFilms> GetByIdUsers(long Id)
        {
            return Get("SELECT * FROM " + _tableName + " WHERE IdUser=" + Id);
        }

        public async IAsyncEnumerable<SQLListFilmsStr> GetFilmsJoinUser() //create new entity
        {
            string sqlExpression = @"
            SELECT DISTINCT UserName, NameFilm FROM 
                (SELECT IdFilms as Id, NameFilm FROM ListFilms INNER JOIN Films ON ListFilms.IdFilms = Films.Id) as tab1
                INNER JOIN
                (SELECT IdFilms as Id, UserName FROM ListFilms INNER JOIN Users ON ListFilms.IdUser = Users.Id) as tab2
            ON tab1.Id = tab2.Id
		    ORDER BY UserName
            ";
            

            using (SqlConnection connection = (SqlConnection)_connectionFactory.GetSqlAsyncConnection)
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        string Field1 = reader.GetString(0);
                        string Field2 = reader.GetString(1);

                        yield return new SQLListFilmsStr(Field1, Field2);
                    }
                }
                reader.Close();
            }
            //return rez;
            yield break;

        }

        public long Add(SQLListFilms entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(SQLListFilms entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(SQLListFilms entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
