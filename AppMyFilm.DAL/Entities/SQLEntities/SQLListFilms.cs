using AppMyFilm.DAL.Interfaces.EntityInterfaces;

namespace AppMyFilm.DAL.Entities.SQLEntities
{
    public class SQLListFilms : IClearEntity
    {
        public long IdFilms { get; set; }
        public long IdUser { get; set; }

        public SQLListFilms(long idFilms, long idUser)
        {
            IdFilms = idFilms;
            IdUser = idUser;
        }
    }
}
