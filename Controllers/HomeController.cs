using System.Web.Mvc;
using PostmarkDemo.Models;

namespace PostmarkDemo.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private readonly IMessageSender _messageSender;

        public HomeController(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(string email)
        {
            var response = _messageSender.SendMessage(email);

            TempData["Message"] = response;

            return RedirectToAction("Index");
        }
    }
}
