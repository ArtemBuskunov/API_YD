using API_Yandex_Direct.Get.KeywordBid;
using API_Yandex_Direct.Get.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Get
{
    public class GetKeywordBid : GetAbstract
    {
        /// <summary>
        /// Получить от API ставки
        /// </summary>
        /// <param name="paramsRequest">фильтр запроса</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Ставик Bids </returns>
        public Model.KeywordBid[] GetKeywordBids(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "keywordbids", "get", ref Headers).KeywordBids; }

        /// <summary>
        /// Получить от API ставки
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе по ставкам</param>
        /// <param name="CampaignIds">Перечень Id кампаний из которых нужны ставки</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Ставик Bids</returns>
        public Model.KeywordBid[] GetKeywordBids(long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(new FieldNamesEnum[] { FieldNamesEnum.KeywordId })
            { SelectionCriteria = new KeywordBidsSelectionCriteria { CampaignIds = CampaignIds } };
       
            return GetKeywordBids(paramsRequest, apiConnect);
        }

        /// <summary>
        /// Получить от API ставки
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе по ставкам</param>
        /// <param name="CampaignIds">Перечень Id кампаний из которых нужны ставки</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Ставик Bids</returns>
        public Model.KeywordBid[] GetKeywordBids(FieldNamesEnum[] GetParamsRequest, long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            if (GetParamsRequest is null) { return null; }
            ParamsRequest paramsRequest = new ParamsRequest(GetParamsRequest)
            { SelectionCriteria = new KeywordBidsSelectionCriteria { CampaignIds = CampaignIds } };

            return GetKeywordBids(paramsRequest, apiConnect);
        }

    }
}
