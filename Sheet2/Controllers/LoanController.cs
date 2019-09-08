using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class LoanController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Double initialInvestment, Double interest, int numYears)
        {
            Double finalInvestment = initialInvestment;

            for (int i = 0; i < numYears; i++)
            {
                finalInvestment += finalInvestment * (interest / 100);
            }

            ViewData["initialInvestment"] = initialInvestment;
            ViewData["interest"] = interest;
            ViewData["numYears"] = numYears;

            ViewData["finalInvestment"] = Math.Round(finalInvestment, 2);
            return View();
        }
    }
}