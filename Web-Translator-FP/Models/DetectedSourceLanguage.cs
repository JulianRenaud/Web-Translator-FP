using Newtonsoft.Json;

namespace Web_Translator_FP.Models
{
    public class DetectedSourceLanguage
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }


}
