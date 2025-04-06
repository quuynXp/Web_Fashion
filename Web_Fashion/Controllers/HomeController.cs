using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Fashion.Models;

namespace Web_Fashion.Controllers
{
    public class HomeController : Controller
    {
        private Fashion_ShopDbContext db = new Fashion_ShopDbContext();
        public ActionResult Index()
        {
         
            //WebBanHangOnline.Common.Common.SendMail("ABC", "AAAA", "AAAA", "ngohoang29@gmail.com");
            return View();
        }

        public ActionResult Partial_Subcrice()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Subscribe(string Email)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra nếu người dùng đã đăng ký trong vòng 5 phút
                var lastSubscription = db.Subscribes.Where(s => s.Email == Email)
                                                    .OrderByDescending(s => s.CreatedDate)
                                                    .FirstOrDefault();

                if (lastSubscription != null && (DateTime.Now - lastSubscription.CreatedDate).TotalMinutes < 5)
                {
                    return Json(new { Success = false, Message = "Bạn đã đăng ký quá nhanh, vui lòng thử lại sau 5 phút." });
                }

                //Lưu vào csdl
                db.Subscribes.Add(new Subscribe { Email = Email, CreatedDate = DateTime.Now });
                db.SaveChanges();
                // Gửi email
                bool emailSent = Common.Common.SendMail("CSKH Ngọc Quyên", "Fashion Z", "Cảm ơn bạn đã đăng ký thông báo về những ưu đãi web chúng tôi.", Email);
                if (emailSent)
                {
                    return Json(new { Success = true, Message = "Đăng ký thành công! Cảm ơn bạn." });
                }
                else
                {
                    return Json(new { Success = false, Message = "Có lỗi khi gửi email." });
                }
            }
            // Trả về kết quả Json nếu có lỗi
            return Json(new { Success = false, Message = "Có lỗi khi đăng ký" });
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Refresh()
        {
            var item = new ThongKeModel();

            ViewBag.Visitors_online = HttpContext.Application["visitors_online"];
            var hn = HttpContext.Application["HomNay"];
            item.HomNay = HttpContext.Application["HomNay"].ToString();
            item.HomQua = HttpContext.Application["HomQua"].ToString();
            item.TuanNay = HttpContext.Application["TuanNay"].ToString();
            item.TuanTruoc = HttpContext.Application["TuanTruoc"].ToString();
            item.ThangNay = HttpContext.Application["ThangNay"].ToString();
            item.ThangTruoc = HttpContext.Application["ThangTruoc"].ToString();
            item.TatCa = HttpContext.Application["TatCa"].ToString();
            return PartialView(item);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Blog page.";

            return View();
        }
    }
}