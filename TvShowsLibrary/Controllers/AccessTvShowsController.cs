using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TvShowsLibraryData.Data;
using TvShowsLibraryData.Models;

namespace TvShowsLibrary.Controllers
{
    public class AccessTvShowsController : ApiController
    {
        private readonly ITvShowsRepository _repo;

        public AccessTvShowsController(ITvShowsRepository repo)
        {
            _repo = repo;
        }

        // GET api/<controller>/5
        public IEnumerable<TvShow> Get()
        {
            var AllShows = _repo.GetAllTvShows();
            return AllShows;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}