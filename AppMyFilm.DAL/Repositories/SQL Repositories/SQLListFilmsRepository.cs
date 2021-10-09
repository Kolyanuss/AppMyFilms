using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public async IAsyncEnumerable<SQLListFilms> GetAll()//
        {
            string sqlExpression = "SELECT * FROM " + _tableName;
            var rez = new List<SQLListFilms>();
            using (SqlConnection connection = (SqlConnection)_connectionFactory.GetSqlAsyncConnection)
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));

                    while (await reader.ReadAsync())
                    {
                        long id = reader.GetInt64(0);
                        long id2 = reader.GetInt64(1);

                        Console.WriteLine("{0} \t{1}", id, id2);
                        rez.Add(new SQLListFilms(id, id2));

                        yield return rez[-1];
                    }
                }
                reader.Close();
            }
            //return rez;
            yield break;
        }

        public SQLListFilms Get(long Id)
        {
            throw new System.NotImplementedException();
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

        public IEnumerable<SQLListFilms> GetFilmsJoinUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
