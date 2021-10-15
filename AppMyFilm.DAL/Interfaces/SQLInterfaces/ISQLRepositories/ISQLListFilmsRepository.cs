using AppMyFilm.DAL.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLListFilmsRepository
    {
        IAsyncEnumerable<SQLListFilms> GetAll();

        IAsyncEnumerable<SQLListFilms> GetByIdFilms(long Id);

        IAsyncEnumerable<SQLListFilms> GetByIdUsers(long Id);

        Task<long> Add(SQLListFilms entity);

        void Update(SQLListFilms entity);

        void Delete(SQLListFilms entity);

        IAsyncEnumerable<SQLListFilmsStr> GetFilmsJoinUser();
    }
}
