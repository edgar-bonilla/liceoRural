using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using LICEORURALJASMINEZ.Utilidades;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace LICEORURALJASMINEZB.Controllers
{ 
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> FileUPload(IFormFile file)
        {
            await UploadFile(file);
            TempData["msg"] = "Imagen Cargada exitosamente";
            return View();

        }
        public async Task<bool> UploadFile(IFormFile file)
        {
            string path = "";
            bool iscopied = false;
            try {
                if (file.Length>0)
                {
                    string filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "Upload"));
                    using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                        await file.CopyToAsync(filestream);
                    
                    }
                    iscopied = true;
                }
                else
                {
                    iscopied = false;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return iscopied;
        }
        [Authorize(Roles = DS.Role_Admin)]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
