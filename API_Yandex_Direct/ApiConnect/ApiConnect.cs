using API_Yandex_Direct.ApiConnect.Infrastructure;
using API_Yandex_Direct.Get.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Yandex_Direct.ApiConnect
{
    public class ApiConnect
    {
        public ApiConnect(UserRequest userRequest, string UrlDirect)
        {
            UserRequest = userRequest;
            UrlDirect = "api.direct.yandex.com";
        }

        internal object GetResult5(ParamsRequest paramsRequest, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public ApiConnect(string TokenApi, string loginClient, AccepLanguage accepLanguage)
        {
            UserRequest = new UserRequest();
            UserRequest.AccepLanguage = accepLanguage;
            UserRequest.loginClient = loginClient;
            UserRequest.TokenApi = TokenApi;
            UrlDirect = "api.direct.yandex.com";
        }
        public ApiConnect(string TokenApi, string loginClient, string urlDirect, AccepLanguage accepLanguage)
        {
            UserRequest = new UserRequest();
            UserRequest.AccepLanguage = accepLanguage;
            UserRequest.loginClient = loginClient;
            UserRequest.TokenApi = TokenApi;
            UrlDirect = urlDirect;
        }
        /// <summary>
        /// Данные клиента Api для подключения.
        /// </summary>
        public UserRequest UserRequest { get; set; }
        /// <summary>
        /// Адрес подключения к Yandex.Direct.v5
        /// </summary>
        public string UrlDirect { get; set; }


        /// <summary>
        /// Вызов к Api для получения данных по объекту
        /// </summary>
        /// <param name="paramsRequest"></param>
        /// <param name="ObjectRequest"></param>
        /// <param name="Metod"></param>
        /// <param name="Headers"></param>
        /// <returns></returns>
        public Result5 GetResult5(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        { return new ApiConnect5(UserRequest, UrlDirect).Get(paramsRequest, ObjectRequest, Metod, ref Headers); }
        /// <summary>
        /// Вызов к Api для отправки новых данных
        /// </summary>
        /// <param name="paramsRequest"></param>
        /// <param name="ObjectRequest"></param>
        /// <param name="Metod"></param>
        /// <param name="Headers"></param>
        /// <returns></returns>
        public Result5 SetResult5(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        { return new ApiConnect5(UserRequest, UrlDirect).Set(paramsRequest, ObjectRequest, Metod, ref Headers); }
        public List<string[]> RequestReport(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        { return new ApiConnect5(UserRequest, UrlDirect).RequestReport(paramsRequest, ObjectRequest, Metod, ref Headers); }
        public Result4 GetResult4(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers, Result4 result)
        { return new ApiConnect4(UserRequest, UrlDirect).Get(paramsRequest, ObjectRequest, Metod, ref Headers, result); }


        Queue<Task> apiConnectAs = new Queue<Task>();


    }
}