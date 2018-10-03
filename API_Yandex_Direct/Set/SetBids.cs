using API_Yandex_Direct.Set.Bids;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Yandex_Direct.Set
{
    public class SetBids
    {

        public string SetBidsRequest(BidSetItem[] BidSetItemList, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            paramsRequest.Bids = BidSetItemList;
            var a = apiConnect.SetResult5(paramsRequest, "bids", "set", ref Headers);
            return "";
        }

        ///// <summary>
        /////  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        ///// </summary>
        //public string Units = "";

        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ParamsRequest paramsRequest = new ParamsRequest { Bids = new BidSetItem[] { } };

    }
}
