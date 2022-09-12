using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _AboutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext c = new AgricultureContext();
            var values = c.Abouts.ToList();
            return View(values);
        }
    }
}
