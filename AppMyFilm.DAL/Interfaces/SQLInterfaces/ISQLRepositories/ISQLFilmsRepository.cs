using AppMyFilm.DAL.Entities.SQLEntities;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using System.Collections.Generic;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLFilmsRepository : IGenericRepository<SQLFilms, long>
    {
        IEnumerable<SQLFilms> GetNotPopularFilms();
    }
}
