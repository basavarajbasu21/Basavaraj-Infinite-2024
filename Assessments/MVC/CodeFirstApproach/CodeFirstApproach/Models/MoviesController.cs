using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Models
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
    }
}