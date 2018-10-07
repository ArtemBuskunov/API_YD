using System;
using API_Yandex_Direct.Get;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Yandex_Direct.Tests.Get
{
    [TestClass]
    public class ParamsRequest
    {
        [TestMethod]
        public void ParamsRequestBase_Get_AdGroup()
        {
            // Arrang
            string[] expected = new string[] { "CampaignId", "Id", "Name", "NegativeKeywords", "RegionIds", "RestrictedRegionIds" };
            // Act 
            API_Yandex_Direct.Get.AdGroup.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.AdGroup.ParamsRequest(
                    new API_Yandex_Direct.Get.AdGroup.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.CampaignId,
                        API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.Id,
                        API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.Name,
                        API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.NegativeKeywords,
                        API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.RegionIds,
                        API_Yandex_Direct.Get.AdGroup.FieldNamesEnum.RestrictedRegionIds,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }
        
        [TestMethod]
        public void ParamsRequestBase_Get_AgencyClients()
        {
            // Arrang
            string[] expected = new string[] { "AccountQuality", "Archived", "ClientId", "ClientInfo", "CountryId" };
            // Act 
            API_Yandex_Direct.Get.AgencyClients.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.AgencyClients.ParamsRequest(
                    new API_Yandex_Direct.Get.AgencyClients.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.AgencyClients.FieldNamesEnum.AccountQuality,
                        API_Yandex_Direct.Get.AgencyClients.FieldNamesEnum.Archived,
                        API_Yandex_Direct.Get.AgencyClients.FieldNamesEnum.ClientId,
                        API_Yandex_Direct.Get.AgencyClients.FieldNamesEnum.ClientInfo,
                        API_Yandex_Direct.Get.AgencyClients.FieldNamesEnum.CountryId,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }

        [TestMethod]
        public void ParamsRequestBase_Get_BidModifier()
        {
            // Arrang
            string[] expected = new string[] { "AdGroupId", "CampaignId", "Id", "Level", "Type" };
            // Act 
            API_Yandex_Direct.Get.BidModifier.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.BidModifier.ParamsRequest(
                    new API_Yandex_Direct.Get.BidModifier.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.BidModifier.FieldNamesEnum.AdGroupId,
                        API_Yandex_Direct.Get.BidModifier.FieldNamesEnum.CampaignId,
                        API_Yandex_Direct.Get.BidModifier.FieldNamesEnum.Id,
                        API_Yandex_Direct.Get.BidModifier.FieldNamesEnum.Level,
                        API_Yandex_Direct.Get.BidModifier.FieldNamesEnum.Type,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }

        [TestMethod]
        public void ParamsRequestBase_Get_Bids()
        {
            // Arrang
            string[] expected = new string[] { "AdGroupId", "AuctionBids", "CampaignId", "ContextBid", "Bid", "KeywordId" };
            // Act 
            API_Yandex_Direct.Get.Bids.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.Bids.ParamsRequest(
                    new API_Yandex_Direct.Get.Bids.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.Bids.FieldNamesEnum.AdGroupId,
                        API_Yandex_Direct.Get.Bids.FieldNamesEnum.AuctionBids,
                        API_Yandex_Direct.Get.Bids.FieldNamesEnum.CampaignId,
                        API_Yandex_Direct.Get.Bids.FieldNamesEnum.ContextBid,
                        API_Yandex_Direct.Get.Bids.FieldNamesEnum.Bid,
                        API_Yandex_Direct.Get.Bids.FieldNamesEnum.KeywordId,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }

        [TestMethod]
        public void ParamsRequestBase_Get_Campaign()
        {
            // Arrang
            string[] expected = new string[] { "BlockedIps", "ClientInfo", "Currency", "DailyBudget", "EndDate", "ExcludedSites" };
            // Act 
            API_Yandex_Direct.Get.Campaign.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.Campaign.ParamsRequest(
                    new API_Yandex_Direct.Get.Campaign.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.Campaign.FieldNamesEnum.BlockedIps,
                        API_Yandex_Direct.Get.Campaign.FieldNamesEnum.ClientInfo,
                        API_Yandex_Direct.Get.Campaign.FieldNamesEnum.Currency,
                        API_Yandex_Direct.Get.Campaign.FieldNamesEnum.DailyBudget,
                        API_Yandex_Direct.Get.Campaign.FieldNamesEnum.EndDate,
                        API_Yandex_Direct.Get.Campaign.FieldNamesEnum.ExcludedSites,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }

        [TestMethod]
        public void ParamsRequestBase_Get_Client()
        {
            // Arrang
            string[] expected = new string[] { "AccountQuality", "ClientInfo", "Currency", "Login", "Notification", "OverdraftSumAvailable" };
            // Act 
            API_Yandex_Direct.Get.Client.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.Client.ParamsRequest(
                    new API_Yandex_Direct.Get.Client.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.Client.FieldNamesEnum.AccountQuality                        ,
                        API_Yandex_Direct.Get.Client.FieldNamesEnum.ClientInfo,
                        API_Yandex_Direct.Get.Client.FieldNamesEnum.Currency,
                        API_Yandex_Direct.Get.Client.FieldNamesEnum.Login,
                        API_Yandex_Direct.Get.Client.FieldNamesEnum.Notification,
                        API_Yandex_Direct.Get.Client.FieldNamesEnum.OverdraftSumAvailable,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }

        [TestMethod]
        public void ParamsRequestBase_Get_KeywordBid()
        {
            // Arrang
            string[] expected = new string[] { "AdGroupId", "CampaignId", "KeywordId", "ServingStatus", "StrategyPriority" };
            // Act 
            API_Yandex_Direct.Get.KeywordBid.ParamsRequest paramsRequest =
                new API_Yandex_Direct.Get.KeywordBid.ParamsRequest(
                    new API_Yandex_Direct.Get.KeywordBid.FieldNamesEnum[] {
                        API_Yandex_Direct.Get.KeywordBid.FieldNamesEnum.AdGroupId                        ,
                        API_Yandex_Direct.Get.KeywordBid.FieldNamesEnum.CampaignId,
                        API_Yandex_Direct.Get.KeywordBid.FieldNamesEnum.KeywordId,
                        API_Yandex_Direct.Get.KeywordBid.FieldNamesEnum.ServingStatus,
                        API_Yandex_Direct.Get.KeywordBid.FieldNamesEnum.StrategyPriority,
                    });
            // Assert
            CollectionAssert.AreEqual(expected, paramsRequest.FieldNames);
        }
    }
}
