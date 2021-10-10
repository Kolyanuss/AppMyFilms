using AppMyFilm.DAL.Entities.SQLEntities;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppMyFilm.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    public class ListFilmsController
    {
        #region Propertirs
        ISQLListFilmsService _sqlListFilmsService;
        #endregion

        #region Constructors
        public ListFilmsController(ISQLListFilmsService sqlListFilmsService)
        {
            _sqlListFilmsService = sqlListFilmsService;
        }
        #endregion

        #region APIs
        [Route("ListFilms")]
        [HttpGet]
        public IAsyncEnumerable<SQLListFilms> Get()
        {
            return _sqlListFilmsService.GetAllListFilms();
        }

        [Route("ListFilmsFilm/{Id}")]
        [HttpGet]
        public IAsyncEnumerable<SQLListFilms> GetByFilm(long Id)
        {
            return _sqlListFilmsService.GetListFilmByIdFilm(Id);
        }

        [Route("ListFilmsUser/{Id}")]
        [HttpGet]
        public IAsyncEnumerable<SQLListFilms> GetByUser(long Id)
        {
            return _sqlListFilmsService.GetListFilmByIdUser(Id);
        }

        [Route("ListFilmsJoin")]
        [HttpGet]
        public IAsyncEnumerable<SQLListFilmsStr> GetListFilmsJoinUser()
        {
            return _sqlListFilmsService.GetListFilmsJoinUser();
        }

        [Route("ListFilms")]
        [HttpPost]
        public long Post([FromBody] SQLListFilms listFilm)
        {
            return _sqlListFilmsService.AddListFilm(listFilm);
        }

        [Route("ListFilms/{id?}")]
        [HttpPut]
        public void Put([FromBody] SQLListFilms listFilm)
        {
            _sqlListFilmsService.UpdateListFilm(listFilm);
        }

        [Route("ListFilms/{id?}")]
        [HttpDelete]
        public void Delete([FromBody] SQLListFilms listFilm)
        {
            _sqlListFilmsService.DeleteListFilm(listFilm);
        }
        #endregion
    }
}
