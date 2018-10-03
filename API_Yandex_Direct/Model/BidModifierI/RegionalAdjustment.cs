using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.BidModifierI
{
    /// <summary>
    /// Параметры корректировки ставок по региону показа.
    /// </summary>
    [DataContract]
    public class RegionalAdjustment
    {
        /// <summary>
        /// Идентификатор региона из справочника регионов.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long RegionId { get; set; }

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
