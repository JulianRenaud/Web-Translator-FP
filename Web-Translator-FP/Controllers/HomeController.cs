using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Diagnostics;
using Web_Translator_FP.Models;

namespace Web_Translator_FP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lang = new API();
            var root = lang.Languages();
            return View(root);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Languages()
        {
            var lang = new API();
            var root = lang.Languages();
            return View(root);
        }

        public IActionResult Translate(string inputLang, string translateLang, string text)
        {
            var translate = new API();
            var roott = translate.Translate(inputLang, translateLang, text);
            return View(roott);
        }
        //public IActionResult Detect(string inputLang, string translateLang, string text)
        //{
        //    var translate = new API();
        //    var roott = translate.Translate(inputLang, translateLang, text);
        //    return View(roott);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}