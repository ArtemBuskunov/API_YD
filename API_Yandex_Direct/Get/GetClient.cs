using API_Yandex_Direct.Get.Client;

namespace API_Yandex_Direct.Get
{
    public class GetClient
    {
        public Model.Client[] GetTotalBase(ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            return apiConnect.GetResult5(paramsRequest, "clients", "get", ref Headers).Clients;
        }

        public Model.Client[] GetCampaignParamsRequest(FieldNamesList[] SetParamsRequest, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            string[] pr = new string[SetParamsRequest.Length];
            for (int i = 0; i < SetParamsRequest.Length; i++) { pr[i] = SetParamsRequest[i].ToString(); }
            paramsRequest.FieldNames = pr;
            return apiConnect.GetResult5(paramsRequest, "clients", "get", ref Headers).Clients;
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";

        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ParamsRequest paramsRequest = new ParamsRequest
        {
            FieldNames = new string[]
               {
                FieldNamesList.ClientId.ToString(),
                FieldNamesList.ClientInfo.ToString()
               }
        };
    }
}
