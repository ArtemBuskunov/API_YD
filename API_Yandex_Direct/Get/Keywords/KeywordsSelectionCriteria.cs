using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Keywords
{
    /// <summary>
    ///Критерий отбора фраз.
    /// </summary>
    [DataContract]
    public class KeywordsSelectionCriteria
    {
        /// <summary>
        /// Отбирать фразы с указанными идентификаторами. От 1 до 10 000 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] Ids { get; set; }

        /// <summary>
        /// Отбирать фразы указанных групп. От 1 до 1000 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] AdGroupIds { get; set; }

        /// <summary>
        /// Отбирать фразы указанных кампаний. От 1 до 10 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] CampaignIds { get; set; }

        /// <summary>
        /// Отбирать фразы с указанными состояниями. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StateEnum[] States { get; set; }

        /// <summary>
        /// Отбирать фразы с указанными статусами.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StatusEnum[] Statuses { get; set; }

        /// <summary>
        /// Отбирать фразы с указанными статусами возможности показов группы объявлений. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum[] ServingStatuses { get; set; }

        /// <summary>
        /// Отбирать фразы, в которых были изменения начиная с указанной даты. 
        /// <para>Задается в формате YYYY-MM-DDThh:mm:ssZ (согласно ISO 8601), например 2015-05-24T23:59:59Z</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string ModifiedSince { get; set; }
    }
}
