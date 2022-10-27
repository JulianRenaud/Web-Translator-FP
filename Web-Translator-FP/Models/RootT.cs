using Newtonsoft.Json;

namespace Web_Translator_FP.Models
{
    public class RootT
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataT DataT { get; set; }
    }


}
