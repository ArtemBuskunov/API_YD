using System.Runtime.Serialization;

namespace API_Yandex_Direct.Set.Bids
{

    [DataContract]
    public class ParamsRequest
    {
        /// <summary>
        /// Ставки и/или приоритеты.
        /// </summary>
        [DataMember]
        public BidSetItem[] Bids { get; set; }
    }
}
