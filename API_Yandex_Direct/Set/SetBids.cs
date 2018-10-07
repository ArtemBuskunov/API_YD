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
            ParamsRequest paramsRequest = new ParamsRequest { Bids = new BidSetItem[] { } };
            string[] Headers = new string[] { };
            paramsRequest.Bids = BidSetItemList;
            var a = apiConnect.SetResult5(paramsRequest, "bids", "set", ref Headers);
            return "";
        }
    }
}
