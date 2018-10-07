using API_Yandex_Direct.Set.KeywordBids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Set
{
    public class SetKeywordBids
    {
        public string SetBidsRequest(KeywordBidSetItem[] keywordBidSetItems, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest { KeywordBids = new KeywordBidSetItem[] { } };
            string[] Headers = new string[] { };
            paramsRequest.KeywordBids = keywordBidSetItems;
            var a = apiConnect.SetResult5(paramsRequest, "keywordbids", "set", ref Headers);
            return "";
        }
    }
}
