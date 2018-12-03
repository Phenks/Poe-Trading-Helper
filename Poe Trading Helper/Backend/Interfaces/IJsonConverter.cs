namespace PoeTradingHelper.Backend.Helper
{
    public interface IJsonConverter
    {
        TJsonWrapper ConvertWebResponseToJson<TJsonWrapper>(string response);
    }
}