using API_Yandex_Direct.Get.Shared;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.AgencyClients
{
    [DataContract]
    public class ParamsRequest: ParamsRequestAbstract
    {
        /// <summary>
        /// Критерии отбора клиентов.
        ///<para> Чтобы получить параметры всех клиентов агентства, необходимо указать пустую структуру SelectionCriteria.</para>
        /// </summary>
        [DataMember]
        public AgencyClientsSelectionCriteria SelectionCriteria { get; set; }
    }
}
