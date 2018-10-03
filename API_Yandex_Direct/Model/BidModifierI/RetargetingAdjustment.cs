using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.BidModifierI
{
    /// <summary>
    /// Параметры корректировки ставок для посетивших сайт.
    /// </summary>
    [DataContract]
    public class RetargetingAdjustment
    {
        /// <summary>
        /// Идентификатор условия подбора аудитории. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long RetargetingConditionId { get; set; }

        /// <summary>
        /// Признак того, что все цели и сегменты в условии подбора аудитории доступны рекламодателю. Значение NO — одна или несколько целей или один или несколько сегментов недоступны.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Accessible { get; set; }

        /// <summary>
        /// Включен или отключен набор корректировок по полу и возрасту.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Enabled { get; set; }

        /// <summary>
        /// Значение коэффициента к ставке
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int BidModifier { get; set; }
    }
}
