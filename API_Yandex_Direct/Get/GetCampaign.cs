using API_Yandex_Direct.Get.Campaign;

namespace API_Yandex_Direct.Get
{
    public class GetCampaign
    {
        public Model.Campaign[] GetTotalBase1(ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            return apiConnect.GetResult5(paramsRequest, "campaigns", "get", ref Headers).Campaigns;
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
            SelectionCriteria = new SelectionCriteriaFromCampaignRequest(),
            FieldNames = new string[]
               {
                FieldNamesList.Id.ToString(),
                FieldNamesList.Name.ToString(),
                FieldNamesList.NegativeKeywords.ToString(),
                FieldNamesList.BlockedIps.ToString(),
                FieldNamesList.ClientInfo.ToString(),
                FieldNamesList.Currency.ToString(),
                FieldNamesList.DailyBudget.ToString(),
                FieldNamesList.EndDate.ToString(),
                FieldNamesList.ExcludedSites.ToString(),
                FieldNamesList.Funds.ToString(),
                FieldNamesList.Notification.ToString(),
                FieldNamesList.RepresentedBy.ToString(),
                FieldNamesList.SourceId.ToString(),
                FieldNamesList.StartDate.ToString(),
                FieldNamesList.State.ToString(),
                FieldNamesList.Statistics.ToString(),
                FieldNamesList.Status.ToString(),
                FieldNamesList.StatusClarification.ToString(),
                FieldNamesList.StatusPayment.ToString(),
                FieldNamesList.TimeTargeting.ToString(),
                FieldNamesList.TimeZone.ToString(),
                FieldNamesList.Type.ToString(),
               },
            TextCampaignFieldNames = new ParamsRequest.TextCampaignFieldNamesList[]
             {
                 ParamsRequest.TextCampaignFieldNamesList.BiddingStrategy,
                 ParamsRequest.TextCampaignFieldNamesList.CounterIds,
                 ParamsRequest.TextCampaignFieldNamesList.RelevantKeywords,
                 ParamsRequest.TextCampaignFieldNamesList.Settings
             }
        };
    }
}
