using BingoGameApi.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using BLL;
using Models.ViewModels;

namespace BingoGameApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [AllowCrossSiteJson]
        public JsonResult LoginUser(string userName)
        {
            List<string> existingUsers = new List<string>()
            {
                "Kobi","Avi","Davis","Ariel"
            };


            if (existingUsers.Any(p => p.ToLower().Equals(userName)))
            {

                var jsonResult = Json(new { status = true, testElement = "dskldlskdlskdls" }, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);

                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;


            }
            else
            {
                var jsonResult = Json(new { status = false }, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
        }

        [AllowCrossSiteJson]
        public JsonResult GetLottaryPageModel(string userName)
        {
            ILottaryBll lottaryBll = new LottaryBll();
            Lottary LottaryPageModel = lottaryBll.GetLottaryPageModel();
            var jsonResult = Json(new { lottary = LottaryPageModel}, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        
    }
}
