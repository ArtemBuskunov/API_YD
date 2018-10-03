using API_Yandex_Direct.Get.BidModifier;

namespace API_Yandex_Direct.Get
{
    public class GetBidModifier
    {

        public Model.BidModifier[] GetBidsCampParamsRequest
            (FieldNamesList[] SetParamsRequest, long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            string[] pr = new string[SetParamsRequest.Length];
            for (int i = 0; i < SetParamsRequest.Length; i++) { pr[i] = SetParamsRequest[i].ToString(); }
            paramsRequest.FieldNames = pr;
            paramsRequest.SelectionCriteria.CampaignIds = CampaignIds;
            return apiConnect.GetResult5(paramsRequest, "bidmodifiers", "get", ref Headers).BidModifiers;
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";


        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ParamsRequest paramsRequest = new ParamsRequest()
        {
            SelectionCriteria = new BidModifiersSelectionCriteria(),
            FieldNames = new string[]
               {
                FieldNamesList.AdGroupId.ToString(),
                FieldNamesList.CampaignId.ToString(),
                FieldNamesList.Id.ToString(),
                FieldNamesList.Level.ToString(),
                FieldNamesList.Type.ToString(),
               }
        };

    }
}
