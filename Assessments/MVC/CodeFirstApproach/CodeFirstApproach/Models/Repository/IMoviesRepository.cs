using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Models.Repository
{
    public class IMoviesRepository : Controller
    {
        // GET: IMoviesRepository
        public ActionResult Index()
        {
            return View();
        }
    }
}