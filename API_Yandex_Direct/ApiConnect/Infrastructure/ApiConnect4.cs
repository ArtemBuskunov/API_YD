using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    public class ApiConnect4 : ApiConnectA
    {
        public ApiConnect4(UserRequest UserRequest, string url = "api.direct.yandex.com")
        { Units = ""; UrlDirect = url; userRequest = UserRequest; }

        /// <summary>
        /// Строка подключения к api
        /// <param name="UrlDirect">Url - api</param>
        /// <param name="siteUnits">требуемый обект в запросе</param>
        /// /// </summary>
        protected override string ConnectUrl(string siteUnits)
        { return string.Format("https://{0}/live/v4/json/", UrlDirect); }

        /// <summary>
        /// Тело запроса
        /// <param name="requestObj">объект для отправки в запросе</param>
        /// <param name="tokenApi">Содержит OAuth-токен пользователя Яндекс.Директа, от имени которого осуществляется запрос к API.</param>
        /// </summary>
        protected override string JsonConvertRequestObject(object requestObj)
        {
            var RequestObjectV4 = requestObj as RequestObjectV4;
            RequestObjectV4.Token = userRequest.TokenApi;
            return JsonConvert.SerializeJSon<RequestObjectV4>(RequestObjectV4);
        }

        /// <summary>
        /// Команда запроса
        /// </summary>
        public Result4 Get(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers, Result4 result)
        {
            string sdsf = RequestStreamApi
                (new RequestObjectV4
                { Method = Metod, Param = paramsRequest, Locale = userRequest.AccepLanguage.ToString() },
                ObjectRequest, ref Headers);

            result.Data = result.loaddate(sdsf);

            return result;
        }

    }
}
