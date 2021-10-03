using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using SkillManagement.DataAccess.Interfaces;
using System.Collections.Generic;

namespace AppMyFilm.DAL.Services.SQL_Services
{
    public class SQLFilmsService : ISQLFilmsService
    {
        ISQLUnitOfWork _SqlsqlUnitOfWork;

        public SQLFilmsService(ISQLUnitOfWork sqlSqlUnitOfWork)
        {
            _SqlsqlUnitOfWork = sqlSqlUnitOfWork;
        }

        public long AddFilm(SQLFilms film)
        {
            return _SqlsqlUnitOfWork.SQLFilmsRepository.Add(film);
        }

        public void DeleteFilm(SQLFilms film)
        {
            _SqlsqlUnitOfWork.SQLFilmsRepository.Delete(film);
        }

        public IEnumerable<SQLFilms> GetAllFilms()
        {
            return _SqlsqlUnitOfWork.SQLFilmsRepository.GetAll();
        }

        public SQLFilms GetFilmById(long Id)
        {
            return _SqlsqlUnitOfWork.SQLFilmsRepository.Get(Id);
        }

        public void UpdateFilm(SQLFilms film)
        {
            _SqlsqlUnitOfWork.SQLFilmsRepository.Update(film);
        }
    }
}
