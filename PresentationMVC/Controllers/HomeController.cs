using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            if (PresentationMVC.Models.Setup.SetupGet == null) PresentationMVC.Models.Setup.SetupGet = new Models.Setup { UrlDirect = "api.direct.yandex.com" };
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(PresentationMVC.Models.Setup.SetupGet);
        }
        [HttpPost]
        public ActionResult Index(PresentationMVC.Models.Setup setup)
        {
            PresentationMVC.Models.Setup.SetupGet = setup;
            return Redirect("/Home/About");
        }

        // [HttpGet]
        public ActionResult About()
        {
            Models.Conect conect = new Models.Conect();

            return View(conect);
        }

        [HttpGet]
        public PartialViewResult ReturnInfo(long id)
        {
            Models.KeywordBidSet bitSet = new Models.KeywordBidSet(id);
            return PartialView("BitSet", bitSet);
        }

        [HttpPost]
        public ActionResult ReturnInfo(long id, string bit)
        {
            Models.KeywordBidSet bitSet = new Models.KeywordBidSet(id);
            double bit1 = bitSet.Bit;
            double.TryParse(bit.Replace(".", ","), NumberStyles.Number, CultureInfo.CreateSpecificCulture("ru-Ru"), out bit1);
            if (bit1 == bitSet.Bit) Redirect("/Home/About");
            bitSet.Bit = bit1;
            return Redirect("/Home/About");
        }
    }
}