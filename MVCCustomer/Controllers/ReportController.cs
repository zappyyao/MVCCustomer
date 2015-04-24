using MVCCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomer.Controllers
{
    public class ReportController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: Report
        public ActionResult Index()
        {
            var data = db.客戶資料;
            foreach (var item in data)
            {
                //item.客戶聯絡人.Count();
            }


            return View(data.ToList());
        }
    }
}