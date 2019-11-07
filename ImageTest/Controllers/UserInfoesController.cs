using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImageTest.Models;
using Newtonsoft.Json;
using System.IO;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp;
using SixLabors.Primitives;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;
using Microsoft.AspNetCore.Hosting;

namespace ImageTest.Controllers
{
    public class UserInfoesController : Controller
    {
        private readonly ImageTestContext _context;
        private IHostingEnvironment _hostingEnvironment;

        public UserInfoesController(ImageTestContext context,IHostingEnvironment hosting)
        {
            _context = context;
            _hostingEnvironment = hosting;
        }

        // GET: UserInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserInfo.ToListAsync());
        }

        // GET: UserInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfo = await _context.UserInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userInfo == null)
            {
                return NotFound();
            }

            return View(userInfo);
        }

        // GET: UserInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Photo,PhotoType,UserName,Name")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

        // GET: UserInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfo = await _context.UserInfo.FindAsync(id);
            if (userInfo == null)
            {
                return NotFound();
            }
            return View(userInfo);
        }

        // POST: UserInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Photo,PhotoType,UserName,Name")] UserInfo userInfo)
        {
            if (id != userInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInfoExists(userInfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

        // GET: UserInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfo = await _context.UserInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userInfo == null)
            {
                return NotFound();
            }

            return View(userInfo);
        }

        // POST: UserInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userInfo = await _context.UserInfo.FindAsync(id);
            _context.UserInfo.Remove(userInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserInfoExists(int id)
        {
            return _context.UserInfo.Any(e => e.Id == id);
        }
        [HttpPost]
        public ActionResult UpLoadFile(string tailorInfo)
        {
            var success = false;
            var message = string.Empty;
            var newImage = string.Empty;
            var pictureUrl = string.Empty;
            try
            {
                var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(tailorInfo);
                tailorInfoEntity.PictureWidth = tailorInfoEntity.PictureWidth.Replace("px", "");
                tailorInfoEntity.PictureHeight = tailorInfoEntity.PictureHeight.Replace("px", "");
                var file = HttpContext.Request.Form.Files["txt_file"];

                if (file != null && file.Length != 0)
                {
                    newImage = ImageCompress(file.OpenReadStream(), tailorInfoEntity);
                    success = true;
                    message = "保存成功";
                }
            }
            catch (Exception ex)
            {
                message = "保存失败 " + ex.Message + "   " + ex.StackTrace.ToString();
            }
            return Json(new { success = success, message = message, newImage = newImage });

        }
        public static string ImageCompress(Stream content, TailorInfo tailorInfo)
        {
            IImageFormat format;
            var imageString = string.Empty;
            using (Image<Rgba64> image = Image.Load<Rgba64>(content, out format))
            {
                Rectangle rectangle = new Rectangle(tailorInfo.CoordinateX, tailorInfo.CoordinateY, tailorInfo.CoordinateWidth, tailorInfo.CoordinateHeight);
                image.Mutate(x => x
                     .Crop(rectangle)
                     .Resize(tailorInfo.CoordinateWidth, tailorInfo.CoordinateHeight)
                     );


                imageString = image.ToBase64String<Rgba64>(format);
            }
            return imageString;
        }

        [HttpPost]
        public async Task<IActionResult> CreateData()
        {

            bool success = false;
            var files = Request.Form.Files;
            var file = files.FirstOrDefault();
            string msg = Request.Form["tailorInfo"];
            var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(msg);
            string stuinfo = Request.Form["Userinfo"];
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(stuinfo);
                    try
                    {
                        string webrootpath = _hostingEnvironment.WebRootPath;
                        string filename = $"{ Guid.NewGuid()}.png";
                        string path = Path.Combine(webrootpath, filename).ToString();
                        Image<Rgba64> image = Image.Load<Rgba64>(file.OpenReadStream());

                        Rectangle rectangle = new Rectangle(tailorInfoEntity.CoordinateX, tailorInfoEntity.CoordinateY, tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight);
                        image.Mutate(x => x
                             .Crop(rectangle)
                             .Resize(tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight)
                             );
                        image.Save(path);
                        FileStream fs = new FileStream(path, FileMode.Open);
                        MemoryStream memory = new MemoryStream();
                        fs.CopyTo(memory);
                        userInfo.Photo = memory.ToArray();
                        userInfo.PhotoType = file.ContentType;
                        fs.Close();
                        FileInfo fileInfo = new FileInfo(Path.Combine(path));
                        fileInfo.Delete();
                        _context.Add(userInfo);
                        await _context.SaveChangesAsync();
                        success = true;
                    }
                    catch (Exception e)
                    {
                        msg = e.Message;
                    }

            return Json(new { success = success, msg = msg });
        }
        [HttpGet]
        public IActionResult ViewPhoto(int id)
        {
            UserInfo userInfo = _context.UserInfo.SingleOrDefault(s => s.Id == id);
            MemoryStream ms = new MemoryStream(userInfo.Photo);
            return new FileStreamResult(ms, userInfo.PhotoType);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateData()
        {
            bool success = false;
            string msg = "";
            try
            {
                var files = Request.Form.Files;
                var file = files.FirstOrDefault();
                msg = Request.Form["tailorInfo"];
                var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(msg);
                string Userinfo = Request.Form["Userinfo"];
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(Userinfo);
                var info = await _context.UserInfo.AsNoTracking().SingleOrDefaultAsync(s => s.Id == userInfo.Id);
                if (file != null)
                {
                    string webrootpath = _hostingEnvironment.WebRootPath;
                    string filename = $"{ Guid.NewGuid()}.png";
                    string path = Path.Combine(webrootpath, filename).ToString();
                    try
                    {

                        Image<Rgba64> image = Image.Load<Rgba64>(file.OpenReadStream());

                        Rectangle rectangle = new Rectangle(tailorInfoEntity.CoordinateX, tailorInfoEntity.CoordinateY, tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight);
                        image.Mutate(x => x
                             .Crop(rectangle)
                             .Resize(tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight)
                             );
                        image.Save(path);
                        FileStream fs = new FileStream(path, FileMode.Open);
                        MemoryStream memory = new MemoryStream();
                        fs.CopyTo(memory);
                        info.Photo = memory.ToArray();
                        info.PhotoType = file.ContentType;
                        fs.Close();
                        FileInfo fileInfo = new FileInfo(Path.Combine(path));
                        fileInfo.Delete();
                    }
                    catch (Exception e)
                    {
                        msg = e.Message;
                        try
                        {
                            FileInfo fileInfo = new FileInfo(Path.Combine(path));
                            fileInfo.Delete();
                        }
                        catch { }
                    }
                }
                info.Name = userInfo.Name;
                info.UserName = userInfo.UserName;
                _context.Update(info);
                await _context.SaveChangesAsync();
                success = true;
                return Json(new { success = success, msg = msg });
            }catch(Exception e)
            {
                msg = e.Message;
                return Json(new { success = success, msg = msg });
            }
        }
    }
}
