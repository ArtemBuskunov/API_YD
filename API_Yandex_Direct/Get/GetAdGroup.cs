using API_Yandex_Direct.Get.AdGroup;
using API_Yandex_Direct.Get.Shared;
using System.Linq;
using System;

namespace API_Yandex_Direct.Get
{
    public class GetAdGroup : GetAbstract
    {

        public Model.AdGroup[] GetAdGroups(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "adgroups", "get", ref Headers).AdGroups; }

        public Model.AdGroup[] GetAdGroups(long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(new FieldNamesEnum[] { FieldNamesEnum.Id, FieldNamesEnum.Name })
            { SelectionCriteria = new AdGroupsSelectionCriteria { CampaignIds = CampaignIds } };
            return GetAdGroups(paramsRequest, apiConnect);
        }
        
        public Model.AdGroup[] GetAdGroups(FieldNamesEnum[] GetParamsRequest, long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            if (GetParamsRequest is null) { return null; }
            ParamsRequest paramsRequest = new ParamsRequest(GetParamsRequest)
            { SelectionCriteria = new AdGroupsSelectionCriteria { CampaignIds = CampaignIds } };
            return GetAdGroups(paramsRequest, apiConnect);
        }
                



    }
}
