using SkillManagement.DataAccess.Interfaces;
using System;

namespace AppMyFilm.DAL.Entities.SQLEntities
{
    public class SQLFilms : IEntity<long>
    {
        public long Id { get; set; }
        public string NameFilm { get; set; }
        public DateTime ReleaseData { get; set; }
        public string Country { get; set; }
        public long DescriptionId { get; set; }
    }
}
