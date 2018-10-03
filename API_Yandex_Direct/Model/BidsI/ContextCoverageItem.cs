using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.BidsI
{
    [DataContract]
    public class ContextCoverageItem
    {
        /// <summary>
        /// Частота показа (доля аудитории) в сетях. Указывается в процентах от 0 до 100.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal Probability { get; set; }

        /// <summary>
        /// Ставка в сетях, при которой прогнозируется указанная частота показа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Price { get; set; }
    }
}
