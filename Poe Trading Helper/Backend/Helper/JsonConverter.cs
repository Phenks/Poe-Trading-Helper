using Newtonsoft.Json;

namespace PoeTradingHelper.Backend.Helper
{
    public class JsonConverter : IJsonConverter
    {
        public TJsonWrapper ConvertWebResponseToJson<TJsonWrapper>(string response)
        {
            return JsonConvert.DeserializeObject<TJsonWrapper>(response);
        }
    }
}