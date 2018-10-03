using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    public abstract class ApiConnectA
    {
        /// <summary>
        /// Данные клиента Api для подключения.
        /// </summary>
        protected UserRequest userRequest { get; set; }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// Строка подключения к api
        /// </summary>
        protected string UrlDirect { get; set; }

        /// <summary>
        /// получаем ответ яндекс директ
        /// </summary>
        /// <param name="requestObj">Объект-запрос, отсылается на сторону яндекс директ</param>
        /// <param name="Units">Суточный лимит баллов</param>
        /// <param name="siteUnits">Объект в Яндекс директ, для запроса</param>
        /// <param name="UseOperatorUnits">Расходовать баллы агентства, а не рекламодателя при выполнении запроса.</param>
        /// <returns></returns>
        public string RequestStreamApi(object requestObj, string siteUnits,
            ref string[] Headers, bool UseOperatorUnits = false)
        {
            string pageContent = "";
            try
            {
                Request request = null;
                StreamReader myStreamReader = null;
                pageContent = requestStream(requestObj, siteUnits, UseOperatorUnits,
                    ref myStreamReader, ref request, ref Headers);
                myStreamReader.Close();
            }
            catch (Exception e)
            { }
            return pageContent;
        }

        protected string requestStream(object requestObj, string siteUnits,
             bool UseOperatorUnits, ref StreamReader myStreamReader,
             ref Request request, ref string[] Headers)
        {
            #region подготовка запроса
            string SetBodyRequest = "";
            byte[] data = { };
            Task task = Task.Run(() =>
            {
                SetBodyRequest = JsonConvertRequestObject(requestObj);
                data = Encoding.UTF8.GetBytes(SetBodyRequest);
            });

            HttpWebRequest рttpWebRequest = HttpRequest(siteUnits, UseOperatorUnits, ref Headers);

            task.Wait();

            рttpWebRequest.ContentLength = data.Length;
            #endregion

            Stream requestStream = рttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse resp = null;

            try { resp = (HttpWebResponse)рttpWebRequest.GetResponse(); }
            catch (WebException ex) { if (ex.Status == WebExceptionStatus.ProtocolError) { resp = ex.Response as HttpWebResponse; } }

            Stream responseStream = resp.GetResponseStream();
            myStreamReader = new StreamReader(responseStream, Encoding.UTF8);

            string pageContent = myStreamReader.ReadToEnd();

            List<string> list = new List<string>();
            foreach (var l in resp.Headers) { list.Add(l.ToString() + " : " + resp.Headers[l.ToString()]); }
            list.Add("HttpStatusCode : " + resp.StatusCode.ToString());
            Headers = list.ToArray();

            request = new Request
            {
                RequestId = resp.Headers["RequestId"],
                ClientLogin = resp.Headers["Client - Login"],
                Units = resp.Headers["Units"],
                RequestText = рttpWebRequest.Headers.ToString() + "   " + SetBodyRequest,
                ResponseText = resp.Headers.ToString() + "   " + pageContent
            };

            return pageContent;
        }

        protected HttpWebRequest HttpRequest(string siteUnits, bool UseOperatorUnits, ref string[] Headers)
        {
            string site = ConnectUrl(siteUnits);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(site);

            req.Headers.Add(string.Format("Authorization: Bearer {0}", userRequest.TokenApi));
            if (userRequest.loginClient != "") req.Headers.Add(string.Format("Client-Login:{0}", userRequest.loginClient));
            if (UseOperatorUnits) req.Headers.Add("Use-Operator-Units: true");
            req.Headers.Add(string.Format("Accept-Language: {0}", userRequest.AccepLanguage));

            if (Headers.Length != 0) { foreach (var headers in Headers) { req.Headers.Add(headers); } }

            req.ServicePoint.Expect100Continue = false;
            req.Method = "POST";
            req.ContentType = "application/json; charset=utf-8";

            return req;
        }

        /// <summary>
        /// Строка подключения к api
        /// <param name="siteUnits">требуемый обект в запросе</param>
        /// /// </summary>
        protected abstract string ConnectUrl(string siteUnits);

        /// <summary>
        /// Тело запроса
        /// <param name="requestObj">объект для отправки в запросе</param>
        /// </summary>
        protected abstract string JsonConvertRequestObject(object requestObj);

    }
}
