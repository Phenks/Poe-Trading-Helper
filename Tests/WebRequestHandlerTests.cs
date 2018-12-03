using System;
using Moq;
using NUnit.Framework;
using PoeTradingHelper.Backend.Helper;
using PoeTradingHelper.Backend.Helper.JsonWrappers;

namespace Tests
{
    [TestFixture]
    internal class WebRequestHandlerTests
    {
        [SetUp]
        public void Setup()
        {
            WebRequestSenderMock = Mock.Of<IWebRequestSender>(
                wrs => wrs.GetWebResponseData(It.IsAny<string>()) == WebResponseAsString
            );

            JsonConverterMock = Mock.Of<IJsonConverter>(
                jc => jc.ConvertWebResponseToJson<string>(It.IsAny<string>()) == It.IsAny<string>());


            RequestHandler = new WebRequestHandler(JsonConverterMock, WebRequestSenderMock);
        }

        public const string WebResponseAsString = "web response";
        public const string ValidUrl = "https://google.de";
        public WebRequestHandler RequestHandler { get; set; }
        public IWebRequestSender WebRequestSenderMock { get; set; }
        public IJsonConverter JsonConverterMock { get; set; }


        public class GetWebRequestDataAsJson : WebRequestHandlerTests
        {
            [TestCase("")]
            [TestCase(" ")]
            [TestCase(null)]
            [Test]
            public void NoUrlPassed_ThrowsArgumentException(string emptyUrl)
            {
                Assert.Throws<ArgumentException>(() =>
                    RequestHandler.GetWebRequestDataAsJson<PoeNinjaWrapper.Currency>(emptyUrl));
            }

            [Test]
            public void UrlIsValid_ConvertWebObjectToJsonIsCalledOnce()
            {
                RequestHandler.GetWebRequestDataAsJson<string>(ValidUrl);

                Mock.Get(JsonConverterMock).Verify(JsC => JsC.ConvertWebResponseToJson<string>(WebResponseAsString),
                    Times.Once);
            }

            [Test]
            public void UrlIsValid_GetWebResponseDataIsCalledOnce()
            {
                RequestHandler.GetWebRequestDataAsJson<string>(ValidUrl);

                Mock.Get(WebRequestSenderMock).Verify(wrs => wrs.GetWebResponseData(ValidUrl), Times.Once);
            }
        }
    }
}