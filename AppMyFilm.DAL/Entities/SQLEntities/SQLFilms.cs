using Microsoft.OData.Edm;
using SkillManagement.DataAccess.Interfaces;

namespace AppMyFilm.DAL.Entities.SQLEntities
{
    public class SQLFilms : IEntity<long>
    {
        public long Id { get; set; }
        public string NameFilm { get; set; }
        public Date ReleaseData { get; set; }
        public string Country { get; set; }
        public long DescriptionId { get; set; }
    }
}
