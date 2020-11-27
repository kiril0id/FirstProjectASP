using FirstProjectASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Woker woker = new Woker();
            List<WokerAccesLayer> listWoker = woker.GetDateWoker();
            return View(listWoker);
        }

        public ActionResult Contact()
        {
            Company company = new Company();
            List<CompanyAccesLayer> listcompany = company.GetDateCompany();
            return View(listcompany);


        }
    }
}