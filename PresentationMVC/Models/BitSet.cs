using API_Yandex_Direct.Model.KeywordBidl;
using System.Collections.Generic;
using System.Linq;

namespace PresentationMVC.Models
{
    public class KeywordBidSet
    {
        API_Yandex_Direct.ApiConnect.ApiConnect ApiConnect =
          new API_Yandex_Direct.ApiConnect.ApiConnect(
              Setup.SetupGet.OAuthDirect,
              "",
               Setup.SetupGet.UrlDirect,
              API_Yandex_Direct.ApiConnect.Infrastructure.AccepLanguage.ru);
        
        public KeywordBidSet(long Id)
        {
            keywordId = Id;

            List<API_Yandex_Direct.Model.KeywordBid> keywordBids = new API_Yandex_Direct.Get.GetKeywordBid().GetKeywordBidRequest(
                new API_Yandex_Direct.Get.KeywordBid.ParamsRequest()
                {
                    FieldNames = new string[]
                       {
                           API_Yandex_Direct.Get.KeywordBid.FieldNamesList.KeywordId.ToString(),
                           API_Yandex_Direct.Get.KeywordBid.FieldNamesList.ServingStatus.ToString(),
                           API_Yandex_Direct.Get.KeywordBid.FieldNamesList.StrategyPriority.ToString(),
                       },
                    SelectionCriteria = new API_Yandex_Direct.Get.KeywordBid.KeywordBidsSelectionCriteria { KeywordIds = new long[] { keywordId } },
                    SearchFieldNames = new API_Yandex_Direct.Get.KeywordBid.KeywordBidSearchFieldEnum[]
                    {
                        API_Yandex_Direct.Get.KeywordBid.KeywordBidSearchFieldEnum.AuctionBids,
                        API_Yandex_Direct.Get.KeywordBid.KeywordBidSearchFieldEnum.Bid
                    }


                },
                ApiConnect).ToList();

            List<API_Yandex_Direct.Model.KeywordClass> keywordClass =
                new API_Yandex_Direct.Get.GetKeyword().GetKeywordParamsRequest(
                    new API_Yandex_Direct.Get.Keywords.ParamsRequest
                    {
                        FieldNames = new string[]
                        {
                            API_Yandex_Direct.Get.Keywords.FieldNamesList.Id.ToString(),
                            API_Yandex_Direct.Get.Keywords.FieldNamesList.AdGroupId.ToString(),
                            API_Yandex_Direct.Get.Keywords.FieldNamesList.Keyword.ToString()
                        },
                        SelectionCriteria = new API_Yandex_Direct.Get.Keywords.KeywordsSelectionCriteria { Ids = new long[] { keywordId } }

                    }, ApiConnect).ToList();

            if (keywordClass != null) Keyword = keywordClass[0].Keyword;
            if (keywordBids != null)
            {
                BidItems = keywordBids[0].Search.AuctionBids.AuctionBidItems.ToList();
                bit = keywordBids[0].Search.Bid;
            }
        }

        public List<AuctionBidItem> BidItems { get; set; }

        long bit = 0, keywordId = 0;
        public string Keyword { get; set; }
        
        public double Bit
        {
            get { return (double)bit / 1000000; }
            set
            {
                long.TryParse((value * 1000000).ToString(), out bit);
                new API_Yandex_Direct.Set.SetKeywordBids().SetBidsRequest(
                    new API_Yandex_Direct.Set.KeywordBids.KeywordBidSetItem[]
                    {
                        new API_Yandex_Direct.Set.KeywordBids.KeywordBidSetItem {   KeywordId = keywordId, SearchBid = bit }
                    },
                    ApiConnect);
            }
        }

        public long Id { get { return keywordId; } }
    }
}