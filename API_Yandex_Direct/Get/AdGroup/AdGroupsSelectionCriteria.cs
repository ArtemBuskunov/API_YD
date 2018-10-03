using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.AdGroup
{
    /// <summary>
    /// Критерий отбора кампаний.
    ///<para>Чтобы получить все кампании рекламодателя, необходимо указать пустой SelectionCriteria.</para> 
    /// </summary>
    [DataContract]
    public class AdGroupsSelectionCriteria
    {

        /// <summary>
        /// Отбирать группы указанных кампаний. От 1 до 10 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] CampaignIds { get; set; }

        /// <summary>
        /// Отбирать группы с указанными идентификаторами. От 1 до 10 000 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] Ids { get; set; }

        /// <summary>
        ///Отбирать группы с указанными типами.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public AdGroupTypesEnum[] Types { get; set; }

        /// <summary>
        /// Отбирать группы с указанными статусами. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StatusEnum[] Statuses { get; set; }

        /// <summary>
        ///Отбирать группы с указанными статусами возможности показов.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum[] ServingStatuses { get; set; }

        /// <summary>
        /// Отбирать группы по результату модерации иконки приложения
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ModerationStatusEnum[] AppIconStatuses { get; set; }
    }
}
