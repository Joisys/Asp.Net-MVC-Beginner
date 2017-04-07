using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.Net_MVC_Beginner.Data;

namespace Asp.Net_MVC_Beginner.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            var context = new MvcBeginnerDataContext();
            var locations = context.Locations.ToList();
            return View(locations);
        }

        public ActionResult Detail(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Update(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}