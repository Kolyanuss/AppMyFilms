using AppMyFilm.DAL.Interfaces.EntityInterfaces;
using System.Collections.Generic;

namespace SkillManagement.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity, TId> where TEntity : IClearEntity
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(TId Id);
        
        long Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
