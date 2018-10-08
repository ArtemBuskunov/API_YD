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
        /// <param name="requestObj">объект которые необходимо отправить RequestObjectV5 или RequestObjectV4</param>
        /// <param name="siteUnits">Объект в Яндекс директ, для запроса</param>
        /// <param name="Headers">Заголовки запроса</param>
        /// <param name="UseOperatorUnits">Use-Operator-Units: true  - Расходовать баллы агентства, а не рекламодателя при выполнении запроса. Заголовок допустим только в запросах от имени агентства.</param>
        /// <returns></returns>
        public string RequestStreamApi(object requestObj, string siteUnits, ref string[] Headers, bool UseOperatorUnits = false)
        {
            string pageContent = "";
            string SetBodyRequest = "";
            HttpWebRequest рttpWebRequest = GetHttpWebRequest(requestObj, siteUnits, UseOperatorUnits, ref Headers, ref SetBodyRequest);

            HttpWebResponse resp = null;

            try { resp = (HttpWebResponse)рttpWebRequest.GetResponse(); }
            catch (WebException ex) { if (ex.Status == WebExceptionStatus.ProtocolError) { resp = ex.Response as HttpWebResponse; } }

            Stream responseStream = resp.GetResponseStream();

            StreamReader myStreamReader = null;
            myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            pageContent = myStreamReader.ReadToEnd();
            myStreamReader.Close();

            List<string> list = new List<string>();
            foreach (var l in resp.Headers) { list.Add(l.ToString() + " : " + resp.Headers[l.ToString()]); }
            list.Add("HttpStatusCode : " + resp.StatusCode.ToString());
            Headers = list.ToArray();
            Request request = new Request
            {
                RequestId = resp.Headers["RequestId"],
                ClientLogin = resp.Headers["Client - Login"],
                Units = resp.Headers["Units"],
                RequestText = рttpWebRequest.Headers.ToString() + "   " + SetBodyRequest,
                ResponseText = resp.Headers.ToString() + "   " + pageContent
            };

            return pageContent;
        }


        /// <summary>
        /// Подготовека HttpWebRequest для запроса к Api 
        /// </summary>
        /// <param name="requestObj">объект которые необходимо отправить RequestObjectV5 или RequestObjectV4</param>
        /// <param name="siteUnits">Адрес по которому отправляется запрос</param>
        /// <param name="UseOperatorUnits">Use-Operator-Units: true  - Расходовать баллы агентства, а не рекламодателя при выполнении запроса. Заголовок допустим только в запросах от имени агентства.</param>
        /// <param name="Headers">Заголовки запроса</param>
        /// <param name="SetBodyRequest">Текстовое представление сформированого запроса</param>
        /// <returns></returns>
        protected HttpWebRequest GetHttpWebRequest
            (object requestObj, string siteUnits, bool UseOperatorUnits, ref string[] Headers, ref string SetBodyRequest)
        {
            #region Проверка входных данных
            if (requestObj is null)
            { SetBodyRequest = "requestObj is null не допустимо"; return null; }
            if (requestObj is RequestObjectV5)
            {
                if ((requestObj as RequestObjectV5).Params is null)
                { SetBodyRequest = "Params == null не допустимо"; return null; }

                if ((requestObj as RequestObjectV5).Params.FieldNames.Length == 0)
                { SetBodyRequest = "ParamsRequest.FieldNames.Length = 0 не допустимо"; return null; }
            }
            else
            {
                if ((requestObj as RequestObjectV4).Param == 0)
                { SetBodyRequest = "Param == null не допустимо"; return null; }

                if ((requestObj as RequestObjectV4).Param.FieldNames.Length == 0)
                { SetBodyRequest = "ParamsRequest.FieldNames.Length = 0 не допустимо"; return null; }
            }
            #endregion

            string SetBodyRequest1 = "";
            byte[] data = { };
            Task task = Task.Run(() =>
            {
                SetBodyRequest1 = JsonConvertRequestObject(requestObj);
                data = Encoding.UTF8.GetBytes(SetBodyRequest1);

            });

            #region Заполнение Headers
            string site = ConnectUrl(siteUnits);

            HttpWebRequest рttpWebRequest = (HttpWebRequest)WebRequest.Create(site);

            рttpWebRequest.Headers.Add(string.Format("Authorization: Bearer {0}", userRequest.TokenApi));
            if (userRequest.loginClient != "") рttpWebRequest.Headers.Add(string.Format("Client-Login:{0}", userRequest.loginClient));
            if (UseOperatorUnits) рttpWebRequest.Headers.Add("Use-Operator-Units: true");
            рttpWebRequest.Headers.Add(string.Format("Accept-Language: {0}", userRequest.AccepLanguage));

            if (Headers.Length != 0) { foreach (var headers in Headers) { рttpWebRequest.Headers.Add(headers); } }

            рttpWebRequest.ServicePoint.Expect100Continue = false;
            рttpWebRequest.Method = "POST";
            рttpWebRequest.ContentType = "application/json; charset=utf-8";
            #endregion

            task.Wait();

            SetBodyRequest = SetBodyRequest1;

            рttpWebRequest.ContentLength = data.Length;
            рttpWebRequest.Proxy = null; // Для ускорение рttpWebRequest.GetRequestStream() - указываем отсутсвие Proxy
            рttpWebRequest.AllowAutoRedirect = false;// Для ускорение рttpWebRequest.GetRequestStream() - указываем отсутсвие перехода на другу строницу
            рttpWebRequest.ServicePoint.ConnectionLimit = 5; // Указываем количество потоков которые могут быть одномоментно обработаны
            using (Stream requestStream = рttpWebRequest.GetRequestStream())
            { requestStream.Write(data, 0, data.Length); }

            return рttpWebRequest;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="requestObj">объект которые необходимо отправить RequestObjectV5 или RequestObjectV4</param>
        ///// <param name="siteUnits">Адрес по которому отправляется запрос</param>
        ///// <param name="UseOperatorUnits">Use-Operator-Units: true  - Расходовать баллы агентства, а не рекламодателя при выполнении запроса.Заголовок допустим только в запросах от имени агентства.</param>
        ///// <param name="Headers">Заголовки запроса</param>
        ///// <returns></returns>
        //protected string requestStream(object requestObj, string siteUnits, bool UseOperatorUnits, ref string[] Headers)
        //{
        //    string SetBodyRequest = "";
        //    HttpWebRequest рttpWebRequest = GetHttpWebRequest(requestObj, siteUnits, UseOperatorUnits, ref Headers, ref SetBodyRequest);

        //    HttpWebResponse resp = null;

        //    try { resp = (HttpWebResponse)рttpWebRequest.GetResponse(); }
        //    catch (WebException ex) { if (ex.Status == WebExceptionStatus.ProtocolError) { resp = ex.Response as HttpWebResponse; } }

        //    Stream responseStream = resp.GetResponseStream();

        //    StreamReader myStreamReader = null;


        //    myStreamReader = new StreamReader(responseStream, Encoding.UTF8);

        //    string pageContent = myStreamReader.ReadToEnd();

        //    List<string> list = new List<string>();
        //    foreach (var l in resp.Headers) { list.Add(l.ToString() + " : " + resp.Headers[l.ToString()]); }
        //    list.Add("HttpStatusCode : " + resp.StatusCode.ToString());
        //    Headers = list.ToArray();
        //    Request request = new Request
        //    {
        //        RequestId = resp.Headers["RequestId"],
        //        ClientLogin = resp.Headers["Client - Login"],
        //        Units = resp.Headers["Units"],
        //        RequestText = рttpWebRequest.Headers.ToString() + "   " + SetBodyRequest,
        //        ResponseText = resp.Headers.ToString() + "   " + pageContent
        //    };

        //    return pageContent;
        //}

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
