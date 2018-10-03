using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Model.KeywordBidl
{
    [DataContract]
    public class NetworkCoverageItem
    {
        /// <summary>
        /// Частота показа (доля аудитории) в сетях. Указывается в процентах от 0 до 100.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal Probability { get; set; }

        /// <summary>
        /// Ставка в сетях, соответствующая указанной частоте показа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }
    }
}
