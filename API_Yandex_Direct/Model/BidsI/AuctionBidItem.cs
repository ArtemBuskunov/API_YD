using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.BidsI
{
    [DataContract]
    public class AuctionBidItem
    {
        /// <summary>
        /// Позиция показа.
        /// <para> Pmn, где
        /// <para> m — номер блока(1 — спецразмещение, 2 — блок гарантированных показов);</para>
        /// <para> n — номер позиции в рамках блока.</para>
        /// <para>Например, P12 — 2-я позиция в спецразмещении, P21 — 1-я позиция в блоке гарантированных показов.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Position { get; set; }

        /// <summary>
        /// Минимальная ставка за указанную позицию.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary>
        /// Списываемая цена для указанной позиции.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Price { get; set; }
    }
}
