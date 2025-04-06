using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Fashion.Models;

namespace Web_Fashion.Controllers
{
    public class ArticleController : Controller
    {
        private Fashion_ShopDbContext db = new Fashion_ShopDbContext();
        // GET: Article
        public ActionResult Index(string alias)
        {
            var item = db.Posts.FirstOrDefault(x => x.Alias == alias);
            return View(item);
        }
    }
}