using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationMVC.Models
{
    public class Conect
    {


        API_Yandex_Direct.ApiConnect.ApiConnect ApiConnect =
            new API_Yandex_Direct.ApiConnect.ApiConnect(
                Setup.SetupGet.OAuthDirect,
                "",
                 Setup.SetupGet.UrlDirect,
                API_Yandex_Direct.ApiConnect.Infrastructure.AccepLanguage.ru);







        static long[] IdCompany = { };
        static long[] IdAdGroup = { };

        public List<API_Yandex_Direct.Model.Client> Client
        {
            get
            {
                if (client == null) client = new API_Yandex_Direct.Get.GetClient().GetClients(ApiConnect).ToList();
                return client;
            }
        }
        public List<API_Yandex_Direct.Model.Campaign> Campaign
        {
            get
            {
                if (campaign == null)
                {
                    campaign = new API_Yandex_Direct.Get.GetCampaign().GetCampaigns(ApiConnect).ToList();
                    IdCompany = campaign.Select(p => p.Id).ToArray();
                }
                return campaign;
            }
        }
        public List<API_Yandex_Direct.Model.AdGroup> AdGroup
        {
            get
            {
                if (adGroup == null)
                {
                    adGroup = new API_Yandex_Direct.Get.GetAdGroup().GetAdGroups(
                          new API_Yandex_Direct.Get.AdGroup.FieldNamesEnum[]
                          {
                            API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.Id,
                            API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.Name,
                            API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.CampaignId
                          },
                          IdCompany, ApiConnect).ToList();
                    IdAdGroup = adGroup.Select(p => p.Id).ToArray();
                }
                return adGroup;
            }
        }
        public List<API_Yandex_Direct.Model.KeywordClass> KeywordClass
        {
            get
            {
                if (keywordClass == null)
                {
                    API_Yandex_Direct.Get.Keywords.FieldNamesEnum[] fieldNamesEnums = new API_Yandex_Direct.Get.Keywords.FieldNamesEnum[]
                        {
                            API_Yandex_Direct.Get.Keywords.FieldNamesEnum.Id,
                            API_Yandex_Direct.Get.Keywords.FieldNamesEnum.AdGroupId,
                            API_Yandex_Direct.Get.Keywords.FieldNamesEnum.Keyword
                        };
                    var keywordClasses = new API_Yandex_Direct.Get.GetKeyword().GetKeywords(fieldNamesEnums, IdAdGroup, ApiConnect);
                    keywordClass = keywordClasses.ToList();
                }
                return keywordClass;
            }
        }
        public List<API_Yandex_Direct.Model.Bids> Bids
        {
            get
            {
                if (bids == null)
                {
                    bids = new API_Yandex_Direct.Get.GetBid().GetBids(
                        new API_Yandex_Direct.Get.Bids.FieldNamesEnum[]
                        {
                            API_Yandex_Direct.Get.Bids.FieldNamesEnum.KeywordId,
                            API_Yandex_Direct.Get.Bids.FieldNamesEnum.Bid
                        },
                        IdCompany, ApiConnect).ToList();
                }
                return bids;
            }
        }


        List<API_Yandex_Direct.Model.Campaign> campaign { get; set; }
        List<API_Yandex_Direct.Model.AdGroup> adGroup { get; set; }
        List<API_Yandex_Direct.Model.KeywordClass> keywordClass { get; set; }
        List<API_Yandex_Direct.Model.Bids> bids { get; set; }
        List<API_Yandex_Direct.Model.Client> client { get; set; }
    }


}