using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using PoeTradingHelper.Backend.Helper.JsonWrappers;

namespace PoeTradingHelper.Backend.Helper
{

    public class WebRequestHandler
    {
        private IWebRequestSender WebRequestSender { get; set; }
        private IJsonConverter JsonConverter { get; set; }

        public WebRequestHandler()
        {
            JsonConverter = new JsonConverter();
            WebRequestSender = new WebRequestSender();
            
        }

        public WebRequestHandler(IJsonConverter jsonConverter, IWebRequestSender webRequestSender) : this()
        {
            JsonConverter = jsonConverter;
            WebRequestSender = webRequestSender;
        }

        public TJsonWrapper GetWebRequestDataAsJson<TJsonWrapper>(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("An Url must be passed to this function");
            string response = WebRequestSender.GetWebResponseData(url);
            return JsonConverter.ConvertWebResponseToJson<TJsonWrapper>(response);
        }
    }
}