using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _GalleryPartial : ViewComponent
    {
        private readonly IImageService _ımageService;

        public _GalleryPartial(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ımageService.GetListAll();
            return View(values);
        }
    }
}
