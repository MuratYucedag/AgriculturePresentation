using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();

            productClasses.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 850
            });

            productClasses.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 480
            });

            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 250
            });

            productClasses.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 120
            });

            productClasses.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 960
            });

            return Json(new { jsonlist = productClasses });
        }
    }
}
