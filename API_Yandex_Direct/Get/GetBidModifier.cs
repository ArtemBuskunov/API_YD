using API_Yandex_Direct.Get.BidModifier;
using API_Yandex_Direct.Get.Shared;
using System;

namespace API_Yandex_Direct.Get
{
    public class GetBidModifier : GetAbstract
    {
        public Model.BidModifier[] GetBidModifiers(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "bidmodifiers", "get", ref Headers).BidModifiers; }

        public Model.BidModifier[] GetBidModifiers(long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(new FieldNamesEnum[] {
                    FieldNamesEnum.AdGroupId,
                    FieldNamesEnum.CampaignId,
                    FieldNamesEnum.Id,
                    FieldNamesEnum.Level,
                    FieldNamesEnum.Type, })
            { SelectionCriteria = new BidModifiersSelectionCriteria() { CampaignIds = CampaignIds } };
            return GetBidModifiers(paramsRequest, apiConnect);
        }

        public Model.BidModifier[] GetBidModifiers(FieldNamesEnum[] GetParamsRequest, long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            if (GetParamsRequest is null) { return null; }

            ParamsRequest paramsRequest = new ParamsRequest(GetParamsRequest)
            { SelectionCriteria = new BidModifiersSelectionCriteria() { CampaignIds = CampaignIds } };
            return GetBidModifiers(paramsRequest, apiConnect);
        }


    }
}
