using System;
using System.Net;
using API_Yandex_Direct.ApiConnect.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Yandex_Direct.Tests
{
    [TestClass]
    public class ApiConnect5 : API_Yandex_Direct.ApiConnect.Infrastructure.ApiConnect5
    {
        public ApiConnect5() : base(new UserRequest("Tester") { AccepLanguage = AccepLanguage.ru, TokenApi = "Tokin1" }) { }

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

        [TestMethod]
        ///Этот тест выявил проблемму низкой скорости а обработке запроса рttpWebRequest.GetRequestStream()
        ///решением стало добавление строчек:
        ///рttpWebRequest.Proxy = null;
        ///рttpWebRequest.AllowAutoRedirect = false;
        ///рttpWebRequest.ServicePoint.ConnectionLimit = 5;
        public void GetHttpWebRequest_Base_for()
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

            for(int i=0; i<4; i++)
            {
                httpWebRequest = GetHttpWebRequest(requestObjectV5, UrlDirect, false, ref Headers, ref setBodyRequest);
            }

            string s = httpWebRequest.Headers.ToString();

            // Assert
            Assert.AreEqual(expectedSetBodyRequest, setBodyRequest);
            Assert.AreEqual(expectedHeaders, httpWebRequest.Headers.ToString());


        }
    
        [TestMethod]
        public void GetHttpWebRequest_paramsRequest_Length_0()
        {
            // Arrang
            API_Yandex_Direct.Get.AdGroup.ParamsRequest paramsRequest
                = new API_Yandex_Direct.Get.AdGroup.ParamsRequest(new API_Yandex_Direct.Get.AdGroup.FieldNamesEnum[] { })
                { SelectionCriteria = new API_Yandex_Direct.Get.AdGroup.AdGroupsSelectionCriteria() };

            RequestObjectV5 requestObjectV5 = new RequestObjectV5() { Method = "get", Params = paramsRequest };

            string[] Headers = new string[] { };
            string setBodyRequest = "";
            string expectedSetBodyRequest = "ParamsRequest.FieldNames.Length = 0 не допустимо";

            // Act
            HttpWebRequest httpWebRequest = GetHttpWebRequest(requestObjectV5, UrlDirect, false, ref Headers, ref setBodyRequest);

            // Assert
            Assert.AreEqual(expectedSetBodyRequest, setBodyRequest);
            Assert.IsNull(httpWebRequest);


        }

        [TestMethod]
        public void GetHttpWebRequest_Params_isNull()
        {
            // Arrang     
            RequestObjectV5 requestObjectV5 = new RequestObjectV5() { Method = "get", Params = null };

            string[] Headers = new string[] { };
            string setBodyRequest = "";
            string expectedSetBodyRequest = "Params == null не допустимо";

            // Act
            HttpWebRequest httpWebRequest = GetHttpWebRequest(requestObjectV5, UrlDirect, false, ref Headers, ref setBodyRequest);

            // Assert
            Assert.AreEqual(expectedSetBodyRequest, setBodyRequest);
            Assert.IsNull(httpWebRequest);


        }

        [TestMethod]
        public void GetHttpWebRequest_requestObj_isNull()
        {
            // Arrang

            string[] Headers = new string[] { };
            string setBodyRequest = "";
            string expectedSetBodyRequest = "requestObj is null не допустимо";

            // Act
            HttpWebRequest httpWebRequest = GetHttpWebRequest(null, UrlDirect, false, ref Headers, ref setBodyRequest);

            // Assert
            Assert.AreEqual(expectedSetBodyRequest, setBodyRequest);
            Assert.IsNull(httpWebRequest);


        }

    }
}
