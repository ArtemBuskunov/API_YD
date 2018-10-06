using API_Yandex_Direct.Get.Shared;
using System;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.AgencyClients
{
    [DataContract]
    public class ParamsRequest: ParamsRequestAbstract
    {
        public ParamsRequest(FieldNamesEnum[] enumsFieldNames) : base(enumsFieldNames as Array) { }
        /// <summary>
        /// Критерии отбора клиентов.
        ///<para> Чтобы получить параметры всех клиентов агентства, необходимо указать пустую структуру SelectionCriteria.</para>
        /// </summary>
        [DataMember]
        public AgencyClientsSelectionCriteria SelectionCriteria { get; set; }
    }
}
