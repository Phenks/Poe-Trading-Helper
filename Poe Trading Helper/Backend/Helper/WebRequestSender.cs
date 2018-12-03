using System;
using System.IO;
using System.Net;

namespace PoeTradingHelper.Backend.Helper
{
    public class WebRequestSender : IWebRequestSender
    {
        public string GetWebResponseData(string url)
        {
            WebRequest request = WebRequest.Create(url);
            //TODO Timeout Testen?
            request.Timeout = 15000;
            WebResponse responseData = request.GetResponse();
            Stream stream = responseData.GetResponseStream();
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));
            var response = new StreamReader(stream).ReadToEnd();

            return response;
        }
    }
}