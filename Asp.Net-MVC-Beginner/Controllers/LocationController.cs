using System.Linq;
using System.Web.Mvc;
using Asp.Net_MVC_Beginner.Data;
using Asp.Net_MVC_Beginner.Models;

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
            var context = new MvcBeginnerDataContext();
            var location = context.Locations.FirstOrDefault(l => l.Id==id);
            return View(location);
        }

        public ActionResult Create()
        {
            return View(new LocationViewModel());
        }

        [HttpPost]
        public ActionResult Create(LocationViewModel model)
        {
            var context = new MvcBeginnerDataContext();
            context.Locations.InsertOnSubmit(new Location
            {
                Title = model.Title
            });
            context.SubmitChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var context = new MvcBeginnerDataContext();
            var location = context.Locations.FirstOrDefault(l => l.Id == id);
            return View(location);
        }

        [HttpPost]
        public ActionResult Update(int id, LocationViewModel model)
        {
            var context = new MvcBeginnerDataContext();
            var location = context.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null) return View();

            location.Title = model.Title;
            context.SubmitChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var context = new MvcBeginnerDataContext();
            var location = context.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null) return RedirectToAction("Index");
            return View(location);
        }

        [HttpPost]
        public ActionResult Delete(int id, LocationViewModel model)
        {
            var context = new MvcBeginnerDataContext();
            var location = context.Locations.FirstOrDefault(l => l.Id == id);
            if (location == null) return RedirectToAction("Index");

            context.Locations.DeleteOnSubmit(location);
            context.SubmitChanges();

            return RedirectToAction("Index");
        }

    }
}