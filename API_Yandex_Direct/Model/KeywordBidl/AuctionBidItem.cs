using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Model.KeywordBidl
{
    [DataContract]
    public class AuctionBidItem
    {
        /// <summary>
        /// Объем трафика.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int TrafficVolume { get; set; }

        /// <summary>
        /// Ставка на поиске, соответствующая указанному объему трафика.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary>
        /// Списываемая цена, соответствующая указанному объему трафика.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Price { get; set; }
    }
}
