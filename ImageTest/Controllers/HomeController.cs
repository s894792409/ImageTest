using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageTest.Models;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;
using SixLabors.ImageSharp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;

namespace ImageTest.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        public HomeController(IHostingEnvironment hosting) {
            _hostingEnvironment = hosting;
        }
        public IActionResult Index()
        {
            return Redirect("/UserInfoes/index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult UpLoadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpLoadFile(string tailorInfo)
        {
            var success = false;
            var message = string.Empty;
            var newImage = string.Empty;
            var pictureUrl = string.Empty;
            int width = 0;
            int height = 0;

            try
            {
                var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(tailorInfo);
                tailorInfoEntity.PictureWidth = tailorInfoEntity.PictureWidth.Replace("px", "");
                tailorInfoEntity.PictureHeight = tailorInfoEntity.PictureHeight.Replace("px", "");
                var file = HttpContext.Request.Form.Files["txt_file"];
                width = tailorInfoEntity.CoordinateWidth;
                height = tailorInfoEntity.CoordinateHeight;
                //var file = HttpContext.Request.Files[0];
                //pictureUrl = "data:images/png;base64," + ImageHelper.ImageCompress(file.OpenReadStream());//图片缩放到一定规格
                string webrootpath = _hostingEnvironment.WebRootPath;
                string filename = $"{ Guid.NewGuid()}.png";
                string path = Path.Combine(webrootpath, filename).ToString();
                if (file != null && file.Length != 0)
                {
                    //await ImageHelper.CropImage(file.OpenReadStream());
                    newImage = ImageHelper.ImageCompress(file.OpenReadStream(), path, tailorInfoEntity);
                    success = true;
                    message = "保存成功";
                    //message = tailorInfoEntity.ToString();
                }
            }
            catch (Exception ex)
            {
                message = "保存失败 " + ex.Message + "   " + ex.StackTrace.ToString();
            }
                return Json(new { success = success, message = message,newImage=newImage});

        }
    }
}
