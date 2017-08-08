using Cake.Services.Cake;
using Cake.Services.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cake.WebUI.Controllers
{
    [RoutePrefix("template")]
    public class TemplateController : Controller
    {
        private readonly IQuickLinkService _linkService;
        private readonly ICakeService _cakeService;

        public TemplateController(IQuickLinkService linkService, ICakeService cakeService)
        {
            _linkService = linkService;
            _cakeService = cakeService;
        }

        [Route("navbar")]
        public ActionResult Navbar()
        {
            var cakes = _cakeService.GetScenarios().ToList();
            ViewData["num"] = cakes.Count == 0 ? 12 : 12 / cakes.Count;
            return View(cakes);
        }
        [Route("headerinfo")]
        public ActionResult Headerinfo()
        {
            return View();
        }
        [Route("banner")]
        public ActionResult Banner()
        {
            return View();
        }
        [Route("gallery")]
        public ActionResult Gallery()
        {
            return View();
        }
        [Route("subscribe")]
        public ActionResult Subscribe()
        {
            return View();
        }

        [Route("footer")]
        public ActionResult Footer()
        {
            var links = _linkService.GetLinks().ToList();
            ViewData["cols"] = links.Count == 0 ? 12 : 12 / links.Count;
            return View(links);
        }
    }
}