using API_Yandex_Direct.Model.BidModifierI;
using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model
{
    [DataContract]
    public class BidModifier
    {
        /// <summary>
        /// Идентификатор кампании, к которой относится ключевая фраза. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long CampaignId { get; set; }

        /// <summary>
        /// Идентификатор группы объявлений, к которой относится ключевая фраза.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long AdGroupId { get; set; }

        /// <summary>
        /// Идентификатор ключевой фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Уровень корректировки
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public BidModifierLevelEnum Level { get; set; }
        
        /// <summary>
        /// Тип корректировки
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public BidModifierTypeEnum Type { get; set; }
        
        /// <summary>
        /// Параметры корректировки на мобильных.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MobileAdjustment MobileAdjustment { get; set; }

        /// <summary>
        /// Параметры корректировки ставок по полу и возрасту.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DemographicsAdjustment DemographicsAdjustment { get; set; }

        /// <summary>
        /// Параметры корректировки ставок для посетивших сайт.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public RetargetingAdjustment RetargetingAdjustment { get; set; }

        /// <summary>
        /// Параметры корректировки ставок по региону показа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public RegionalAdjustment RegionalAdjustment { get; set; }
    }

}
