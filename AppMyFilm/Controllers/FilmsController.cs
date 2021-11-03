using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppMyFilm.WEBAPI.Controllers
{
    [Route("api/[controller]")]

    public class FilmsController
    {
        #region Propertirs
        ISQLFilmsService _sqlFilmsService;
        #endregion

        #region Constructors
        public FilmsController(ISQLFilmsService sqlFilmsService)
        {
            _sqlFilmsService = sqlFilmsService;
        }
        #endregion

        #region APIs
        [Route("Films")]
        [HttpGet]
        public IEnumerable<SQLFilms> Get()
        {
            return _sqlFilmsService.GetAllFilms();
        }

        [Route("FilmsPop")]
        [HttpGet]
        public IEnumerable<SQLFilms> GetNotPopularFilms()
        {
            return _sqlFilmsService.GetNotPopularFilms();
        }

        [Route("Films/{Id}")]
        [HttpGet]
        public SQLFilms Get(long Id)
        {
            return _sqlFilmsService.GetFilmById(Id);
        }

        [Route("Films")]
        [HttpPost]
        public long Post([FromBody] SQLFilms film)
        {
            return _sqlFilmsService.AddFilm(film);
        }

        [Route("Films/{id?}")]
        [HttpPut]
        public void Put([FromBody] SQLFilms film)
        {
            _sqlFilmsService.UpdateFilm(film);
        }

        [Route("Films/{id?}")]
        [HttpDelete]
        public void Delete([FromBody] SQLFilms film)
        {
            _sqlFilmsService.DeleteFilm(film);
        }
        #endregion
    }
}
