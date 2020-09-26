using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZOI.APP.Models;
using ZOI.BAL.Models;

namespace ZOI.APP.Controllers
{
   // [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public Ozy_WebsiteContext DbContext = new Ozy_WebsiteContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

      //  [AllowAnonymous]
        public IActionResult Index()
        {
            TblBannerMasters BN = new TblBannerMasters();
            var BannerList = (from Banner in DbContext.TblBannerMasters
                              select Banner).ToList();
            return View(BannerList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
