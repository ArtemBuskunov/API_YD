using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Set.KeywordBids
{
    [DataContract]
    public class ParamsRequest
    {
        /// <summary>
        /// Ставки и/или приоритеты.
        /// </summary>
        [DataMember]
        public KeywordBidSetItem[] KeywordBids { get; set; }
    }
}
