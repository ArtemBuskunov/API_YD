using API_Yandex_Direct.Get.Forecast;
using API_Yandex_Direct.Model.Forecast;

namespace API_Yandex_Direct.Get
{
    public class GetForecast
    {
        public GetForecastInfo GetForecastRequest(ApiConnect.ApiConnect apiConnect, int IdRequest)
        {
            string[] Headers = new string[] { };
            ForecastRequest requestResult4 = new ForecastRequest();
            return apiConnect.GetResult4(IdRequest, "", "GetForecast", ref Headers, requestResult4).Data as GetForecastInfo;
        }

        public ForecastStatusInfo[] GetForecastListRequest(ApiConnect.ApiConnect apiConnect)
        {

            string[] Headers = new string[] { };
            GetForecastList requestResult4 = new GetForecastList();
            return apiConnect.GetResult4(null, "", "GetForecastList", ref Headers, requestResult4).Data as ForecastStatusInfo[];
            
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";
    }
}
