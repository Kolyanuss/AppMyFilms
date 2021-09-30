using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppMyFilm.WEBAPI.Controllers
{
    public class FilmsController
    {
        #region Propertirs
        ISQLFilmsService _sqlFilmsService;
        #endregion

        #region Constructors
        public FilmsController(ISQLFilmsService sqlEmployeeService)
        {
            _sqlFilmsService = sqlEmployeeService;
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
        public long Post([FromBody] SQLFilms employee)
        {
            return _sqlFilmsService.AddFilm(employee);
        }

        // PUT: Update existing employee
        [Route("Films/{id?}")]
        [HttpPut]
        public void Put([FromBody] SQLFilms employee)
        {
            _sqlFilmsService.UpdateFilm(employee);
        }

        // DELETE: Delete existing employee
        [Route("Films/{id?}")]
        [HttpDelete]
        public void Delete([FromBody] SQLFilms employee)
        {
            _sqlFilmsService.DeleteFilm(employee);
        }
        #endregion
    }
}
