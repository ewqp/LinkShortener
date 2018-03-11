using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webdev.Models;

namespace webdev.Controllers
{
    public class LinkController : Controller
    {
        public LinkController() { }

        [HttpGet]
        public IActionResult Index()
        {
            var link = new Link
            {
                FullLink = "www.wp.pl",
                ShortLink = "xxx"
            };
            return View(link);
        }
    }
}