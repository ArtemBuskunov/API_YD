using API_Yandex_Direct.Get.Campaign;
using API_Yandex_Direct.Get.Shared;

namespace API_Yandex_Direct.Get
{
    public class GetCampaign : GetAbstract
    {
        public Model.Campaign[] GetCampaigns(ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest
        (
            new FieldNamesEnum[]
               {
                FieldNamesEnum.Id,
                FieldNamesEnum.Name,
                FieldNamesEnum.NegativeKeywords,
                FieldNamesEnum.BlockedIps,
                FieldNamesEnum.ClientInfo,
                FieldNamesEnum.Currency,
                FieldNamesEnum.DailyBudget,
                FieldNamesEnum.EndDate,
                FieldNamesEnum.ExcludedSites,
                FieldNamesEnum.Funds,
                FieldNamesEnum.Notification,
                FieldNamesEnum.RepresentedBy,
                FieldNamesEnum.SourceId,
                FieldNamesEnum.StartDate,
                FieldNamesEnum.State,
                FieldNamesEnum.Statistics,
                FieldNamesEnum.Status,
                FieldNamesEnum.StatusClarification,
                FieldNamesEnum.StatusPayment,
                FieldNamesEnum.TimeTargeting,
                FieldNamesEnum.TimeZone,
                FieldNamesEnum.Type,
               }
            )
            {
                SelectionCriteria = new SelectionCriteriaFromCampaignRequest(),
                TextCampaignFieldNames = new ParamsRequest.TextCampaignFieldNamesList[]
             {
                 ParamsRequest.TextCampaignFieldNamesList.BiddingStrategy,
                 ParamsRequest.TextCampaignFieldNamesList.CounterIds,
                 ParamsRequest.TextCampaignFieldNamesList.RelevantKeywords,
                 ParamsRequest.TextCampaignFieldNamesList.Settings
             }
            };
            return GetCampaigns(paramsRequest, apiConnect);
        }
        public Model.Campaign[] GetCampaigns(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "campaigns", "get", ref Headers).Campaigns; }
    }
}
