using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Model.KeywordBidl
{
    [DataContract]
    public class Network
    {
        /// <summary>
        /// Ставка в сетях, назначенная рекламодателем.
        /// <para>Для автотаргетинга параметр не возвращается.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary>
        /// Ставки в сетях, соответствующие охвату различных долей аудитории для данной фразы.
        /// <para>Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), возвращается null (nil).</para>
        /// <para>Если в кампании выбрана стратегия показа в сетях SERVING_OFF или NETWORK_DEFAULT, возвращается null (nil).</para>
        /// <para>Для автотаргетинга возвращается null (nil).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Coverage Coverage { get; set; }

    }
}
