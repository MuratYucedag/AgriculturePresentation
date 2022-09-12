using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardTablePartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DashboardTablePartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
    }
}
