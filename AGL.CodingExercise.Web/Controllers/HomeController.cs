using System.Web.Mvc;
using AGL.CodingExercise.Domain.Abstractions;

namespace AGL.CodingExercise.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPeopleService _peopleService;

        public HomeController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public ActionResult Index()
        {
            var response = _peopleService.GetPetsGroupedByGenderOfOwner();
            return View(response);
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