using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Model.KeywordBidl
{
    [DataContract]
    public class AuctionBids
    {
        /// <summary>
        /// Массив ставок и списываемых цен на поиске, соответствующих различным объемам трафика.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public AuctionBidItem[] AuctionBidItems { get; set; }
    }
}
