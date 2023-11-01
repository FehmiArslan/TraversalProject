using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.ViewComponnets.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager feature = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
           // var values = feature.TGetList();
           //Bu kısmı atlıyoruz..
            return View();
        }

    }

}
