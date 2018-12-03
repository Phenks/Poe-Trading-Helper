
using Newtonsoft.Json.Linq;

namespace PoeTradingHelper.Backend.Helper
{
    public static class ClassExtensions
    {
        public static JToken RemoveWrapper(this JToken jToken,string wrapperName)
        {
            return jToken.SelectToken(wrapperName);
        }
    }
}
