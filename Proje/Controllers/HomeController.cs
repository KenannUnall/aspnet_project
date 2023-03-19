using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private UrunlerEntities1 db = new UrunlerEntities1();
        public ActionResult dilDegistir(string lang, string returnUrl)
        {
            Session["Dil"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }

        public ActionResult Index()
        {
            return View(db.Resim.ToList());
        }
        public ActionResult Kadin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Erkek()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cocuk()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SporMalzemeleri()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult AyakkabiDetay()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Sepet()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Users = "kenanunal310@gmail.com")]
        public ActionResult AdminAnasayfa()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Users = "kenanunal310@gmail.com")]
        public ActionResult AdminKategoriler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Users = "kenanunal310@gmail.com")]
        public ActionResult AdminKullanicilar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Users = "kenanunal310@gmail.com")]
        public ActionResult AdminUrunler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Users = "kenanunal310@gmail.com")]
        public ActionResult Yonet()
        {
            return View();
        }
    }
}