using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using API_Yandex_Direct.ApiConnect.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Yandex_Direct.Tests
{
    [TestClass]
    public class ApiConnect
    {        
        [TestMethod]
        public void constructorApiConnect1()
        {
            // Arrang
            UserRequest userRequest = new UserRequest
            {
                AccepLanguage = AccepLanguage.ru,
                loginClient = "Tester",
                TokenApi = "10"
            };

            AccepLanguage expected = AccepLanguage.ru;
            string expected1 = "Tester";
            string expected2 = "10";
            string expected3 = "api.direct.yandex.com";
            // Act
            API_Yandex_Direct.ApiConnect.ApiConnect apiConnect = new API_Yandex_Direct.ApiConnect.ApiConnect(userRequest);

            // Assert
            Assert.AreEqual(expected, apiConnect.UserRequest.AccepLanguage);
            Assert.AreEqual(expected1, apiConnect.UserRequest.loginClient);
            Assert.AreEqual(expected2, apiConnect.UserRequest.TokenApi);
            Assert.AreEqual(expected3, apiConnect.UrlDirect);
        }

        [TestMethod]
        public void constructorApiConnect2()
        {
            // Arrang
            UserRequest userRequest = new UserRequest
            {
                AccepLanguage = AccepLanguage.ru,
                loginClient = "Tester",
                TokenApi = "10"
            };

            AccepLanguage expected = AccepLanguage.ru;
            string expected1 = "Tester";
            string expected2 = "10";
            string expected3 = "api.direct1.yandex.com";
            // Act
            API_Yandex_Direct.ApiConnect.ApiConnect apiConnect = new API_Yandex_Direct.ApiConnect.ApiConnect(userRequest, "api.direct1.yandex.com");

            // Assert
            Assert.AreEqual(expected, apiConnect.UserRequest.AccepLanguage);
            Assert.AreEqual(expected1, apiConnect.UserRequest.loginClient);
            Assert.AreEqual(expected2, apiConnect.UserRequest.TokenApi);
            Assert.AreEqual(expected3, apiConnect.UrlDirect);
        }

        [TestMethod]
        public void constructorApiConnect3()
        {
            // Arrang

            AccepLanguage expected = AccepLanguage.ru;
            string expected1 = "Tester";
            string expected2 = "10";
            string expected3 = "api.direct1.yandex.com";
            // Act
            API_Yandex_Direct.ApiConnect.ApiConnect apiConnect = 
                new API_Yandex_Direct.ApiConnect.ApiConnect("10", "Tester", "api.direct1.yandex.com", AccepLanguage.ru);

            // Assert
            Assert.AreEqual(expected, apiConnect.UserRequest.AccepLanguage);
            Assert.AreEqual(expected1, apiConnect.UserRequest.loginClient);
            Assert.AreEqual(expected2, apiConnect.UserRequest.TokenApi);
            Assert.AreEqual(expected3, apiConnect.UrlDirect);
        }

        [TestMethod]
        public void constructorApiConnect4()
        {
            // Arrang

            AccepLanguage expected = AccepLanguage.ru;
            string expected1 = "Tester";
            string expected2 = "10";
            string expected3 = "api.direct.yandex.com";
            // Act
            API_Yandex_Direct.ApiConnect.ApiConnect apiConnect =
                new API_Yandex_Direct.ApiConnect.ApiConnect("10", "Tester", AccepLanguage.ru);

            // Assert
            Assert.AreEqual(expected, apiConnect.UserRequest.AccepLanguage);
            Assert.AreEqual(expected1, apiConnect.UserRequest.loginClient);
            Assert.AreEqual(expected2, apiConnect.UserRequest.TokenApi);
            Assert.AreEqual(expected3, apiConnect.UrlDirect);
        }
    }
}
