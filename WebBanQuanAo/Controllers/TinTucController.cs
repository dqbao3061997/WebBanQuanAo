using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanQuanAo.Models;

namespace WebBanQuanAo.Controllers
{
    public class TinTucController : Controller
    {
        //
        // GET: /TinTuc/
        BanQuanAoEntities db = new BanQuanAoEntities();
        public ActionResult Index()
        {
            return View("TinTuc", db.TinTucs.OrderBy(n => n.IdTinTuc));
        }
        public ActionResult TinTuc(int? id)
        {
            return View(db.TinTucs.Where(n => n.IdTinTuc == id));
        }
        public ActionResult NoiDung(int? id)
        {
            return View(db.TinTucs.SingleOrDefault(n => n.IdTinTuc == id));
        }
	}
}