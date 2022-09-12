using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _MapPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext agricultureContext = new AgricultureContext();
            var values = agricultureContext.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
