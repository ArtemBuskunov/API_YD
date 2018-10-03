using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.BidModifierI
{
    [DataContract]
    public class MobileAdjustment
    {
        /// <summary>
        /// Значение коэффициента к ставке
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int BidModifier { get; set; }
    }
}
