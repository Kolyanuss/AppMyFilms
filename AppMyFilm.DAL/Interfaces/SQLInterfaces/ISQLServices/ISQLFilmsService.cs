using AppMyFilm.DAL.Entities.SQLEntities;
using System.Collections.Generic;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLFilmsService
    {
        long AddFilm(SQLFilms film);

        void UpdateFilm(SQLFilms film);

        void DeleteFilm(SQLFilms film);

        SQLFilms GetFilmById(long Id);

        IEnumerable<SQLFilms> GetAllFilms();

        IEnumerable<SQLFilms> GetPopularFilms();
    }
}
