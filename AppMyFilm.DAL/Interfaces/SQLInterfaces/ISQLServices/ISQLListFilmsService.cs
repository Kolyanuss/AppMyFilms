using AppMyFilm.DAL.Entities.SQLEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLListFilmsService
    {
        long AddListFilm(SQLListFilms listFilm);

        void UpdateListFilm(SQLListFilms listFilm);

        void DeleteListFilm(SQLListFilms listFilm);

        IAsyncEnumerable<SQLListFilms> GetListFilmByIdFilm(long Id);

        IAsyncEnumerable<SQLListFilms> GetListFilmByIdUser(long Id);

        IAsyncEnumerable<SQLListFilms> GetAllListFilms();

        IAsyncEnumerable<SQLListFilmsStr> GetListFilmsJoinUser();
    }
}
