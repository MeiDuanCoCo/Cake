using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cake.Web.Controllers
{
    public class ShopNowController : Controller
    {
        // GET: ShopNow
        public ActionResult Index()
        {
            return View();
        }
        //现在去购物
        public ActionResult ShopStore()
        {
            return View();
        }
    }
}