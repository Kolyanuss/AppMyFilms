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
        // GET: Get all employees
        [Route("Films")]
        [HttpGet]
        public IEnumerable<SQLFilms> Get()
        {
            return _sqlFilmsService.GetAllFilms();
        }

        // GET: Get employee by id
        [Route("Films/{Id}")]
        [HttpGet]
        public SQLFilms Get(long Id)
        {
            return _sqlFilmsService.GetFilmById(Id);
        }

        // POST: Add new employee
        [Route("Films")]
        [HttpPost]
        public long Post([FromBody] SQLFilms film)
        {
            return _sqlFilmsService.AddFilm(film);
        }

        // PUT: Update existing employee
        [Route("Films/{id?}")]
        [HttpPut]
        public void Put([FromBody] SQLFilms film)
        {
            _sqlFilmsService.UpdateFilm(film);
        }

        // DELETE: Delete existing employee
        [Route("Films/{id?}")]
        [HttpDelete]
        public void Delete([FromBody] SQLFilms film)
        {
            _sqlFilmsService.DeleteFilm(film);
        }
        #endregion
    }
}
