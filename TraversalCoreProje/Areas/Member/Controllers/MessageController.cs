using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
