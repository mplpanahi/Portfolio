using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<MyPortfolio> _portfolios = new List<MyPortfolio>
        {
            new MyPortfolio
            {
                Id=1,Title="Katma",Image="01.jpg",Description="این اولین پروژه من بود"
            },
            new MyPortfolio
            {
                Id=2,Title="پیام رسان",Image="02.jpg",Description="پیام رسان اختصاصی من"
            },
            new MyPortfolio
            {
                Id=3,Title="شبکه اجتماعی",Image="03.jpg",Description="این بهترین شبکه اجتماعی است"
            },
            new MyPortfolio
            {
                Id=4,Title="درخواست غذا",Image="04.jpg",Description="اولین اپلیکیشن درخواست غذا"
            }
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی محمد پناهی خوش آمدید";
            ViewBag.headingText = "این سایت جهت معرفی من به کسانی که میخواهند از خدمات من برخوردار شوند طراحی شده است";
            return View(_portfolios);
        }

        public IActionResult Contact()
        {
            var contact=new Contact()
            {
                Email="MPLPanahi@gmail.com",
                Mobile="09159803417",
                Github= "https://github.com/mplpanahi"
            };

            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}