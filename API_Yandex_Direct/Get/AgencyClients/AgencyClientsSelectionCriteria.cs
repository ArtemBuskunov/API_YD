using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.AgencyClients
{
    [DataContract]
    public class AgencyClientsSelectionCriteria
    {
        /// <summary>
        /// Отбирать клиентов с указанными логинами представителей. Не более 10 000 элементов в массиве.
        /// </summary>
        [DataMember]
        public string[] Logins { get; set; }

        /// <summary>
        /// Отбирать клиентов по признаку нахождения в архиве: YES — архивные клиенты, NO — активные клиенты.
        /// </summary>
        [DataMember]
        public YesNoEnum2 Archived { get; set; }

    }
}
