using AppMyFilm.DAL.Entities.SQLEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLListFilmsService
    {
        long AddFilm(SQLListFilms listFilm);

        void UpdateFilm(SQLListFilms listFilm);

        void DeleteFilm(SQLListFilms listFilm);

        SQLListFilms GetFilmById(long Id);

        IEnumerable<SQLListFilms> GetAllFilms();

        IEnumerable<SQLListFilms> GetFilmsJoinUser();
    }
}
