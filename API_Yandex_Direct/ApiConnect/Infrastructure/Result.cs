using System.Runtime.Serialization;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    [DataContract]
    public class Result5
    {
        public GetResultError Error;

        [DataMember]
        public Model.Client[] Clients { get; set; }

        [DataMember]
        public Model.Campaign[] Campaigns { get; set; }

        [DataMember]
        public Model.KeywordClass[] Keywords { get; set; }

        [DataMember]
        public Model.Bids[] Bids { get; set; }

        [DataMember]
        public Model.KeywordBid[] KeywordBids { get; set; }

        [DataMember]
        public Model.BidModifier[] BidModifiers { get; set; }

        [DataMember]
        public Model.AdGroup[] AdGroups { get; set; }

        [DataMember]
        public Set.Bids.BidActionResult[] SetResults { get; set; }

        [DataMember]
        public UpDate.Campaign.CampaignActionResult[] UpdateResults { get; set; }

        /// <summary>
        /// Порядковый номер последнего возвращенного объекта. Передается в случае, если количество объектов в ответе было ограничено лимитом. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long LimitedBy { get; set; }

     
    }

    [DataContract]
    public abstract class Result4
    {

        /// <summary>
        /// краткое описание ошибки
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string error_detail { get; set; }

        /// <summary>
        ///  дополнительные пояснения, если имеются.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string error_str { get; set; }

        /// <summary>
        /// код ошибки
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string error_code { get; set; }
        
        public object Data { get; set; }
        public abstract object loaddate(string sdsf);
     }
}
