using AppMyFilm.DAL.Entities.SQLEntities;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;

namespace AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLFilmsRepository : IGenericRepository<SQLFilms, long>
    {

    }
}
