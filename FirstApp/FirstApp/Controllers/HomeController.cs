using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstApp.Models;
using System.IO;

namespace FirstApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index(int id)
        {                        
            var fileBytes = System.IO.File.ReadAllBytes(@"C:\arquivo.txt");
            var fileName = "teste_maravilhoso.txt";

            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            //return Content("Esse é um retorno legal");
            //return Ok();
            return BadRequest();
        }

        [Route("privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
