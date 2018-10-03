using API_Yandex_Direct.Get.Bids;

namespace API_Yandex_Direct.Get
{
    public class GetBids
    {
        /// <summary>
        /// Получить от API ставки
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе по ставкам</param>
        /// <param name="CampaignIds">Перечень Id кампаний из которых нужны ставки</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Ставик Bids</returns>
        public Model.Bids[] GetBidsCampParamsRequest(FieldNamesList[] SetParamsRequest, long[] CampaignIds, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };

            string[] pr = new string[SetParamsRequest.Length];
            for (int i = 0; i < SetParamsRequest.Length; i++) { pr[i] = SetParamsRequest[i].ToString(); }
            paramsRequest.FieldNames = pr;
            paramsRequest.SelectionCriteria.CampaignIds = CampaignIds;
            return GetBidsCampParamsRequest(paramsRequest, apiConnect);
        }

        /// <summary>
        /// Получить от API ставки
        /// </summary>
        /// <param name="paramsRequest">фильтр запроса</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Ставик Bids </returns>
        public Model.Bids[] GetBidsCampParamsRequest(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            return apiConnect.GetResult5(paramsRequest, "bids", "get", ref Headers).Bids;
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
            SelectionCriteria = new BidsSelectionCriteria(),
            FieldNames = new string[]
               {
                FieldNamesList.Bid.ToString(),
                FieldNamesList.AuctionBids.ToString()
               }
        };

    }
}
