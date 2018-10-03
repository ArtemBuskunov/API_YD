using API_Yandex_Direct.ApiConnect.Infrastructure;
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
        public string UrlDirect { get; set; }
        Queue<Task> apiConnectAs = new Queue<Task>();


        public Result5 GetResult5(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        { return new ApiConnect5(UserRequest, UrlDirect).Get(paramsRequest, ObjectRequest, Metod, ref Headers); }
        public Result5 SetResult5(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        { return new ApiConnect5(UserRequest, UrlDirect).Set(paramsRequest, ObjectRequest, Metod, ref Headers); }
        public List<string[]> RequestReport(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        { return new ApiConnect5(UserRequest, UrlDirect).RequestReport(paramsRequest, ObjectRequest, Metod, ref Headers); }
        public Result4 GetResult4(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers, Result4 result)
        { return new ApiConnect4(UserRequest, UrlDirect).Get(paramsRequest, ObjectRequest, Metod, ref Headers, result); }
    }

    public class ApiConnect5 : ApiConnectA
    {
        public ApiConnect5(UserRequest UserRequest, string url = "api.direct.yandex.com")
        { Units = ""; UrlDirect = url; userRequest = UserRequest; }

        /// <summary>
        /// Строка подключения к api
        /// <param name="UrlDirect">Url - api</param>
        /// <param name="siteUnits">требуемый обект в запросе</param>
        /// /// </summary>
        protected override string ConnectUrl(string siteUnits)
        { return string.Format("https://{0}/json/v5/{1}", UrlDirect, siteUnits); }

        /// <summary>
        /// Тело запроса
        /// <param name="requestObj">объект для отправки в запросе</param>
        /// <param name="tokenApi">Содержит OAuth-токен пользователя Яндекс.Директа, от имени которого осуществляется запрос к API.</param>
        /// </summary>
        protected override string JsonConvertRequestObject(object requestObj)
        { return JsonConvert.SerializeJSon<RequestObjectV5>(requestObj as RequestObjectV5); }

        /// <summary>
        /// Команда запроса
        /// </summary>
        public Result5 Get(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        {
            long limitedBy = 0L;
            Result5 result = new Result5()
            {
                AdGroups = new Model.AdGroup[] { },
                Bids = new Model.Bids[] { },
                Campaigns = new Model.Campaign[] { },
                Clients = new Model.Client[] { },
                Keywords = new Model.KeywordClass[] { },
                KeywordBids = new Model.KeywordBid[] { },
            };
            do
            {
                paramsRequest.Page = new LimitOffset { Offset = limitedBy, Limit = 10000 };

                string sdsf = RequestStreamApi
                    (new RequestObjectV5 { Method = Metod, Params = paramsRequest }, ObjectRequest, ref Headers);

                GetResult s;

                try { s = Newtonsoft.Json.JsonConvert.DeserializeObject<GetResult>(sdsf); }
                catch (Exception e)
                { s = new GetResult { Error = new GetResultError { Error_string = e.Message, Error_code = e.HResult } }; }

                if (s == null) goto end;
                if (s.Error != null)
                { result.Error = s.Error; }
                else
                {
                    limitedBy = s.Result.LimitedBy;

                    if (s.Result.AdGroups != null) result.AdGroups = result.AdGroups.Concat(s.Result.AdGroups).ToArray();
                    if (s.Result.Bids != null) result.Bids = result.Bids.Concat(s.Result.Bids).ToArray();
                    if (s.Result.Campaigns != null) result.Campaigns = result.Campaigns.Concat(s.Result.Campaigns).ToArray();
                    if (s.Result.Clients != null) result.Clients = result.Clients.Concat(s.Result.Clients).ToArray();
                    if (s.Result.Keywords != null) result.Keywords = result.Keywords.Concat(s.Result.Keywords).ToArray();
                    if (s.Result.KeywordBids != null) result.KeywordBids = result.KeywordBids.Concat(s.Result.KeywordBids).ToArray();
                }
                end:;
            }
            while (limitedBy > 0);

            return result;
        }

        /// <summary>
        /// Команда запроса
        /// </summary>
        public Result5 Set(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        {
            Result5 result = new Result5()
            {
                SetResults = new Set.Bids.BidActionResult[] { },
                UpdateResults = new UpDate.Campaign.CampaignActionResult[] { },
            };

            string sdsf = RequestStreamApi
                (new RequestObjectV5 { Method = Metod, Params = paramsRequest }, ObjectRequest, ref Headers);

            GetResult s = Newtonsoft.Json.JsonConvert.DeserializeObject<GetResult>(sdsf);

            if (s.Error != null)
            { result.Error = s.Error; }
            else
            {
                if (s.Result.SetResults != null) result.SetResults = result.SetResults.Concat(s.Result.SetResults).ToArray();
                if (s.Result.UpdateResults != null) result.UpdateResults = result.UpdateResults.Concat(s.Result.UpdateResults).ToArray();
            }
            return result;
        }

        /// <summary>
        /// Команда запроса отчетов
        /// </summary>
        public List<string[]> RequestReport(dynamic paramsRequest, string ObjectRequest, string Metod, ref string[] Headers)
        {
            Result5 result = new Result5()
            {
                SetResults = new Set.Bids.BidActionResult[] { },
                UpdateResults = new UpDate.Campaign.CampaignActionResult[] { },
            };

            List<string[]> sdsf = RequestStreamApiLine(new RequestObjectV5 { Method = Metod, Params = paramsRequest }, ObjectRequest, ref Headers);
            return sdsf;
        }

        public List<string[]> RequestStreamApiLine(RequestObjectV5 requestObj, string siteUnits, ref string[] Headers, bool UseOperatorUnits = false)
        {
            List<string[]> ListL = new List<string[]>();
            try
            {
                string s = RequestStreamApi(requestObj, siteUnits, ref Headers, UseOperatorUnits);
                var result = s.Split(new[] { '\r', '\n' });
                foreach (string row in result)
                {
                    var a = row.Split('\t');
                    if (a.Length == (requestObj.Params as Get.Report.ParamsRequest).FieldNames.Length)
                    { ListL.Add(a); }
                }
            }
            catch (Exception e)
            { }

            return ListL;
        }
    }

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