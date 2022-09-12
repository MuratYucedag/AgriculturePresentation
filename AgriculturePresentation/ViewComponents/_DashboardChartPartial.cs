using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardChartPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 88;
            ViewBag.v2 = 93;
            return View();
        }
    }
}
