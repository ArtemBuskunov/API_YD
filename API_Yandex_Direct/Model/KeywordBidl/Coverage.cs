using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Model.KeywordBidl
{
    [DataContract]
    public class Coverage
    {
        /// <summary>
        /// Массив ставок, соответствующих охвату различных долей аудитории.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public NetworkCoverageItem[] CoverageItems { get; set; }

    }
}
