using API_Yandex_Direct.Create.ForecastReport;

namespace API_Yandex_Direct.Create
{
    public class CreateForecast
    {
        public int CreateNewForecastRequest(ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            CreateForecastReport requestResult4 = new CreateForecastReport();
            return (int)apiConnect.GetResult4(paramsRequest, "", "CreateNewForecast", ref Headers, requestResult4).Data;
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";

        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ForecastInfo paramsRequest = new ForecastInfo
        {
            Phrases = new string[] { "вопрос контрольный" }
        };
    }
}
