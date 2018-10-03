using API_Yandex_Direct.ApiConnect.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.UpDate.Campaign
{
    [DataContract]
    public class CampaignActionResult : abstractExceptionNotificationClass
    {
        /// <summary>
        /// Идентификатор кампании. Возвращается в случае отсутствия ошибок, см. раздел Операции над массивом объектов.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
    }
}
