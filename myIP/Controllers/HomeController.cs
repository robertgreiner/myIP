using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myIP.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/
        public ActionResult Index() {
            ViewBag.IP = GetExternalIp();
            return View();
        }
        private string GetExternalIp() {
            string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (String.IsNullOrEmpty(ip)) {
                ip = Request.ServerVariables["REMOTE_ADDR"];
            }
            return ip;
        }
    }
}
