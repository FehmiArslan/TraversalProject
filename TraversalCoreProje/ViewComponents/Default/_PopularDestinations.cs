using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.ViewComponnets.Default
{
    public class _PopularDestinations : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DestinationManager destinationManager=new DestinationManager(new EfDestinationDal());
            {
                var values = destinationManager.TGetList();
                return View(values);
            }
        }



    }
}
