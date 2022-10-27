using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Web_Translator_FP.Models;

namespace Web_Translator_FP.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILogger<LanguageController> _logger;

        public LanguageController(ILogger<LanguageController> logger)
        {
            _logger = logger;
        }
        //public IActionResult Languages()
        //{

        //    var client = new RestClient("https://long-translator.p.rapidapi.com/languages");
        //    var request = new RestRequest();
        //    request.AddHeader("X-RapidAPI-Key", "045c7481a9msh42b3c5fe69c7ff2p11a560jsna6634ac98d6c");
        //    request.AddHeader("X-RapidAPI-Host", "long-translator.p.rapidapi.com");
        //    var response = client.Execute(request);
        //    var root = JsonConvert.DeserializeObject<Root>(response.Content);
        //    return View(root);
        //}
    }
}
