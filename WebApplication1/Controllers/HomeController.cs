using LesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IProvider _provider = null;

        public HomeController(IProvider provider)
        {
            this._provider = provider;
        }

        public ActionResult Index()
        {
            string value = this.Request.Params["val"];

            this.ViewBag.Message = this._provider.DoWhatYouNeedToDo(new LesObjets.OneFilter()
            {
                Value1 = value
            });

            return View();
        }

        public ActionResult About()
        {


            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}