using API_Yandex_Direct.Get.Bids;
using API_Yandex_Direct.Get.Shared;
using System;

namespace API_Yandex_Direct.Get
{
    public class GetBid : GetAbstract
    {
        public Model.Bids[] GetBids(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "bids", "get", ref Headers).Bids; }


        /// <summary>
        /// Получить от API ставки
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе по ставкам</param>
        /// <param name="CampaignIds">Перечень Id кампаний из которых нужны ставки</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Ставик Bids</returns>
        public Model.Bids[] GetBids(long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(new FieldNamesEnum[] { FieldNamesEnum.Bid, FieldNamesEnum.AuctionBids })
            { SelectionCriteria = new BidsSelectionCriteria { CampaignIds = CampaignIds } };

            paramsRequest.SelectionCriteria.CampaignIds = CampaignIds;
            return GetBids(paramsRequest, apiConnect);
        }

        public Model.Bids[] GetBids(FieldNamesEnum[] SetParamsRequest, long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            if (SetParamsRequest is null) { return null; }
            ParamsRequest paramsRequest = new ParamsRequest(SetParamsRequest)
            { SelectionCriteria = new BidsSelectionCriteria { CampaignIds = CampaignIds } };

            paramsRequest.SelectionCriteria.CampaignIds = CampaignIds;
            return GetBids(paramsRequest, apiConnect);
        }

    }
}
