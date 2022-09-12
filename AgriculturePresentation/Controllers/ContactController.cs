using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value = _contactService.GetById(id);
            return View(value);
        }
    }
}
