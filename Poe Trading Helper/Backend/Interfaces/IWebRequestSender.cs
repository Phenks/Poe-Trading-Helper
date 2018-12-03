namespace PoeTradingHelper.Backend.Helper
{
    public interface IWebRequestSender
    {
        string GetWebResponseData(string url);
    }
}