using API_Yandex_Direct.ApiConnect.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Set.KeywordBids
{
    [DataContract]
    public class KeywordBidActionResult : abstractExceptionNotificationClass
    {
        /// <summary>
        /// Идентификатор кампании.Возвращается в случае отсутствия ошибок, см.раздел Операции над массивом объектов(если был указан в запросе).
        /// </summary>
        [DataMember]
        public long CampaignId { get; set; }

        /// <summary>
        /// Идентификатор группы объявлений.Возвращается в случае отсутствия ошибок, см.раздел Операции над массивом объектов (если был указан в запросе).
        /// </summary>
        [DataMember]
        public long AdGroupId { get; set; }

        /// <summary>
        /// Идентификатор фразы.Возвращается в случае отсутствия ошибок, см.раздел Операции над массивом объектов(если был указан в запросе).
        /// </summary>
        [DataMember]
        public long KeywordId { get; set; }
    }
}
