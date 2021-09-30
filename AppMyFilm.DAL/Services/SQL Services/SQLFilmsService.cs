using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using SkillManagement.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public IEnumerable<SQLFilms> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public SQLFilms GetFilmById(long Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFilm(SQLFilms film)
        {
            throw new NotImplementedException();
        }
    }
}
