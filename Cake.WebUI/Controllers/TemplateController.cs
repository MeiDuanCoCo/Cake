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

        public TemplateController(IQuickLinkService linkService)
        {
            _linkService = linkService;
        }

        [Route("navbar")]
        public ActionResult Navbar()
        {
            return View();
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