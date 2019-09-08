using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class GradesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            var average = 0.0;

            foreach (var key in formCollection.Keys)
            {
                try
                {   
                    if (Convert.ToDouble(formCollection[key.ToString()]) < 0 ||
                        Convert.ToDouble(formCollection[key.ToString()]) > 100)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        average += Convert.ToDouble(formCollection[key.ToString()]);
                    }
                    
                }
                catch (Exception e)
                {
                    ViewData["message"] = "Enter numbers ranging from 0 - 100.";
                    return View();
                }
            }

            average = average / formCollection.Count;

            ViewData["average"] = average;

            return View();
        }
    }
}