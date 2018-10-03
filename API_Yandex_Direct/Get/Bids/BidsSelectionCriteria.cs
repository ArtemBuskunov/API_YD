using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Bids
{
    /// <summary>
    /// Критерий отбора фраз.
    /// </summary>
    [DataContract]
    public class BidsSelectionCriteria
    {
        /// <summary>
        /// Получить ставки или приоритеты для указанных ключевых фраз. Не более 10 000 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] KeywordIds { get; set; }

        /// <summary>
        /// Получить ставки или приоритеты для фраз указанных групп. От 1 до 1000 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] AdGroupIds { get; set; }

        /// <summary>
        /// Получить ставки или приоритеты для фраз указанных кампаний. От 1 до 10 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] CampaignIds { get; set; }


        /// <summary>
        /// Отбирать фразы с указанными статусами возможности показов группы объявлений. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum[] ServingStatuses { get; set; }
    }
}
