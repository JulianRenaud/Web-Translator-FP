using Newtonsoft.Json;
using RestSharp;
using Web_Translator_FP.Controllers;
using Web_Translator_FP.Models;

namespace Web_Translator_FP
{
    public class API
    {
        public Root Languages()
        {
            
            var client = new RestClient("https://long-translator.p.rapidapi.com/languages");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", Config.GetAPI());
            request.AddHeader("X-RapidAPI-Host", "long-translator.p.rapidapi.com");
            var response = client.Execute(request);
            var root = JsonConvert.DeserializeObject<Root>(response.Content);
            return root;
        }
        public RootT Translate(string inputLang, string translateLang, string text)
        {
            var client = new RestClient("https://long-translator.p.rapidapi.com/translate");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("X-RapidAPI-Key", Config.GetAPI());
            request.AddHeader("X-RapidAPI-Host", "long-translator.p.rapidapi.com");
            request.AddParameter("application/x-www-form-urlencoded", "source_language=" + inputLang + "&target_language=" + translateLang + "&text=" + text, ParameterType.RequestBody);
            var response = client.Execute(request);
            var roott = JsonConvert.DeserializeObject<RootT>(response.Content);
            return roott;
        }
        public RootT Detect(string text)
        {
            var client = new RestClient("https://long-translator.p.rapidapi.com/translate");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("X-RapidAPI-Key", Config.GetAPI());
            request.AddHeader("X-RapidAPI-Host", "long-translator.p.rapidapi.com");
            request.AddParameter("application/x-www-form-urlencoded", "source_language=auto&target_language=en&text=" + text, ParameterType.RequestBody);
            var response = client.Execute(request);
            var roott = JsonConvert.DeserializeObject<RootT>(response.Content);
            return roott;
        }
    }
}

