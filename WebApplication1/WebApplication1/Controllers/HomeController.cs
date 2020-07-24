using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ViewResult Rating(string ID)
        {
            ViewBag.BeerID = ID;
            return View();
        }

        [HttpPost]
        public ActionResult SaveDatainFile(string ID, string username, string rating, string comment)
        {
            DataManger DM = new DataManger();
            Ucomment dataobj = new Ucomment(ID, username, comment, rating);
            DM.WriteToJsonFile(dataobj);

            return Json("Success");
        }

        [HttpGet]
        public JsonResult GetcommentSaveList( string ID)
        {
            DataManger DM = new DataManger();

            var list = DM.ReadfromJsonFile(ID);

            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}