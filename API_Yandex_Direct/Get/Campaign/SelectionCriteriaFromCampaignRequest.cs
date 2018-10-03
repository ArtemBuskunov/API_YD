using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Campaign
{
    /// <summary>
    /// Критерий отбора кампаний.
    ///<para>Чтобы получить все кампании рекламодателя, необходимо указать пустой SelectionCriteria.</para> 
    /// </summary>
    [DataContract]
    public class SelectionCriteriaFromCampaignRequest
    {

        /// <summary>
        /// Отбирать кампании с указанными идентификаторами. Не более 1000 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] Ids { get; set; }

        /// <summary>
        ///Отбирать кампании с указанными типами.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignTypeEnum[] Types { get; set; }

        /// <summary>
        /// Отбирать кампании с указанными состояниями. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignStateEnum[] States { get; set; }

        /// <summary>
        ///Отбирать кампании с указанными статусами.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignStatusSelectionEnum[] Statuses { get; set; }

        /// <summary>
        /// Отбирать кампании с указанными статусами оплаты.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignStatusPaymentEnum[] StatusesPayment { get; set; }
    }
}
