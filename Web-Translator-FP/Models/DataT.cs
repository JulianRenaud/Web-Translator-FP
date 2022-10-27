using Newtonsoft.Json;

namespace Web_Translator_FP.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DataT
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }

        [JsonProperty("detectedSourceLanguage")]
        public DetectedSourceLanguage DetectedSourceLanguage { get; set; }
    }


}
