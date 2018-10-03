using API_Yandex_Direct.ApiConnect.Infrastructure;
using API_Yandex_Direct.UpDate.Campaign;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Yandex_Direct.UpDate
{
    public class UpDateCampaign
    {

        public Result5 UpDateCampaignRequest(CampaignUpdateItem[] CampaignUpdateItem, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            paramsRequest.Campaigns = CampaignUpdateItem;
            Result5 a = apiConnect.GetResult5(paramsRequest, "campaigns", "update", ref Headers);
            return a;
        }
        

        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ParamsRequest paramsRequest = new ParamsRequest
        {
            Campaigns = new CampaignUpdateItem[] { }
        };

    }
}
