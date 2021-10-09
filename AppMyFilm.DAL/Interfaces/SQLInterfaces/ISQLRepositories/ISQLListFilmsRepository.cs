using AppMyFilm.DAL.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using System.Collections.Generic;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLListFilmsRepository
    {
        IAsyncEnumerable<SQLListFilms> GetAll();

        SQLListFilms Get(long Id);

        long Add(SQLListFilms entity);

        void Update(SQLListFilms entity);

        void Delete(SQLListFilms entity);

        IEnumerable<SQLListFilms> GetFilmsJoinUser();
    }
}
