﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Fashion.Models;

namespace Web_Fashion.Areas.Admin.Controllers
{
    public class ProductImageController : Controller
    {
        private Fashion_ShopDbContext db = new Fashion_ShopDbContext();
        // GET: Admin/ProductImage
        public ActionResult Index(int id)
        {
            ViewBag.ProductId = id;
            var items = db.ProductImages.Where(x => x.ProductId == id).ToList();
            return View(items);
        }

        [HttpPost]
        public ActionResult AddImage(int productId,string url)
        {
            db.ProductImages.Add(new ProductImage { 
                ProductId=productId,
                Image=url,
                IsDefault=false
            });
            db.SaveChanges();
            return Json(new { Success=true});
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.ProductImages.Find(id);
            db.ProductImages.Remove(item);
            db.SaveChanges();
            return Json(new { success = true });
        }
    }
}