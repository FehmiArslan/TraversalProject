using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponnets.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
