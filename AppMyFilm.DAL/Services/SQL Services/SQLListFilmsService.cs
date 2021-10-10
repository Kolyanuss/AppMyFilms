using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using SkillManagement.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppMyFilm.DAL.Services.SQL_Services
{
    public class SQLListFilmsService : ISQLListFilmsService
    {
        ISQLUnitOfWork _SqlsqlUnitOfWork;

        public SQLListFilmsService(ISQLUnitOfWork sqlSqlUnitOfWork)
        {
            _SqlsqlUnitOfWork = sqlSqlUnitOfWork;
        }

        public long AddListFilm(SQLListFilms listFilm)
        {
            return _SqlsqlUnitOfWork.SQLListFilmsRepository.Add(listFilm);
        }

        public void DeleteListFilm(SQLListFilms listFilm)
        {
            _SqlsqlUnitOfWork.SQLListFilmsRepository.Delete(listFilm);
        }

        public IAsyncEnumerable<SQLListFilms> GetAllListFilms()
        {
            return _SqlsqlUnitOfWork.SQLListFilmsRepository.GetAll();
        }

        public IAsyncEnumerable<SQLListFilms> GetListFilmByIdFilm(long Id)
        {
            return _SqlsqlUnitOfWork.SQLListFilmsRepository.GetByIdFilms(Id);
        }

        public IAsyncEnumerable<SQLListFilms> GetListFilmByIdUser(long Id)
        {
            return _SqlsqlUnitOfWork.SQLListFilmsRepository.GetByIdUsers(Id);
        }

        public IAsyncEnumerable<SQLListFilmsStr> GetListFilmsJoinUser()
        {
            return _SqlsqlUnitOfWork.SQLListFilmsRepository.GetFilmsJoinUser();
        }

        public void UpdateListFilm(SQLListFilms listFilm)
        {
            _SqlsqlUnitOfWork.SQLListFilmsRepository.Update(listFilm);
        }
    }
}
