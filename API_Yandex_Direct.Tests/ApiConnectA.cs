using System;
using System.Net;
using API_Yandex_Direct.ApiConnect.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Yandex_Direct.Tests
{
    [TestClass]
    public class ApiConnect5 : API_Yandex_Direct.ApiConnect.Infrastructure.ApiConnect5
    {
        public ApiConnect5() :
            base(new UserRequest("Tester") { AccepLanguage = AccepLanguage.ru, TokenApi = "Tokin1" })
        { }

        [TestMethod]
        public void GetHttpWebRequest_Base1()
        {
            // Arrang
            API_Yandex_Direct.Get.AdGroup.ParamsRequest paramsRequest
                = new API_Yandex_Direct.Get.AdGroup.ParamsRequest(
                    new API_Yandex_Direct.Get.AdGroup.FieldNamesEnum[]
                    { API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.Id })
                { SelectionCriteria = new API_Yandex_Direct.Get.AdGroup.AdGroupsSelectionCriteria() };

            RequestObjectV5 requestObjectV5 = new RequestObjectV5() { Method = "get", Params = paramsRequest };

            string[] Headers = new string[] { };
            string setBodyRequest = "";
            string expectedSetBodyRequest = "{\"method\":\"get\",\"params\":{\"SelectionCriteria\":{},\"FieldNames\":[\"Id\"]}}";
            string expectedHeaders = @"Authorization: Bearer Tokin1
Client-Login: Tester
Accept-Language: ru
Content-Type: application/json; charset=utf-8
Host: api.direct.yandex.com
Content-Length: 70
Connection: Keep-Alive

";

            // Act
            HttpWebRequest httpWebRequest = GetHttpWebRequest(requestObjectV5, UrlDirect, false, ref Headers, ref setBodyRequest);

            string s = httpWebRequest.Headers.ToString();

            // Assert
            Assert.AreEqual(expectedSetBodyRequest, setBodyRequest);
            Assert.AreEqual(expectedHeaders, httpWebRequest.Headers.ToString());


        }
    }
}
