using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TvShowsLibraryData.Models;
using TvShowsLibraryData.Data;

namespace TvShowsLibrary.Controllers
{
    public class HomeController : Controller
    {
        private ITvShowsRepository _repo;

        public HomeController(ITvShowsRepository repo)
        {
            _repo=repo;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTvShow(TvShow ts)
        {
            _repo.AddTvShow(ts);
            return View(ts);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}