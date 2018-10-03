using API_Yandex_Direct.Get.AdGroup;

namespace API_Yandex_Direct.Get
{
    public class GetAdGroup
    {
        string[] Headers = new string[] { };
        public Model.AdGroup[] GetAdGroupParamsRequest(FieldNamesEnum[] SetParamsRequest,
            long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            string[] pr = new string[SetParamsRequest.Length];
            for (int i = 0; i < SetParamsRequest.Length; i++) { pr[i] = SetParamsRequest[i].ToString(); }
            paramsRequest.FieldNames = pr;
            paramsRequest.SelectionCriteria.CampaignIds = CampaignIds;
            return apiConnect.GetResult5(paramsRequest, "adgroups", "get", ref Headers).AdGroups;
        }

        ///// <summary>
        /////  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        ///// </summary>
        //public string Units = "";


        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ParamsRequest paramsRequest = new ParamsRequest
        {
            SelectionCriteria = new AdGroupsSelectionCriteria(),
            FieldNames = new string[]
               {
                   FieldNamesEnum.Id.ToString(),
                   FieldNamesEnum.Name.ToString()
               }
        };

    }
}
